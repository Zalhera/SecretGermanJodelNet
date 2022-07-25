using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Converter
{
    public class UnixTimestampConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var timeStr = reader.GetString();

            if (string.IsNullOrEmpty(timeStr) || !long.TryParse(timeStr, out var miliseconds))
            {
                throw new FormatException($"{timeStr} is not a correct unix Timestamp");
            }

            var dt = Epoch.AddMilliseconds(miliseconds);
            return dt;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var ticks = value.Ticks.ToString();
            writer.WriteStringValue(ticks);
        }
    }
}
