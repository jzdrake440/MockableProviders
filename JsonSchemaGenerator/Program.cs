using CodeGenerator.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.IO;

namespace JsonSchemaGenerator
{
    class Program
    {
        public static Type Model = typeof(GeneratorSettings);
        public const string OutputPath = "../CodeGenerator/generatorSettingsSchema.json";

        public static void Main()
        {
            var generator = new JSchemaGenerator
            {
                DefaultRequired = Required.Default,
            };

            generator.GenerationProviders.Add(new StringEnumGenerationProvider());

            var schema = generator.Generate(Model);

            File.Delete(OutputPath);
            File.WriteAllText(OutputPath, schema.ToString());
        }
    }
}
