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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (textBoxJoueur1.Text.Length == 0 || textBoxJoueur2.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Veuillez entrez un pseudo valide ...", "Valeur erronée", MessageBoxButtons.OK);
                switch (result)
                {
                    case DialogResult.OK:
                        break;
                }
                textBoxJoueur1.Clear();
                textBoxJoueur2.Clear();
            }
            else
            {
                Player joueur1 = new Player(textBoxJoueur1.Text);
                Player joueur2 = new Player(textBoxJoueur2.Text);

                this.Hide();
                Game game = new Game(joueur1, joueur2, this);
                game.Closed += (s, args) => this.Close();
                game.Show();
                textBoxJoueur1.Text = "";
                textBoxJoueur2.Text = "";
            }
        }

        private void buttonPlay1v1_Click(object sender, EventArgs e)
        {
            if (textBox21v1.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Veuillez entrez un pseudo valide ...", "Valeur erronée", MessageBoxButtons.OK);
                switch (result)
                {
                    case DialogResult.OK:
                        break;
                }
                textBox21v1.Clear();
            }
            else
            {
                Player joueur1 = new Player(textBox21v1.Text);

                this.Hide();
                Solo solo = new Solo(joueur1, this);
                solo.Closed += (s, args) => this.Close();
                solo.Show();
                textBox21v1.Text = "";
            }
        }
    }
}