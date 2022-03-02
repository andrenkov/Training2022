using static System.Console;

namespace PacktLib
{
    public class Person : Object
    {
        //fields
        public string? Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new();
        //methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:ddd}.");
        }

        //Add statis method
        public static Person Procreate(Person p1, Person p2)
        {
            Person baby = new() { 
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        //Add instance method
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }


    }
}