//using System.Text.RegularExpressions;
using static System.Console;
using System.Collections.Immutable;

#region Regex

//Console.Write("Enter your age :");
//string? input = Console.ReadLine();

//Regex ageChecker = new(@"\d");
//Regex ageChecker = new(@"^\d+$");//only digits allow in intire string (no letters)

//decimal-digit chars @ is to disable the escape \ in the string;
//"\d" - one digit

//^	Matches beginning of line
//$	Matches end of line
//.	Match any character
//|	OR operator
//(...)	Capture anything matched
//(?:...)	Non - capturing group
//  [...]   Matches anything contained in brackets
//[^...] Matches anything not contained in brackets
//[a-z] Matches any characters between 'a' and 'z'
//{x}	The exact 'x' amount of times to match
//{x,}	Match 'x' amount of times or more
//{x, y}	Match between 'x' and 'y' times.
//*	Greedy match that matches everything in place of the *
//+	Matches character before + one or more times
//?	Matches the character before the ? zero or one times. Also, used as a non-greedy match
//\	Escape the character after the backslash or create an escape sequence.


//if (ageChecker.IsMatch(input?? ""))
//{
//    Console.WriteLine("Good entry");
//}
//else
//{
//    Console.WriteLine($"{input} is not a valid age");
//}

#endregion

#region Collections

//List - ordered collection
//Dictionaries - each velue has a unique value to be used a key/ It's a struct (pairs of key-value)
//Stacks - good for last-in first-out (LIFO) behaviour
//Queues - good for first-in first out (FIFO
//Sets - good for set operations between two sollections

#region Lists
//WorkingWithLists();

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (var item in collection)
    {
        WriteLine($"  {item}");
    }

}

//static void WorkingWithLists()
//{
//    //List<string> cities = new();
//    //cities.Add("Moscow");
//    //cities.Add("Kiev");
//    //cities.Add("Sochi");

//    List<string> cities = new() 
//        { "Moscow", "Kiev", "Sochi" };

//    Output("Init List", cities);

//    cities.Insert(1, "Minsk");
//    Output("After insert", cities);

//    cities.RemoveAt(1);
//    cities.Remove("Kiev");
//    Output("After remove", cities);
//}
#endregion

#region Dictionaries

//WorkingWithDict();

//static void WorkingWithDict()
//{
//    //Dictionary<string, string> dict = new();
//    ////add data using named params
//    //dict.Add(key: "int", value: "32-bit int type");
//    ////add positional params
//    //dict.Add("long", "64-bit int");
//    //dict.Add("float", "single prec floating point number");

//    //OR
//    Dictionary<string, string> dictNew = new()
//    {
//        { "int", "32-bit int type" },
//        { "long", "64-bit int" },
//        { "float", "single prec floating point number" }
//    };
//    Output("Dict keys: ", dictNew.Keys);
//    Output("Dict values: ", dictNew.Values);

//    foreach (var item in dictNew)
//    { 
//        WriteLine($"  {item.Key}: {item.Value}");
//    }

//    //lookup a value using a key
//    string key = "long";
//    WriteLine($"The definition of {key} is {dictNew[key]}");
//}

#endregion

#region Queues

//Queue<string> coffee = new();
//coffee.Enqueue("Vlad");
//coffee.Enqueue("Sasha");

//string served = coffee.Dequeue();
//WriteLine($"serverd to {served}");

#endregion

#region Autosorting collections

SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
SortedList<string, string> list = new();
SortedSet<string> set = new();

#endregion

#region Immutable Collections
//Collections where its members cannot change. You cannot add or remove items

List<string> cities = new();
cities.Add("moscow");
cities.Add("kiev");
cities.Add("sochi");

ImmutableList<string> immutableCities = cities.ToImmutableList();
ImmutableList<string> newList = immutableCities.Add("Rio");//this is how you  can add an item into ImmutableList

#endregion

#endregion