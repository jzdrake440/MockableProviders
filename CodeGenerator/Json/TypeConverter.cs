using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenerator.Json
{
    public class TypeConverter : JsonConverter<Type>
    {
        public override Type ReadJson(JsonReader reader, Type objectType, Type existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return Type.GetType(reader.Value as string);
        }

        public override void WriteJson(JsonWriter writer, Type value, JsonSerializer serializer)
        {
            writer.WriteValue(value.AssemblyQualifiedName);
        }
    }
}
