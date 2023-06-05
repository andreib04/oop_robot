using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_oop
{
    public class Intensity
    {
        public int Damage { get; private set; }

        private Intensity(int damage)
        {
            Damage = damage;
        }

        public static Intensity legShot { get; } = new Intensity(25);
        public static Intensity bodyShot { get; } = new Intensity(50);
        public static Intensity Kill { get; } = new Intensity(100);
    }
}
