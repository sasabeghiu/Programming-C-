using System;
using System.Collections.Generic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            // create a tank (and assign a driver)
            IAttacker tank = new Tank();
            tank.AssignDriver("Frank");

            // create a robot
            Robot robot = new Robot();
            robot.MoveByPerson("Mark");
            IAttacker adapter = new RobotAdapter(robot);
            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(adapter);

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
        }
    }
}
