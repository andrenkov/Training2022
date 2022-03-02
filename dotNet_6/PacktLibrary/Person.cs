using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PacktLibrary.Shared;

public class Person : Object
{
    public string? Name { get; set; }    
    public DateTime DateOfBirth { get; set; }
    internal protected int Gender { get; set; }//private protected
    public MyHobbies myHobbies;
    public List<Person> Children = new();
    public static string? Nationality;
    public const string Country = "Russia";
    public readonly string? CountryCode;
    public int Age;

    public Person()
    {
        CountryCode = "RU";
    }

    public string FullCountryName()
    {
        return $"{Country} {CountryCode}";
    }

    //tuple
    public (string? name, int age) GetPerson()
    {
        return (name : Name, age :  Age);
    }

    //Deconstructing types
    public void Deconstruct(out string? name, out int age)
    {
        name = Name;
        age = Age;
    }
}
