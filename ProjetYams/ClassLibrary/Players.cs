using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Players
    {
        private bool tour = true;

        public string? PseudoPlayer1 { get; set; }

        public string? PseudoPlayer2 { get; set; }

        public bool Tour
        {
            get { return tour; }
            set { tour = value; }
        }
    }
}
