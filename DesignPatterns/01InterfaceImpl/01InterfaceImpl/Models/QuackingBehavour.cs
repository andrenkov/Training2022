using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InterfaceImpl.Models
{
    public interface IQuackingBehavour
    {
        public void DoQuack();
    }

    public class QuackingDuck : IQuackingBehavour
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack, Quack, Quack");
        }
    }

    public class SqueakinggDuck : IQuackingBehavour
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak, Squeak, Squeak");
        }
    }

    public class MuteDuck : IQuackingBehavour
    {
        public void DoQuack()
        {
            Console.WriteLine("I am mute!");
        }
    }

}
