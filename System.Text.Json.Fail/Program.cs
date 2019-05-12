using System.Text.Json.Serialization;

namespace System.Text.Json.Fail
{
    public class TargetSimplified
    {
        public TargetSimplified[] Children { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var document = new TargetSimplified();
            var str = JsonSerializer.ToString(document,
                new JsonSerializerOptions());
        }
    }
}