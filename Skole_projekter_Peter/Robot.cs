using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{
    internal class Robot 
    {
        private string _name;
        private int _lifeTokens;
        private int _damageCount = 9;
        private int _cardSlotsMax = 5;
        private List<Card> _cardSlots = new List<Card>();
        private int lookDirection = 0; // 0 is -> 1 is down, 2 <-, 3 is up
        private int posY = 0;
        private int posX = 0;
        private List<Card> _hand = new List<Card> ();

        public int PosY { get => posY; set => posY = value; }
        public int PosX { get => posX; set => posX = value; }
        public int LookDirection { get => lookDirection; set => lookDirection = value; }


        public Robot ()
        {
            
        }

        public void executeAction (Robot robot)
        {


            if (_cardSlots[0] != null) 
            {
                _cardSlots[0].usePower(robot);
                _cardSlots.RemoveAt(0);
            }

            else
            {
                Console.WriteLine("no more cards");
            }


        }

        public void drawNewHand ()
        {
           
            var rand = new Random();

            Card newCard = new Card();
            for (int i = 0; i < _damageCount; i++)
            {
              

                switch (rand.Next(0, 2))
                {
                    default:
                        newCard = new Move();
                            break;

                    case 1:
                        newCard = new Rotate();
                        break;

                }
                _hand.Add(newCard);
            }
        }

        private void takeDamage (int damage)
        {
            _damageCount--;

            if (_damageCount < 5)
            {
                _cardSlotsMax--;
            }


            if (_damageCount <= 0) 
            { 
                _lifeTokens--;

                if (_lifeTokens <= 0)
                {
                    Console.WriteLine("you loose");
                    Thread.Sleep(1000000);
                }
            }
        }


        private void powerDown () 
        {
            Console.WriteLine("not implemented");
        }


        public void addCardToCardSlot ()
        {
            Console.WriteLine("Add cards to your programming slots");

            for (int i = 0; i < _cardSlotsMax; i++)
            {
                Console.WriteLine("Cards left to put in deck slot: " + (_cardSlotsMax - i) + "\n" );


                // display all available cards in hand
                for (int cardNr = 0; cardNr < _hand.Count; cardNr++)
                {
                Console.WriteLine("Nr " + cardNr + ": " + _hand[cardNr].Name); 

                }
                

                // wait for a correct number to be selected
                int input = -1;
                do 
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    // check if input is number
                    if (char.IsDigit(keyInfo.KeyChar))
                    {
                        int number = int.Parse(keyInfo.KeyChar.ToString());

                        // check if number is valid (ie in hand index)
                        if (number < _hand.Count)
                            
                        {
                            input = number;
                        }

                    }

                }
                while (input == -1);


                _cardSlots.Add(_hand[input]);
                Console.WriteLine("You have added: " + _hand[input].Name + "\n");

                // remove from hand
                _hand.RemoveAt(input);
                
                
                Console.Clear();
                
              
            }

            Console.WriteLine("Your commands are: ");

            foreach (Card card in _cardSlots)
            {
               
                Console.WriteLine(card.Name);
            }
        }

    }
}
