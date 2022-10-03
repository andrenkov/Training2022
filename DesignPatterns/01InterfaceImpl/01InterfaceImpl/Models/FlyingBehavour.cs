using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InterfaceImpl.Models
{
    public interface IFlyingBehavour
    { 
        public void DoFly();
    }

    public class FlyingDuck : IFlyingBehavour
    {
        public void DoFly()
        {
            Console.WriteLine("I am flying with wings!");
        }
    }

    public class NoFlyingDuck : IFlyingBehavour
    {
        public void DoFly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }

}
