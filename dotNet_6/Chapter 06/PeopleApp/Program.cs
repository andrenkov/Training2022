using static System.Console;
using PacktLib;

#region Methods and Inner methods
/*
Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

//call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

//call statis method
Person baby2 = Person.Procreate(harry, jill);
baby2.Name = "Vlad";

//use Operator instead
Person baby3 = harry * jill;
baby3.Name = "BOBA";

WriteLine($"{harry.Name} has {harry.Children.Count} children");
WriteLine($"{mary.Name} has {mary.Children.Count} children");
WriteLine($"{jill.Name} has {jill.Children.Count} children");

WriteLine(format:"{0}'s first child is named \"{1}\" ", arg0:harry.Name, arg1: harry.Children[0].Name);
WriteLine(format: $"{baby3.Name} made by Operator");

//call inner function example
WriteLine($"5! is {Person.Factorial(5)}");
*/
#endregion

#region deligations
//delegate methods - test

//1 - call methd using an instance of teh Person
//Person p1 = new();
//int answer = p1.MethodWantToCall("frog");
//WriteLine($"Length of FROG is {answer}");

//2 - use delegate
//declare a deligate - must be at the top of the Namespace
//delegate int DeligateWithMatchingSignature(string s);
////create an instance
//DeligateWithMatchingSignature d = new(Person.MethodWantToCall);
////call the deligate, which calls the method
//int answer2 = d("From");
//WriteLine($"Length of FROG is {answer2}");
#endregion

#region events
/*
Person harry = new() { Name = "Harry" };
static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p?.Name} is this angry : {p?.AngerLevel}.");
}

harry.Shout += Harry_Shout;//+= allow add more methods to teh same deligate
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
*/
#endregion

#region non-geric types - key can be ANY type. Flexible, but leading to bugs
/*
Person harry = new() { Name = "Harry" };

//create non-geric lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Bill");
lookupObject.Add(key: harry, value: "Delta");

WriteLine($"Herry key is {lookupObject[harry]}");
*/
#endregion

#region Geric types - modern a safer waty of working with collections
/*
Person harry = new() { Name = "Harry" };

//create non-geric lookup collection
Dictionary<int, string> lookupIntStr = new();
lookupIntStr.Add(key: 1, value: "Alpha");
lookupIntStr.Add(key: 2, value: "Bill");
lookupIntStr.Add(key: 3, value: "Gamma");
lookupIntStr.Add(key: 4, value: "Delta");

int key = 3;
WriteLine($"{key} key is {lookupIntStr[key]}");
*/
#endregion

#region Interfaces and enheritence
/// <summary>
/// custom exception
/// </summary>
throw new PersonException("Person's exception");
#endregion