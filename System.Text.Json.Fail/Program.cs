using System.Text.Json.Serialization;
using Marten.Testing;

namespace System.Text.Json.Fail
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var document = new Target { Color = Colors.Blue, Number = 1 };
            var str = JsonSerializer.ToString(document, new JsonSerializerOptions() { MaxDepth = 1 });
        }
    }
}