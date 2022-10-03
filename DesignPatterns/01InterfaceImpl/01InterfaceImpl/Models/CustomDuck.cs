using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InterfaceImpl.Models
{
    abstract class CustomDuck
    {
        public string Name { get; }

        public IQuackingBehavour quackingBehavour { get; set; }
        public IFlyingBehavour flyingBehavour { get; set; }

        public CustomDuck(string name)
        {
            Name = name;
        }

        //can be overridden  in a child class
        public virtual void DisplayDuck()
        {
            Console.WriteLine($"I am {Name}");
        }
        //must be implemented in a child class
        public abstract void MoveDuck();

        public void performFly()
        {
            flyingBehavour.DoFly();
        }

        public void performQuack()
        {
            quackingBehavour.DoQuack();
        }


    }
}
