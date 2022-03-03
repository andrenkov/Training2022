using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PacktLib
{
    /// <summary>
    /// This class is to implement the inteface from IPlayable.cs
    /// Implicit implementation are most common. 
    /// Explicit emplementations are used if a type must have miltiple methods with teh same name of signature
    /// </summary>
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("Dvd on Pause");
        }

        public void Play()
        {
            WriteLine("Dvd player is playing");
        }
    }
}
