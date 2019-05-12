# System.Text.Json.Fail
I planned to investigate the usage of [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization) in [Marten](https://github.com/JasperFx/marten).

I used our test class [Target](System.Text.Json.Fail/Target.cs). It's nothing fancy but while trying to call:

```
var document = new Target { Color = Colors.Blue, Number = 1 };
var str = JsonSerializer.ToString(document, new JsonSerializerOptions() { MaxDepth = 1 });
```
It's throwing `StackOverflowException`.
