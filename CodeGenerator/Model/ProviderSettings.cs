using CodeGenerator.Json;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CodeGenerator.Model
{
    public class ProviderSettings
    {
        [JsonConverter(typeof(TypeConverter))]
        public Type Type { get; set; }

        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public SyntaxKind[] ImplementationModifiers { get; set; }
        public OutputSettings Output { get; set; }
        public string Namespace { get; set; }
    }
}
