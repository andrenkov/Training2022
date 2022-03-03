using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLib
{
    public struct MyStructClass
    {
        public int x;
        public int y;

        public MyStructClass(int initX, int initY)
            { x = initX; y = initY; }
        public static MyStructClass operator +(MyStructClass num1, MyStructClass num2)
        {
            return new(
                num1.x + num2.x,
                num1.y + num2.y
                );
        }
    }
}
