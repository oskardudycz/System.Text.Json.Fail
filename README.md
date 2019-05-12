# System.Text.Json.Fail
I planned to investigate the usage of [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization) in [Marten](https://github.com/JasperFx/marten).

I used our test class [Target](System.Text.Json.Fail/Target.cs). It's nothing fancy but while trying to call:

```
public class TargetSimplified
{
    public TargetSimplified[] Children { get; set; }
}

var document = new TargetSimplified();
var str = JsonSerializer.ToString(document);
```
It's throwing `StackOverflowException`.

It's reproducible by running sample [Program.cs](https://github.com/oskardudycz/System.Text.Json.Fail/blob/master/System.Text.Json.Fail/Program.cs)
