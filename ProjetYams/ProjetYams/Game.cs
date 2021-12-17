using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

namespace ProjetYams
{
    public partial class Game : Form
    {
        Player joueur1;
        Player joueur2;
        Main main;

        bool tour = true;

        public Game(Player joueur1, Player joueur2, Main main)
        {
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
            this.main = main;

            InitializeComponent();
            AffichageTour();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture2();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage2(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture2();
            SendMessage2(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btnMinimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AffichageTour()
        {
            if (tour)
            {
                labelPseudoGame.Text = "";
                labelPseudoGame.Text = joueur1.Pseudo;
                tour = false;
            }
            else
            {
                labelPseudoGame.Text = "";
                labelPseudoGame.Text = joueur2.Pseudo;
                tour = true;
            }
        }
    }
}
