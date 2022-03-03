using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PacktLib
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        //this Stop() method is not implements in DvdPlayer.cs and is using the Default Implementation
        void Stop()
        {
            WriteLine("Dvd on Stop");
        }
    }
}
