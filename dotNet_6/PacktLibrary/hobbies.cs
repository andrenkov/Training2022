using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    internal class Hobbies
    {
    }

    [System.Flags]
    public enum MyHobbies : byte
    {
        none = 0b_0000_0000,
        cacti = 0b_0000_0001,//1
        succulents =0b_0000_0010,//2
        garden = 0b_0000_0100,//4
        fishes = 0b_0000_1000//8
    }
}
