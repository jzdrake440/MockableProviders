using CodeGenerator.Model;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGenerator
{
    public sealed class Generator
    {
        //leave this as non-static in case instanced dependencies are latter needed
        public string BuildProvider(ProviderSettings settings)
        {
            var usings = new HashSet<string>();

            var @namespace = SyntaxFactory.NamespaceDeclaration(
                SyntaxFactory.ParseName(settings.Namespace ?? settings.Type.Namespace));

            var @interface = SyntaxFactory.InterfaceDeclaration(settings.Output?.FileName ?? $"I{settings.Type.Name}Provider")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            var @class = SyntaxFactory.ClassDeclaration(settings.Output?.FileName ?? $"{settings.Type.Name}Provider")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(@interface.Identifier.ValueText)));


            var implementedMethods = settings.Type.GetMethods(BindingFlags.Public | BindingFlags.Static);

            foreach (var methodInfo in implementedMethods)
            {
                var method = SyntaxFactory.MethodDeclaration(
                    TypeBuilder(methodInfo.ReturnType),
                    SyntaxFactory.Identifier(methodInfo.Name))
                    .WithParameterList(
                        SyntaxFactory.ParameterList().AddParameters((
                        from p in methodInfo.GetParameters()
                        select SyntaxFactory.Parameter(SyntaxFactory.Identifier(p.Name)).WithType(TypeBuilder(p.ParameterType))).ToArray()));

                if (methodInfo.IsGenericMethod)
                    method = method.WithTypeParameterList(
                        SyntaxFactory.TypeParameterList().AddParameters((
                        from ga in methodInfo.GetGenericArguments()
                        select SyntaxFactory.TypeParameter(ga.Name)).ToArray()));


                @interface = @interface.AddMembers(
                    method
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

                @class = @class.AddMembers(
                    method
                    .AddModifiers((
                        from sk in settings.ImplementationModifiers
                        select SyntaxFactory.Token(sk)).ToArray())
                    .WithBody(
                        SyntaxFactory.Block(
                            SyntaxFactory.ReturnStatement(
                                SyntaxFactory.InvocationExpression(
                                    SyntaxFactory.MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.IdentifierName(settings.Type.Name),
                                        methodInfo.IsGenericMethod ?
                                        (SimpleNameSyntax)SyntaxFactory.GenericName(methodInfo.Name)
                                        .WithTypeArgumentList(
                                            SyntaxFactory.TypeArgumentList().AddArguments((
                                            from ga in methodInfo.GetGenericArguments()
                                            select TypeBuilder(ga)).ToArray())) :
                                        SyntaxFactory.IdentifierName(methodInfo.Name)))
                                .WithArgumentList(
                                    SyntaxFactory.ArgumentList().AddArguments((
                                    from p in methodInfo.GetParameters()
                                    select SyntaxFactory.Argument(SyntaxFactory.IdentifierName(p.Name))).ToArray()))))));

                usings.UnionWith(
                    from p in methodInfo.GetParameters()
                    where p.ParameterType.Namespace != @namespace.Name.ToString()
                    select p.ParameterType.Namespace
                    );
            }

            @namespace = @namespace
                .AddMembers(@interface, @class)
                .AddUsings((from s in usings.OrderBy(s => s)
                            select SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName(s))).ToArray());

            return @namespace.NormalizeWhitespace().ToFullString();
        }

        public void BuildAndWriteProvider(ProviderSettings settings, bool append = false, bool overwrite = true)
        {
            string provider = BuildProvider(settings);

            var dirPath = Path.Combine(
                settings.Output.SolutionDirectory,
                settings.Output.ProjectName,
                settings.Output.ProjectDirectory ?? settings.Namespace ?? settings.Type.Namespace);

            Directory.CreateDirectory(dirPath);

            var filePath = Path.Combine(
                dirPath,
                settings.Output.FileName ?? $"{settings.Type.Name}Provider.cs");

            if (overwrite)
                File.WriteAllText(filePath, provider);
            else if (File.Exists(filePath) && append)
                File.AppendAllText(filePath, provider);
            else
                throw new Exception($"File exists: append:{append}, overwrite:{overwrite}, filePath:{filePath}");
        }

        private static TypeSyntax TypeBuilder(Type type)
        {
            if (type.IsGenericType)
            {
                return SyntaxFactory.GenericName(
                    SyntaxFactory.Identifier(TrimGenericName(type.Name)),
                    SyntaxFactory.TypeArgumentList()
                    .AddArguments((from t in type.GenericTypeArguments
                                   select TypeBuilder(t)).ToArray()));
            }

            return SyntaxFactory.ParseTypeName(type.Name);
        }

        private static string TrimGenericName(string name)
        {
            return name.Remove(name.IndexOf('`'));
        }
    }
}
