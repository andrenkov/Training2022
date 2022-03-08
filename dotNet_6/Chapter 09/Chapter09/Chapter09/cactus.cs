using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFileSystems
{
    public class cactus
    {
        public string SpeciesName { get; set; } 
        public int CatNum { get; set; }
        public cactus(string speciesName, int catNum)
        { 
            SpeciesName = speciesName;
            CatNum = catNum;
        }
    }
}
