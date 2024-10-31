using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skole_projekter_Peter
{
    internal class Rotate : Card
    {

        // TODO implement enums så de kan kaldes universielt


        private int currentTurnDir;
        private int newTurnDir = 0; // -1 left, 0 u-turn, 1 right

        public Rotate()
        {
            var rand = new Random();
            
            newTurnDir = rand.Next(-1, 1);
            name = "rotate " + newTurnDir;
        }

        public override void usePower(Robot robot)
        {
            currentTurnDir = robot.LookDirection;

            switch (robot.LookDirection)
            {
                default:
                    Console.WriteLine("Take a u-turn");
                    robot.LookDirection = (currentTurnDir + 2) % 4;
                    break;

                case 1:
                    Console.WriteLine("Take a right");
                    robot.LookDirection = (currentTurnDir + 1) % 4;
                    break;

                case 2:
                    Console.WriteLine("Take a left");
                    if ((currentTurnDir - 1) % 4 < 0)
                    {
                        robot.LookDirection = 3;
                    }
                    else
                    {
                        robot.LookDirection = (currentTurnDir - 1) % 4;
                    }

                    break;

            }
        }

    }
}
