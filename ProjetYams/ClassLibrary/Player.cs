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
        Dictionary<string, int> combiniason = new Dictionary<string, int>();

        public Player(string pseudo)
        {
            this.pseudo = pseudo;
            Combiniason.Add("Un", -1);
            Combiniason.Add("Deux", -1);
            Combiniason.Add("Trois", -1);
            Combiniason.Add("Quatre", -1);
            Combiniason.Add("Cinq", -1);
            Combiniason.Add("Six", -1);
            Combiniason.Add("Somme", -1);
            Combiniason.Add("Bonus", -1);
            Combiniason.Add("Brelan", -1);
            Combiniason.Add("Carré", -1);
            Combiniason.Add("Full", -1);
            Combiniason.Add("Petite suite", -1);
            Combiniason.Add("Grand suite", -1);
            Combiniason.Add("Chance", -1);
            Combiniason.Add("Yams", -1);
            Combiniason.Add("Total", -1);
        }

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        public Dictionary<string, int> Combiniason 
        { 
            get => combiniason; 
            set => combiniason = value; 
        }
    }
}
