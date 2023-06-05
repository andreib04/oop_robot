using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_oop
{
    public class Planets
    {
        public string Name { get; }
        public int AnimalCount { get; set; }
        public int HumanCount { get; set; }
        public int SuperheroCount { get; set; }

        private Planets(string name, int animalCount, int humanCount, int superheroCount)
        {
            Name = name;
            AnimalCount = animalCount;
            HumanCount = humanCount;
            SuperheroCount = superheroCount;
        }

        public static Planets Earth = new Planets("Earth", 15, 10, 3);
    }
}
