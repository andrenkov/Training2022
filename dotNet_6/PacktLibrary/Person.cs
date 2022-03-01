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
}
