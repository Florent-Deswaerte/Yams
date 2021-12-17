using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player
    {
        private string pseudo;

        public Player(string pseudo)
        {
            this.pseudo = pseudo;
        }

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
    }
}
