using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackitLibModern
{
    /// <summary>
    /// Example of using a Record
    /// </summary>
    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        public string? Color { get; init; }
        public string? Brand { get; init; }
    }

    /// <summary>
    /// Example of using a Record with Init-only
    /// </summary>
    public record ImmutablePersone
    {
        public int Wheels { get; init; }
        public string? Color { get; init; }
        public string? Brand { get; init; }
    }

    /// <summary>
    /// Example of using a Record with constructor and positioning parameters
    /// </summary>
    //public record ImmutableAnimals
    //{
    //    public string Name { get; init; }
    //    public string Species { get; init; }

    //    public ImmutableAnimals(string name, string species)
    //    { 
    //        Name = name;
    //        Species = species;
    //    }

    //    public void Deconstruct(out string name, out string species)
    //    {
    //        name = Name;
    //        species = Species;
    //    }

    //}

    /// <summary>
    /// Example of simplefied Record declaration with constructor and positioning auto-generated
    /// </summary>
   public record ImmutableAnimals (string Name, string Specie);
}
