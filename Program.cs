using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace robot_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robot = new GiantKillerRobot();
            robot.Initialize();

            robot.EyeLaserIntensity = Intensity.Kill;
            robot.TargetPlanet = Planets.Earth;

            if (robot.Active)
                robot.FireLaserAt();
            else
                robot.AcquireNextTarget();
        }
    }

}
