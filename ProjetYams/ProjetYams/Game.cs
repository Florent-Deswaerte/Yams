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

        public Game()
        {
            AffichageTour();
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AffichageTour()
        {
            Players playersObject = new Players();
            if (playersObject.Tour)
            {
                playersObject.Tour = false;
            }
            else
            {
                playersObject.Tour = true;
            }
        }
    }
}
