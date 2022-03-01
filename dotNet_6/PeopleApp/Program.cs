using PacktLibrary.Shared;
using static System.Console;

Person bob = new()
{
    Name = "Bob Smith",
    DateOfBirth = new(1964, 11, 17)
};

WriteLine(format : "{0} was born on {1 : dddd, d MMMM yyyy}", arg0: bob.Name, arg1 : bob.DateOfBirth);
