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
        Dictionary<string, int> combinaison = new Dictionary<string, int>();

        public Player(string pseudo)
        {
            this.pseudo = pseudo;
            Combinaison.Add("Un", -1);
            Combinaison.Add("Deux", -1);
            Combinaison.Add("Trois", -1);
            Combinaison.Add("Quatre", -1);
            Combinaison.Add("Cinq", -1);
            Combinaison.Add("Six", -1);
            Combinaison.Add("Somme", -1);
            Combinaison.Add("Bonus", -1);
            Combinaison.Add("Brelan", -1);
            Combinaison.Add("Carré", -1);
            Combinaison.Add("Full", -1);
            Combinaison.Add("Petite suite", -1);
            Combinaison.Add("Grand suite", -1);
            Combinaison.Add("Chance", -1);
            Combinaison.Add("Yams", -1);
            Combinaison.Add("Total", -1);
        }

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        public Dictionary<string, int> Combinaison 
        { 
            get => combinaison; 
            set => combinaison = value; 
        }
    }
}
