using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InterfaceImpl.Models
{
    internal class WoodenDuck : CustomDuck
    {
        public WoodenDuck(string name) : base(name)
        {
            quackingBehavour = new QuackingDuck();
            flyingBehavour = new NoFlyingDuck();
        }

        public override void MoveDuck()
        {
            Console.WriteLine($"{Name} is rolling slowly on wheels");
        }
    }
}
