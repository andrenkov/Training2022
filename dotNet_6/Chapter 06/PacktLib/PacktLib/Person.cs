using static System.Console;

/// <copyright>
/// Copyright (s) 2022 Russol
/// </copyright>

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

    #region new interface to compare objects
    public class PersonCompare : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x is null || y is null)
            {
                return 0;
            }
            //compare names lengths
            int result = x.Name.Length.CompareTo(y.Name.Length);
            //if they are equal
            if (result == 0)
            {
                //compare by the Names
                return x.Name.CompareTo(y.Name);//use ICopareTo of a String
            }
            else//otherwise, compare by lenght
            { 
                return result;
            }
        }
    }
    #endregion

    #region methods overwriting
    public class Employee : Person
    {
        DateTime? HiredDate;
        /// <summary>
        /// "new" allows overwrite the WriteToConsole() of the base class
        /// </summary>
        //public new void WriteToConsole()
        //{
        //    WriteLine($"{Name} was born on a {DateOfBirth:ddd} hired on {HiredDate}");
        //}
        /// <summary>
        /// "override" another way to overwrite the WriteToConsole() of the base class
        /// Error: cannot override inherited member 'Person.WriteToConsole()' because it is not marked virtual, abstract, or override

        /// </summary>
        //public override void WriteToConsole()
        //{
        //    WriteLine($"{Name} was born on a {DateOfBirth:ddd} hired on {HiredDate}");
        //}
    }
    #endregion

    #region Abstract and Sealed classes
    /// <summary>
    /// Old way of what now is Interface
    /// </summary>
    /// 
    public abstract class PersonAbst
    {
        /// <summary>
        /// must be implemented in the derived type
        /// </summary>
        public abstract void Gammy();
    }

    public class PersonFull : PersonAbst
    {
        public override void Gammy()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Cannot be overwriding in the child class
    /// </summary>
    public  sealed class PersonSealed : PersonAbst
    {
        public override void Gammy()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Exheriting and extending .Net type
    public class PersonException : Exception
    {
        /// <summary>
        /// Unlike other methods, constructors aren't enhereted. Must be declared and call base constructor(s).
        /// </summary>
        //default constructor called base class create
        public PersonException() : base() { }

        //another constructor called base class create
        public PersonException(string msg) : base(msg) { }
        //another constructor called base class create
        public PersonException(string msg, Exception innerEx) : base(msg, innerEx) { }

    }
    #endregion
}