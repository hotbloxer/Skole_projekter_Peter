using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    
    class Move : Card 
    {
        private int moveLength;
        public Move ()
        {
           
            var rand = new Random();
            moveLength = rand.Next(1,4);

            name = "Move " + moveLength;
        }

        public override void usePower(Robot robot)
        {
            int x = robot.PosX;
            int y = robot.PosY;

            switch (robot.LookDirection)
            {
                default:
                    //Console.WriteLine("right");
                    robot.PosX = x + moveLength;
                    break;

                case 1:
                    //Console.WriteLine("down");
                    robot.PosY = y - moveLength;
                    break;

                case 2:
                    //Console.WriteLine("left");
                    robot.PosX = x - moveLength;
                    break;

                case 3:
                    //Console.WriteLine("up");
                    robot.PosY = y + moveLength;
                    break;

            }

            Console.WriteLine("Go " + moveLength + " ahead");

        }

    }
}
