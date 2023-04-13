using Newtonsoft.Json;
using System;

namespace MyLibrary_DotNETstd_2_1.MyJSON
{
    public class MyJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ClassToSerialize toSerialize;
            if (existingValue is ClassToSerialize toSer)
                toSerialize = toSer;
            else
                toSerialize = new ClassToSerialize();

            return serializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
    public class MyJsonConverterT : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ClassToSerialize toSerialize;
            if (existingValue is ClassToSerialize toSer)
                toSerialize = toSer;
            else
                toSerialize = new ClassToSerialize();

            return serializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
