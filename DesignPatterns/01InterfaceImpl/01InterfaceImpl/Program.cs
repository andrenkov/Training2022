using _01InterfaceImpl.Models;

WildDuck MyWildDuck = new("Wild duck");
MyWildDuck.DisplayDuck();
MyWildDuck.performQuack();
MyWildDuck.performFly();
MyWildDuck.MoveDuck();

Console.WriteLine("#######################");

WoodenDuck MyWoodenDuck = new("Made from wood");
MyWoodenDuck.DisplayDuck();
MyWoodenDuck.performQuack();
MyWoodenDuck.performFly();
MyWoodenDuck.MoveDuck();

