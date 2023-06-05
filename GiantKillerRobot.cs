using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace robot_oop
{
    public class GiantKillerRobot
    {
        public Intensity EyeLaserIntensity { get; set; }
        public Target CurrentTarget { get; set; }
        public bool Active { get; set; }
        public Planets TargetPlanet { get; set; }

        public GiantKillerRobot()
        {
            Active = false;
        }

        public void Initialize()
        {
            Active = true;
            Console.WriteLine("The robot is initializing... \n");
        }

        public void FireLaserAt()
        {
            while(Planets.Earth.AnimalCount + Planets.Earth.HumanCount + Planets.Earth.SuperheroCount > 0)
            {
                if (Planets.Earth.AnimalCount > 0)
                {
                    Target animalTarget = new Target(100); // health
                    Console.WriteLine($"The robot eliminated an animal from planet {Planets.Earth.Name}.");
                    Planets.Earth.AnimalCount--;
                }

                if (Planets.Earth.HumanCount > 0)
                {
                    Target humanTarget = new Target(200); 
                    Console.WriteLine($"The robot eliminated a human from planet {Planets.Earth.Name}.");
                    Planets.Earth.HumanCount--;
                }

                if (Planets.Earth.SuperheroCount > 0)
                {
                    Target superheroTarget = new Target(500); 
                    Console.WriteLine($"The robot eliminated a superhero from planet {Planets.Earth.Name}.");
                    Planets.Earth.SuperheroCount--;
                }
            }

            Console.WriteLine($"\nThere are no targets left on planet {Planets.Earth.Name}.");
        }
        
        public void AcquireNextTarget()
        {
            Console.WriteLine("The robot is looking for his next targets!");
        }
    }
}
