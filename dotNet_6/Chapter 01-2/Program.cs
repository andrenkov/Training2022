#define MYSYMBOL

using static System.Console;

#region #1
// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.WriteLine(Environment.OSVersion.VersionString);
int x;
*/
#endregion

#region #2 strings
//string firstName = @"Vlad";
//string lastName = @"Andrenkov";

//WriteLine("{0} {1}", firstName, lastName);

//WriteLine($"{firstName} {lastName}");
//WriteLine("{0} {1}", arg0: firstName, arg1: lastName);
//WriteLine("{0} {1}", arg1: firstName, arg0: lastName);
#endregion

#region Args

//WriteLine(args[0] +" " + args[1]);

#endregion

#region OS
//#if NET6_0_OR_GREATER
//WriteLine("NET6_0_OR_GREATER");
//#elif NETCOREAPP
//WriteLine("NETCOREAPP");
//#else
//WriteLine("ELSE");
//#endif

//if (OperatingSystem.IsWindows())
//{
//    WriteLine("IsWindows");
//}
//else
//{
//    WriteLine("Other OS");
//}
#endregion

#region Logical operators
//bool a = true;
//bool b = false;
//WriteLine($"XOR   | a     | b     ");
//WriteLine($"a     | {a ^ a,-5} | {a ^ b,-5} ");
//WriteLine($"b     | {b ^ a, +1} | {b ^ b,10} ");
#endregion

#region switch

int a = 2;


switch (a)
{
case 2:
WriteLine("a == 2");
break;
case 3:
goto case 4;
case 4:
WriteLine("a printed in 4");
break;
default:
goto PrintResult;
}

PrintResult:
WriteLine("went to Label");

#endregion
