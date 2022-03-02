using static System.Console;
using PacktLib;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

//call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

//vcall statis method
Person baby2 = Person.Procreate(harry, jill);

WriteLine($"{harry.Name} has {harry.Children.Count} children");
WriteLine($"{mary.Name} has {mary.Children.Count} children");
WriteLine($"{jill.Name} has {jill.Children.Count} children");

WriteLine(format:"{0}'s first child is named \"{1}\" ", arg0:harry.Name, arg1: harry.Children[0].Name);

