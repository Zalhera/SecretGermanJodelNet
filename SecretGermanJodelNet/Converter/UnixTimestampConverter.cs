using System.Text.Json;
using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Converter
{
    public class UnixTimestampConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var timestamp))
                throw new FormatException("Unable to read timesteamp");

            var dt = Epoch.AddSeconds(timestamp);
            return dt;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var ticks = value.Ticks.ToString();
            writer.WriteStringValue(ticks);
        }
    }
}
