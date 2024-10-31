namespace Skole_projekter_Peter
{

    class RobotRally
    {

        static void Main()
        {


            Robot robot = new Robot();

            void executeTurn (Robot robot) 
            {
                
                // draw 9 cards
                robot.drawNewHand();
                robot.addCardToCardSlot();
                Console.Clear();

                // Game loop

                for (int i = 0; i < 5; i++)
                {
                    robot.executeAction(robot);
                
                }


            }

            executeTurn(robot);

        }
    }
}