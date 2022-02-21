using static System.Console;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

#region function 1
/*
byte b = 36;

/// <summary>
/// calc factorial of a given number
/// </summary>
static int Factorial(int f)
{
    if (f == 0)
        return 0;
    else if (f == 1)
        return 1;
    else
        checked
        {
            try
            {
                return f * Factorial(f - 1);
            }
            catch (OverflowException)
            {
                WriteLine("OverflowException");
                return -1;
            }
        }
}

WriteLine($"Hello, {Factorial(b)}!");
*/
#endregion

#region lambdas
//static int FibImpertive(int term)
//{
//    if (term == 1)
//        return 0;
//    if (term == 2)
//        return 1;
//    else
//    {
//        return FibImpertive (term-1) + FibImpertive (term-2);
//    }
//}

//static void RunFibImpertive()
//{
//    for (int i = 1; i <= 30; i++)
//    {
//        WriteLine("The {0} term of the Fibonaccii sequence is {1:N0}", arg0 : i, arg1 : FibImpertive(term : i));
//    }
//}

////RunFibImpertive();

//static int FibFunctional(int term) =>
//    term switch
//    {
//        1 => 0,
//        2 => 1,
//        _ => FibImpertive(term - 1) + FibImpertive(term - 2)
//    };

//static void RunFibFunctional()
//{
//    for (int i = 1; i <= 30; i++)
//    {
//        WriteLine("The {0} term of the Fibonaccii sequence is {1:N0}", arg0: i, arg1: FibFunctional(term: i));
//    }
//}

//RunFibFunctional();
#endregion

#region Logging

#region 1 - simple log and tracer

//Add new listener for qriting into a file
//Write a tesxt file in the project folder
//Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "TracerLog.txt"))));

//Need to Flush the buffered text writer for an immidiate writing into the File
//Trace.AutoFlush = true;

//Debug.WriteLine("From Debug - I am watching!");
//Trace.WriteLine("From Trace - I am watching!");
#endregion

#region Microsoft.Extensions.Configuration

//Add NuGet Microsoft.Extensions.Configuration
ConfigurationBuilder builder =  new();

//reference to the manually crated appsettings.json
builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName : "PacktSwitch",
    description : "This switch is set via the appsettings.json config");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Wanrning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");



#endregion

#endregion