using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Des
    {
        bool selection = false;
        int faceDes = 1;
        List<int> faces = new List<int>() { 1, 2, 3, 4, 5, 6 };

        public int RandomFaces()
        {
            int face;
            Random rand = new Random();
            int random = rand.Next(0, 6);
            face = faces[random];
            faceDes = faces[random];
            return face;
        }

        public List<int> Faces 
        { 
            get => faces; 
            set => faces = value;
        }

        public bool Selection 
        { 
            get => selection; 
            set => selection = value; 
        }

        public int FaceDes 
        { 
            get => faceDes; 
            set => faceDes = value; 
        }
    }
}
