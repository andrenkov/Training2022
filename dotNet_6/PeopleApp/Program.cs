using PacktLibrary.Shared;
using static System.Console;

Person.Nationality = "Russian";

Person bob = new()
{
    Name = "Bob Smith",
    DateOfBirth = new(1964, 11, 17),
    myHobbies = MyHobbies.succulents | MyHobbies.garden | MyHobbies.fishes,
    Age = 57
};
bob.Children.Add(new() { Name = "Misha" });
bob.Children.Add(new() { Name = "Sasha"});


//WriteLine(format : "{0} was born on {1 : dddd, d MMMM yyyy}. Hobby - {2}; Nationality : {3} {4} {5}", 
//          bob.Name, bob.DateOfBirth, bob.myHobbies, Person.Nationality, Person.Country, bob.CountryCode);

WriteLine(format: "{0} was born on {1 : dddd, d MMMM yyyy}. Hobby - {2}; Nationality : {3} {4}",
          bob.Name, bob.DateOfBirth, bob.myHobbies, Person.Nationality, bob.FullCountryName());


WriteLine("Children:");
foreach (Person p in bob.Children)
{
    WriteLine(p.Name);
}

if (bob != null)
{
    //(string?, int) person = bob.GetPerson();
    var person = bob.GetPerson();
    WriteLine($"{person.name} {person.age} is here");
    WriteLine("Deconstructed:");
    (string? NamePlus, int AgePlus) = bob.GetPerson();
    WriteLine($"{NamePlus} {AgePlus} is here");

    //Deconstructing types
    var (name1, age1) = bob;
    WriteLine($"Deconstructed {name1} {age1} is here");
}
