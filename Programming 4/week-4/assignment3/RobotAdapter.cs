using System;

namespace assignment3
{
    public class RobotAdapter : IAttacker
    {
        private Robot robot;
        public string Driver { get { return robot.Person; } }
        
        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string driver)
        {
            robot.MoveByPerson(driver);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
