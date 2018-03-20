using CodeGenerator.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CodeGenerator
{
    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            var serializer = new JsonSerializer();

            using (var fileReader = new StreamReader("generatorSettings.json"))
            using (var jsonReader = new JsonTextReader(fileReader))
            {
                var settings = serializer.Deserialize<GeneratorSettings>(jsonReader);

                foreach (var providerSettings in settings.Providers)
                {
                    ProviderSettings settingsWithDefaults = new ProviderSettings
                    {
                        ImplementationModifiers = providerSettings.ImplementationModifiers ?? settings.Defaults?.ImplementationModifiers,
                        Type = providerSettings.Type ?? settings.Defaults.Type,
                        Namespace = providerSettings.Namespace ?? settings.Defaults?.Namespace,
                        Output = new OutputSettings
                        {
                            FileName = providerSettings.Output?.FileName ?? settings.Defaults?.Output?.FileName ?? GeneratorSettings.DefaultOutputSettings.FileName,
                            ProjectDirectory = providerSettings.Output?.ProjectDirectory ?? settings.Defaults?.Output?.ProjectDirectory ?? GeneratorSettings.DefaultOutputSettings.ProjectDirectory,
                            ProjectName = providerSettings.Output?.ProjectName ?? settings.Defaults?.Output?.ProjectName ?? GeneratorSettings.DefaultOutputSettings.ProjectName,
                            SolutionDirectory = providerSettings.Output?.SolutionDirectory ?? settings.Defaults?.Output?.SolutionDirectory ?? GeneratorSettings.DefaultOutputSettings.SolutionDirectory,
                        }
                    };

                    var generator = new Generator();

                    generator.BuildAndWriteProvider(settingsWithDefaults);
                }
            }
        }
    }
}
