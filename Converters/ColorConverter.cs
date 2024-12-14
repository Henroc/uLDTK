using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Ldtk.Converters
{
    internal class ColorConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            if (value == null)
            {
                return default;
            }

            if (value.StartsWith('#'))
            {
                byte r = Convert.ToByte(value[1..3], 16);
                byte g = Convert.ToByte(value[3..5], 16);
                byte b = Convert.ToByte(value[5..7], 16);
                return new Color(r, g, b, (byte)255);
            }

            throw new Exception("Cannot unmarshal type LayerType");
        }

        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
