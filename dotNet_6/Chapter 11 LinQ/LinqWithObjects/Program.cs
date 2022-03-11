using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System;

//string[] names = new[] {"Vlad", "Tatiana", "Misha", "Sasha", "Jerry", "Alexei"};
//WriteLine("Defered execution");

#region use <ImplicitUsings>enable</ImplicitUsings>
////Which names start with a Letter
////LinQ extention syntax
//var query1 = names.Where(x => x.ToLower().StartsWith("v"));

////Which names end with a Letter
////LinQ query comprehension syntax
//var query2 = from name in names where name.ToLower().EndsWith("a") select name; 

//string[] result1 = query1.ToArray();

//List<string> result2 = query2.ToList();

//foreach (string s in result1)
//{
//    WriteLine(s);
//    //names[0] = "Vladimir";
//}
//foreach (string s in result2)
//{
//    WriteLine(s);
//    //names[0] = "Vlad";
//}
#endregion

#region Filtering with Where (comment <ImplicitUsings>enable</ImplicitUsings> and import LinQ)

//WriteLine("Writing queries");

////this uses a Deligation in query
////var query = names.Where(new System.Func<string, bool> (NameLongerThanFour));//use Deligation Func() which calls NameLongerThanFour()

////this NOT uses a Deligation in query
////var query = names.Where(NameLongerThanFour);//use Deligation Func() which calls NameLongerThanFour()

////this uses Lambda expression
////var is IOrderedEnumerable
//var query = names
//    .Where(x => x.Length > 4)
//    .OrderBy(name => name.Length)
//    .ThenBy(name => name.Substring(1, 1));//by second char

//static bool NameLongerThanFour(string name)
//{
//    return name.Length > 4;
//}

//foreach (string s in query)
//{
//    WriteLine(s);
//}

#endregion

#region Filter by object type

//List<Exception> exceptions = new()
//{
//    new ArgumentException(),
//    new ArgumentNullException(),
//    new ArgumentOutOfRangeException(),
//    new ArithmeticException(),
//    new InvalidCastException(),
//    new DivideByZeroException(),
//    new ApplicationException()
//};

//IEnumerable<ArithmeticException> exceptinQry = exceptions.OfType<ArithmeticException>();
//foreach (Exception ex in exceptinQry)
//{ 
//    Console.WriteLine(ex);
//}

#endregion

#region Sets and Bags (Distincs, Intersect, Zip etc.)

static void Output(IEnumerable<string> cohort, string desc = "")
{
    if (!string.IsNullOrEmpty(desc))
    {
        WriteLine(desc);
    }

    Write(" ");
    WriteLine(string.Join(",", cohort.ToArray()));//write a a CSV string
    WriteLine();
}

string[] cohort1 = new[]
{
    "Vlad", "Tatiana", "Misha", "Sasha", "Jerry", "Alexei"
};

string[] cohort2 = new[]
{
    "Vladimir", "Tatiana", "Mike", "Alex", "Jerry", "Alexei"
};

string[] cohort3 = new[]
{
    "Vlad", "Tats", "Misha", "Sasha", "Jerry", "Alex"
};

Output(cohort1, "cohort1");
Output(cohort2, "cohort2");
Output(cohort3, "cohort3");

Output(cohort1.Distinct(), "cohort1.Distinct()");
Output(cohort1.DistinctBy(name => name.Substring(1,1)), "cohort1.DistinctBy(name => name.Substring(1,1))");
Output(cohort2.Union(cohort3), "cohort2.Union(cohort3)");
Output(cohort2.Except(cohort3), "cohort2.Except(cohort3)");
Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} item from arr1 matches with {c2} from arr2"), "cohort1.Zip(cohort2)");//matching items from two arrayes
//Zip(First, Second, Result)


#endregion