using System.Xml.Linq;

//use commands to publish to specific platforms
//> dotnet publish - c Release - r win10-x64
//> dotnet publish - c Release - r linux - x64
//> dotnet publish - c Release - r osx-x64

//publish into one file use:
//>dotnet publish -c Release -r win10-x64 /p:PublishSingleFile=true


XDocument doc = new();
string s = "xxx";
String S = "XXX";

Console.WriteLine($" {s}  {S}");
