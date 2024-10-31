using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_projekter_Peter
{

    class Card
    {
        protected string name = "no name assigned";

        public Card ()
        {
           var rand = new Random();

        }

        public string Name { get => name; }

        public virtual void usePower (Robot robot)
        {


        }


    }
}
