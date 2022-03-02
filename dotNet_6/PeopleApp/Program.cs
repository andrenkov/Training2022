using PackitLibModern;
using PacktLibrary.Shared;
using static System.Console;

#region Class properties and method params
//Person.Nationality = "Russian";

//Person bob = new()
//{
//    Name = "Bob Smith",
//    DateOfBirth = new(1964, 11, 17),
//    myHobbies = MyHobbies.succulents | MyHobbies.garden | MyHobbies.fishes,
//    Age = 57
//};
//bob.Children.Add(new() { Name = "Misha" });
//bob.Children.Add(new() { Name = "Sasha"});


//WriteLine(format : "{0} was born on {1 : dddd, d MMMM yyyy}. Hobby - {2}; Nationality : {3} {4} {5}", 
//          bob.Name, bob.DateOfBirth, bob.myHobbies, Person.Nationality, Person.Country, bob.CountryCode);

//WriteLine(format: "{0} was born on {1 : dddd, d MMMM yyyy}. Hobby - {2}; Nationality : {3} {4}",
//          bob.Name, bob.DateOfBirth, bob.myHobbies, Person.Nationality, bob.FullCountryName());


//WriteLine("Children:");
//foreach (Person p in bob.Children)
//{
//    WriteLine(p.Name);
//}

//if (bob != null)
//{
//    //(string?, int) person = bob.GetPerson();
//    var person = bob.GetPerson();
//    WriteLine($"{person.name} {person.age} is here");
//    WriteLine("Deconstructed:");
//    (string? NamePlus, int AgePlus) = bob.GetPerson();
//    WriteLine($"{NamePlus} {AgePlus} is here");

//    //Deconstructing types
//    var (name1, age1) = bob;
//    WriteLine($"Deconstructed {name1} {age1} is here");
//}

//int x = 10;
//int y = 20;
//WriteLine($"x = {x} y = {y} f is missing param");

//WriteLine($"Bob's Lambda age = {bob.AgeLambda}; Get age = {bob.AgeGet}");
#endregion

//object[] passengers = {
//    new FirstClassPassenger { AirMiles = 1_419},
//    new FirstClassPassenger { AirMiles = 16_562},
//    new BusinessClassPassenger(),
//    new CoachClassPassenger { CarryOnKg = 25.7},
//    new CoachClassPassenger { CarryOnKg = 0}
//};

/// <summary>
/// C# 8 pattern
/// </summary>
//foreach (object passenger in passengers)
//{
//    decimal flightCost = passenger switch
//    {
//        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
//        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
//        FirstClassPassenger _                         => 2000M,
//        BusinessClassPassenger _                      => 1000M,
//        CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
//        CoachClassPassenger _                         => 800M,
//        _ => throw new NotImplementedException()
//    };
//    WriteLine($"Flist costs {flightCost:C} for {passenger}");
//}

/// <summary>
/// C# 9 or later pattern
/// discard _
/// </summary>
//foreach (object passenger in passengers)
//{
//    decimal flightCost = passenger switch
//    {
//        FirstClassPassenger p => p.AirMiles switch
//        {
//            > 35000 => 1500M,
//            > 15000 => 1750M,
//            _ => 2000M,
//        },

//        BusinessClassPassenger _ => 1000M,

//        CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
//        CoachClassPassenger _ => 800M,
//        _ => throw new NotImplementedException()
//    };
//    WriteLine($"Flist costs {flightCost:C} for {passenger}");
//} 

//ImmutableVehicle car = new()
//{
//    Brand = "Mazda Mx5",
//    Color = "Red",
//    Wheels = 4
//};

////"with" is to create from existing record 
//ImmutableVehicle repainedCar = car with { Color = "Polymethal Grey" };

//WriteLine($"Original car color was {car.Color}" );
//WriteLine($"New car color is {repainedCar.Color}" );


ImmutableAnimals oscar = new ImmutableAnimals("Oscar", "Labrador sp.");
var (who, what) = oscar;//calls decunstruct
WriteLine($"{who} is a {what}");