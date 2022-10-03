using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InterfaceImpl.Models
{
    internal class WildDuck : CustomDuck
    {
        public WildDuck(string name) : base(name)
        {
            quackingBehavour = new QuackingDuck();
            flyingBehavour = new FlyingDuck();
        }

        public override void MoveDuck()
        {
            Console.WriteLine($"{Name} is moving fact");
        }
    }
}
