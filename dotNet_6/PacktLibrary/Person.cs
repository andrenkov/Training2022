using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Console;

namespace PacktLibrary.Shared;

public class Person : Object
{
    //Internal types or members are accessible only within files in the same assembly
    //Private members are accessible only within the body of the class or the struct 
    //A protected member is accessible within its class and by derived class instances.
    //A protected internal member of a base class is accessible from any type within its containing assembly
    //A private protected member is accessible by types derived from the containing class, but only within its containing assembly.
    //Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own

    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    internal protected int Gender { get; set; }//private protected
    public MyHobbies myHobbies;
    public List<Person> Children = new();
    public static string? Nationality;
    public const string Country = "Russia";
    public readonly string? CountryCode;
    public int Age;
    //use lambda expression
    public int AgeLambda => DateTime.Today.Year - DateOfBirth.Year;
    //getter property
    public int AgeGet { get { return DateTime.Today.Year - DateOfBirth.Year; } }
    
    [Required]
    public /*required*/ int AgeReq { get; set; }



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
