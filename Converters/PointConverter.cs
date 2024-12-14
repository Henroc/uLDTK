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
    internal class PointConverter : JsonConverter<Point>
    {
        public override Point Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                reader.Read();
                int x = reader.GetInt32();
                reader.Read();
                int y = reader.GetInt32();
                reader.Read();

                return new Point(x, y);
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                reader.Read();
                reader.Read();
                int x = reader.GetInt32();
                reader.Read();
                reader.Read();
                int y = reader.GetInt32();
                reader.Read();

                return new Point(x, y);
            }
            return Point.Zero;
        }

        public override void Write(Utf8JsonWriter writer, Point value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
