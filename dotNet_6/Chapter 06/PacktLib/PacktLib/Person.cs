using static System.Console;

namespace PacktLib
{
    /// <summary>
    /// Methods and Inner methods
    /// </summary>
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

        //Declare new Operator
        public static Person operator *(Person p1, Person p2)
        { 
            return Person.Procreate(p1, p2);
        }

        //declare and use Inner or Local func
        public static int Factorial(int number)
        {
            if (number < 0)
            { 
                throw new ArgumentException($"nameof{number} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }

        }

        //delegate methods - test
        public static int MethodWantToCall(string input)
        {
            return input.Length;
        }

        #region events
        //delegate field
        public event EventHandler? Shout;//"Event" is optional to alow more than one method being assighned to the deligate
        //data field
        public int AngerLevel;
        //method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //if smth is listening
                Shout?.Invoke(this, EventArgs.Empty);
                //above equals  to below
                //if (Shout != null)
                //{
                //    Shout(this, EventArgs.Empty);
                //}
            }
        }

        #endregion

    }
}