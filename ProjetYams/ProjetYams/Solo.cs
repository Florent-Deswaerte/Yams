﻿using System;
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
    public partial class Solo : Form
    {
        Player joueur1;

        Main main;

        Des des1 = new Des();
        Des des2 = new Des();
        Des des3 = new Des();
        Des des4 = new Des();
        Des des5 = new Des();

        List<int> ListeFaceSelection = new List<int>();

        int desSelection = 0;
        int nombreLance = 0;

        int coup = 0;

        public Solo(Player joueur1, Main main)
        {
            InitializeComponent();

            this.joueur1 = joueur1;
            this.main = main;

            panelDes1.Visible = false;
            panelDes2.Visible = false;
            panelDes3.Visible = false;
            panelDes4.Visible = false;
            panelDes5.Visible = false;

            labelPseudoGame.Text = joueur1.Pseudo;

            labelCombinaison1J1.ForeColor = Color.Red;
            labelCombinaison2J1.ForeColor = Color.Red;
            labelCombinaison3J1.ForeColor = Color.Red;
            labelCombinaison4J1.ForeColor = Color.Red;
            labelCombinaison5J1.ForeColor = Color.Red;
            labelCombinaison6J1.ForeColor = Color.Red;
            labelCombinaisonBrelanJ1.ForeColor = Color.Red;
            labelCombinaisonCarreJ1.ForeColor = Color.Red;
            labelCombinaisonFullJ1.ForeColor = Color.Red;
            labelCombinaisonPetiteSuiteJ1.ForeColor = Color.Red;
            labelCombinaisonChanceJ1.ForeColor = Color.Red;
            labelCombinaisonYamsJ1.ForeColor = Color.Red;

            affichageCombinaison();

            joueur1.Combinaison["Un"] = -1; joueur1.Combinaison["Deux"] = -1; joueur1.Combinaison["Trois"] = -1; joueur1.Combinaison["Quatre"] = -1; joueur1.Combinaison["Cinq"] = -1; joueur1.Combinaison["Six"] = -1; joueur1.Combinaison["Somme"] = -1; joueur1.Combinaison["Bonus"] = -1; joueur1.Combinaison["Brelan"] = -1; joueur1.Combinaison["Carré"] = -1; joueur1.Combinaison["Full"] = -1; joueur1.Combinaison["Petite suite"] = -1; joueur1.Combinaison["Grand suite"] = -1; joueur1.Combinaison["Chance"] = -1; joueur1.Combinaison["Yams"] = -1; joueur1.Combinaison["Total"] = -1;
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
            Application.Exit();
        }

        private void btnMinimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Solo solo = new Solo(joueur1, main);
            solo.Closed += (s, args) => this.Close();
            solo.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void affichageTour()
        {
            buttonLancer.Visible = true;
            buttonLancer.Location = new Point(691, 699);
            panelDes1.Visible = false; panelDes2.Visible = false; panelDes3.Visible = false; panelDes4.Visible = false; panelDes5.Visible = false;
            des1.Selection = false; des2.Selection = false; des3.Selection = false; des4.Selection = false; des5.Selection = false;
            actualisationDes();
        }

        private void affichageCombinaison()
        {
            labelCombinaisonJoueur1.Text = joueur1.Pseudo;
        }

        private void actualisationDes()
        {
            if (des1.Selection) { panelDes1.Location = new Point(177, 683); }
            else { panelDes1.Location = new Point(121, 212); }

            if (des2.Selection) { panelDes2.Location = new Point(264, 683); }
            else { panelDes2.Location = new Point(464, 212); }

            if (des3.Selection) { panelDes3.Location = new Point(351, 683); }
            else { panelDes3.Location = new Point(290, 345); }

            if (des4.Selection) { panelDes4.Location = new Point(438, 683); }
            else { panelDes4.Location = new Point(121, 492); }

            if (des5.Selection) { panelDes5.Location = new Point(525, 683); }
            else { panelDes5.Location = new Point(464, 492); }

            if (des1.Selection && des2.Selection && des3.Selection && des4.Selection && des5.Selection) { buttonLancer.Enabled = false; }
            else { buttonLancer.Enabled = true; }
        }

        private void validationSelection()
        {
            if (labelCombinaison1J1.ForeColor == Color.Red) { labelCombinaison1J1.Text = ""; }
            if (labelCombinaison2J1.ForeColor == Color.Red) { labelCombinaison2J1.Text = ""; }
            if (labelCombinaison3J1.ForeColor == Color.Red) { labelCombinaison3J1.Text = ""; }
            if (labelCombinaison4J1.ForeColor == Color.Red) { labelCombinaison4J1.Text = ""; }
            if (labelCombinaison5J1.ForeColor == Color.Red) { labelCombinaison5J1.Text = ""; }
            if (labelCombinaison6J1.ForeColor == Color.Red) { labelCombinaison6J1.Text = ""; }
            if (labelCombinaisonSommeJ1.ForeColor == Color.Red) { labelCombinaisonSommeJ1.Text = ""; }
            if (labelCombinaisonBonusJ1.ForeColor == Color.Red) { labelCombinaisonBonusJ1.Text = ""; }
            if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = ""; }
            if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = ""; }
            if (labelCombinaisonFullJ1.ForeColor == Color.Red) { labelCombinaisonFullJ1.Text = ""; }
            if (labelCombinaisonPetiteSuiteJ1.ForeColor == Color.Red) { labelCombinaisonPetiteSuiteJ1.Text = ""; }
            if (labelCombinaisonChanceJ1.ForeColor == Color.Red) { labelCombinaisonChanceJ1.Text = ""; }
            if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = ""; }
            if (labelCombinaisonTotalJ1.ForeColor == Color.Red) { labelCombinaisonTotalJ1.Text = ""; }
        }

        private void calculPoint()
        {
            ListeFaceSelection.Clear();
            ListeFaceSelection.Add(des1.FaceDes);
            ListeFaceSelection.Add(des2.FaceDes);
            ListeFaceSelection.Add(des3.FaceDes);
            ListeFaceSelection.Add(des4.FaceDes);
            ListeFaceSelection.Add(des5.FaceDes);

            int un = 0; int unNombre = 0;
            int deux = 0; int deuxNombre = 0;
            int trois = 0; int troisNombre = 0;
            int quatre = 0; int quatreNombre = 0;
            int cinq = 0; int cinqNombre = 0;
            int six = 0; int sixNombre = 0;

            foreach (int face in ListeFaceSelection)
            {
                if (face == 1) { un++; unNombre += 1; }
                else if (face == 2) { deux++; deuxNombre += 2; }
                else if (face == 3) { trois++; troisNombre += 3; }
                else if (face == 4) { quatre++; quatreNombre += 4; }
                else if (face == 5) { cinq++; cinqNombre += 5; }
                else if (face == 6) { six++; sixNombre += 6; }
            }

            //Un
            if (un != 0)
            {
                if (labelCombinaison1J1.ForeColor == Color.Red) { labelCombinaison1J1.Text = unNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison1J1.ForeColor == Color.Red) { labelCombinaison1J1.Text = ""; }
            }
            //Deux
            if (deux != 0)
            {
                if (labelCombinaison2J1.ForeColor == Color.Red) { labelCombinaison2J1.Text = deuxNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison2J1.ForeColor == Color.Red) { labelCombinaison2J1.Text = ""; }
            }
            //Trois
            if (trois != 0)
            {
                if (labelCombinaison3J1.ForeColor == Color.Red) { labelCombinaison3J1.Text = troisNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison3J1.ForeColor == Color.Red) { labelCombinaison3J1.Text = ""; }
            }
            //Quatre
            if (quatre != 0)
            {
                if (labelCombinaison4J1.ForeColor == Color.Red) { labelCombinaison4J1.Text = quatreNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison4J1.ForeColor == Color.Red) { labelCombinaison4J1.Text = ""; }
            }
            //Cinq
            if (cinq != 0)
            {
                if (labelCombinaison5J1.ForeColor == Color.Red) { labelCombinaison5J1.Text = cinqNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison5J1.ForeColor == Color.Red) { labelCombinaison5J1.Text = ""; }
            }
            //Six
            if (six != 0)
            {
                if (labelCombinaison6J1.ForeColor == Color.Red) { labelCombinaison6J1.Text = sixNombre.ToString(); }
            }
            else
            {
                if (labelCombinaison6J1.ForeColor == Color.Red) { labelCombinaison6J1.Text = ""; }
            }
            //Brelan
            if (un >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "3"; }
            }
            else if (deux >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "6"; }
            }
            else if (trois >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "9"; }
            }
            else if (quatre >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "12"; }
            }
            else if (cinq >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "15"; }
            }
            else if (six >= 3)
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = "18"; }
            }
            else
            {
                if (labelCombinaisonBrelanJ1.ForeColor == Color.Red) { labelCombinaisonBrelanJ1.Text = ""; }
            }
            //Carre
            if (un >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "4"; }
            }
            else if (deux >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "8"; }
            }
            else if (trois >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "12"; }
            }
            else if (quatre >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "16"; }
            }
            else if (cinq >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "20"; }
            }
            else if (six >= 4)
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = "24"; }
            }
            else
            {
                if (labelCombinaisonCarreJ1.ForeColor == Color.Red) { labelCombinaisonCarreJ1.Text = ""; }
            }

            //Full
            if (un == 3 || deux == 3 || trois == 3 || quatre == 3 || cinq == 3 || six == 3)
            {
                if (un == 2 || deux == 2 || trois == 2 || quatre == 2 || cinq == 2 || six == 2)
                {
                    if (labelCombinaisonFullJ1.ForeColor == Color.Red) { labelCombinaisonFullJ1.Text = "25"; }
                }
            }
            else
            {
                if (labelCombinaisonFullJ1.ForeColor == Color.Red) { labelCombinaisonFullJ1.Text = ""; }
            }

            //Petite Suite
            if (un >= 1 && deux >= 1 && trois >= 1 && quatre >= 1 || deux >= 1 && trois >= 1 && quatre >= 1 && cinq >= 1 || trois >= 1 && quatre >= 1 && cinq >= 1 && six >= 1)
            {
                if (labelCombinaisonPetiteSuiteJ1.ForeColor == Color.Red) { labelCombinaisonPetiteSuiteJ1.Text = "30"; }
            }
            else
            {
                if (labelCombinaisonPetiteSuiteJ1.ForeColor == Color.Red) { labelCombinaisonPetiteSuiteJ1.Text = ""; }
            }

            //Grande Suite
            if (un >= 1 && deux >= 1 && trois >= 1 && quatre >= 1 && cinq >= 1 || deux >= 1 && trois >= 1 && quatre >= 1 && cinq >= 1 && six >= 1)
            {
                if (labelCombinaisonGrandeSuiteJ1.ForeColor == Color.Red) { labelCombinaisonGrandeSuiteJ1.Text = ""; }
            }
            else
            {
                if (labelCombinaisonGrandeSuiteJ1.ForeColor == Color.Red) { labelCombinaisonGrandeSuiteJ1.Text = ""; }
            }

            //Chance
            string chance = (unNombre + deuxNombre + troisNombre + quatreNombre + cinqNombre + sixNombre).ToString();
            if (labelCombinaisonChanceJ1.ForeColor == Color.Red) { labelCombinaisonChanceJ1.Text = chance; }

            //Yams
            if (un == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = unNombre.ToString(); }
            }
            else if (deux == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = deuxNombre.ToString(); }
            }
            else if (trois == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = troisNombre.ToString(); }
            }
            else if (quatre == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = quatreNombre.ToString(); }
            }
            else if (cinq == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = cinqNombre.ToString(); }
            }
            else if (six == 5)
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = sixNombre.ToString(); }
            }
            else
            {
                if (labelCombinaisonYamsJ1.ForeColor == Color.Red) { labelCombinaisonYamsJ1.Text = ""; }
            }
        }

        private bool verificationGroupeCombinaison()
        {
            bool plein = true;
            if (labelCombinaisonBrelanJ1.Text == "" || labelCombinaisonCarreJ1.Text == "" || labelCombinaisonFullJ1.Text == "" || labelCombinaisonPetiteSuiteJ1.Text == "" || labelCombinaisonGrandeSuiteJ1.Text == "" || labelCombinaisonChanceJ1.Text == "" || labelCombinaisonYamsJ1.Text == "" ) { plein = false; }
            return plein;
        }

        private bool verificationGroupeCombinaison1A6()
        {
            bool plein = true;
            if (labelCombinaison1J1.Text == "" || labelCombinaison2J1.Text == "" || labelCombinaison3J1.Text == "" || labelCombinaison4J1.Text == "" || labelCombinaison5J1.Text == "" || labelCombinaison6J1.Text == "") { plein = false; }
            return plein;
        }


        private void labelCombinaison1J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison1J1.Text == "") { labelCombinaison1J1.Text = "0"; joueur1.Combinaison["Un"] = 0; }
            else { joueur1.Combinaison["Un"] = int.Parse(labelCombinaison1J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison1J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaison2J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison2J1.Text == "") { labelCombinaison2J1.Text = "0"; joueur1.Combinaison["Deux"] = 0; }
            else { joueur1.Combinaison["Deux"] = int.Parse(labelCombinaison2J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison2J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaison3J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison3J1.Text == "") { labelCombinaison3J1.Text = "0"; joueur1.Combinaison["Trois"] = 0; }
            else { joueur1.Combinaison["Trois"] = int.Parse(labelCombinaison3J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison3J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaison4J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison4J1.Text == "") { labelCombinaison4J1.Text = "0"; joueur1.Combinaison["Quatre"] = 0; }
            else { joueur1.Combinaison["Quatre"] = int.Parse(labelCombinaison4J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison4J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaison5J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison5J1.Text == "") { labelCombinaison5J1.Text = "0"; joueur1.Combinaison["Cinq"] = 0; }
            else { joueur1.Combinaison["Cinq"] = int.Parse(labelCombinaison5J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison5J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaison6J1_Click(object sender, EventArgs e)
        {
            if (labelCombinaison6J1.Text == "") { labelCombinaison6J1.Text = "0"; joueur1.Combinaison["Six"] = 0; }
            else { joueur1.Combinaison["Six"] = int.Parse(labelCombinaison6J1.Text); }
            CalculSommeBonusTotal();
            labelCombinaison6J1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonBrelanJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonBrelanJ1.Text == "") { labelCombinaisonBrelanJ1.Text = "0"; joueur1.Combinaison["Brelan"] = 0; }
            else { joueur1.Combinaison["Brelan"] = int.Parse(labelCombinaisonBrelanJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonBrelanJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonCarreJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonCarreJ1.Text == "") { labelCombinaisonCarreJ1.Text = "0"; joueur1.Combinaison["Carré"] = 0; }
            else {joueur1.Combinaison["Carré"] = int.Parse(labelCombinaisonCarreJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonCarreJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonFullJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonFullJ1.Text == "") { labelCombinaisonFullJ1.Text = "0"; joueur1.Combinaison["Full"] = 0; }
            else { joueur1.Combinaison["Full"] = int.Parse(labelCombinaisonFullJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonFullJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonPetiteSuiteJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonPetiteSuiteJ1.Text == "") { labelCombinaisonPetiteSuiteJ1.Text = "0"; joueur1.Combinaison["Petite suite"] = 0; }
            else { joueur1.Combinaison["Petite suite"] = int.Parse(labelCombinaisonPetiteSuiteJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonPetiteSuiteJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonGrandeSuiteJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonGrandeSuiteJ1.Text == "") { labelCombinaisonGrandeSuiteJ1.Text = "0"; joueur1.Combinaison["Grand suite"] = 0; }
            else { joueur1.Combinaison["Grand suite"] = int.Parse(labelCombinaisonGrandeSuiteJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonGrandeSuiteJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonChanceJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonChanceJ1.Text == "") { labelCombinaisonChanceJ1.Text = "0"; joueur1.Combinaison["Chance"] = 0; }
            else { joueur1.Combinaison["Chance"] = int.Parse(labelCombinaisonChanceJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonChanceJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void labelCombinaisonYamsJ1_Click(object sender, EventArgs e)
        {
            if (labelCombinaisonYamsJ1.Text == "") { labelCombinaisonYamsJ1.Text = "0"; joueur1.Combinaison["Yams"] = 0; }
            else { joueur1.Combinaison["Yams"] = int.Parse(labelCombinaisonYamsJ1.Text); }
            CalculSommeBonusTotal();
            labelCombinaisonYamsJ1.ForeColor = Color.Black;
            validationSelection();
        }

        private void CalculSommeBonusTotal()
        {
            coup++;
            if (verificationGroupeCombinaison1A6() == true && verificationGroupeCombinaison() == false)
            {
                if (joueur1.Combinaison["Un"] == -1) { joueur1.Combinaison["Un"] = 0; }
                if (joueur1.Combinaison["Deux"] == -1) { joueur1.Combinaison["Deux"] = 0; }
                if (joueur1.Combinaison["Trois"] == -1) { joueur1.Combinaison["Trois"] = 0; }
                if (joueur1.Combinaison["Quatre"] == -1) { joueur1.Combinaison["Quatre"] = 0; }
                if (joueur1.Combinaison["Cinq"] == -1) { joueur1.Combinaison["Cinq"] = 0; }
                if (joueur1.Combinaison["Six"] == -1) { joueur1.Combinaison["Six"] = 0; }

                int sommeJ1 = joueur1.Combinaison["Un"] + joueur1.Combinaison["Deux"] + joueur1.Combinaison["Trois"] + joueur1.Combinaison["Quatre"] + joueur1.Combinaison["Cinq"] + joueur1.Combinaison["Six"];
                joueur1.Combinaison["Somme"] = sommeJ1;
                labelCombinaisonSommeJ1.Text = sommeJ1.ToString();
                if (sommeJ1 >= 63)
                {
                    joueur1.Combinaison["Bonus"] = 35;
                    labelCombinaisonBonusJ1.Text = "35";
                }
                else
                {
                    joueur1.Combinaison["Bonus"] = 0;
                    labelCombinaisonBonusJ1.Text = "0";
                }

                affichageTour();
                nombreLance = 0;

            }
            else if (verificationGroupeCombinaison() == true && verificationGroupeCombinaison1A6() == true || coup == 13)
            {
                int totalJ1 = 0;
                int index = 0;
                foreach (int value in joueur1.Combinaison.Values)
                {
                    if (value >= 0 && index != 6)
                    {
                        totalJ1 += value;
                    }
                    index++;
                }
                joueur1.Combinaison["Total"] = totalJ1;
                labelCombinaisonTotalJ1.Text = totalJ1.ToString();

                label2.Visible = false;
                labelPseudoGame.Visible = false;

                panelDes1.Visible = false;
                panelDes2.Visible = false;
                panelDes3.Visible = false;
                panelDes4.Visible = false;
                panelDes5.Visible = false;

                buttonLancer.Visible = false;
                buttonRetour.Visible = false;

                labelVictory.Visible = true;
                buttonReplay.Visible = true;
                buttonHome.Visible = true;

                labelVictory.Text = "Victoire de " + joueur1.Pseudo + " avec un score de " + labelCombinaisonTotalJ1.Text;
            }
            else
            {
                affichageTour();
                nombreLance = 0;
            }
        }

        private void buttonLancer_Click(object sender, EventArgs e)
        {
            if (nombreLance < 4)
            {
                if (!des1.Selection)
                {
                    int NuméroFace1 = des1.RandomFaces();
                    if (NuméroFace1 == 1) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés1; }
                    else if (NuméroFace1 == 2) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés2; }
                    else if (NuméroFace1 == 3) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés3; }
                    else if (NuméroFace1 == 4) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés4; }
                    else if (NuméroFace1 == 5) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés5; }
                    else if (NuméroFace1 == 6) { panelDes1.BackgroundImage = global::ProjetYams.Properties.Resources.Dés6; }
                }
                if (!des2.Selection)
                {
                    int NuméroFace2 = des2.RandomFaces();
                    if (NuméroFace2 == 1) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés1; }
                    else if (NuméroFace2 == 2) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés2; }
                    else if (NuméroFace2 == 3) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés3; }
                    else if (NuméroFace2 == 4) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés4; }
                    else if (NuméroFace2 == 5) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés5; }
                    else if (NuméroFace2 == 6) { panelDes2.BackgroundImage = global::ProjetYams.Properties.Resources.Dés6; }
                }
                if (!des3.Selection)
                {
                    int NuméroFace3 = des3.RandomFaces();
                    if (NuméroFace3 == 1) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés1; }
                    else if (NuméroFace3 == 2) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés2; }
                    else if (NuméroFace3 == 3) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés3; }
                    else if (NuméroFace3 == 4) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés4; }
                    else if (NuméroFace3 == 5) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés5; }
                    else if (NuméroFace3 == 6) { panelDes3.BackgroundImage = global::ProjetYams.Properties.Resources.Dés6; }
                }
                if (!des4.Selection)
                {
                    int NuméroFace4 = des4.RandomFaces();
                    if (NuméroFace4 == 1) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés1; }
                    else if (NuméroFace4 == 2) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés2; }
                    else if (NuméroFace4 == 3) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés3; }
                    else if (NuméroFace4 == 4) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés4; }
                    else if (NuméroFace4 == 5) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés5; }
                    else if (NuméroFace4 == 6) { panelDes4.BackgroundImage = global::ProjetYams.Properties.Resources.Dés6; }
                }
                if (!des5.Selection)
                {
                    int NuméroFace5 = des5.RandomFaces();
                    if (NuméroFace5 == 1) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés1; }
                    else if (NuméroFace5 == 2) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés2; }
                    else if (NuméroFace5 == 3) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés3; }
                    else if (NuméroFace5 == 4) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés4; }
                    else if (NuméroFace5 == 5) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés5; }
                    else if (NuméroFace5 == 6) { panelDes5.BackgroundImage = global::ProjetYams.Properties.Resources.Dés6; }
                }

                panelDes1.Visible = true;
                panelDes2.Visible = true;
                panelDes3.Visible = true;
                panelDes4.Visible = true;
                panelDes5.Visible = true;

                buttonLancer.Location = new Point(691, 699);

                calculPoint();

                if (nombreLance == 2)
                {
                    buttonLancer.Visible = false;
                }
            }
            nombreLance++;
        }

        private void panelDes1_Click(object sender, EventArgs e)
        {
            if (des1.Selection)
            {
                des1.Selection = false;
                desSelection--;
            }
            else
            {
                des1.Selection = true;
                desSelection++;
            }
            actualisationDes();
        }

        private void panelDes2_Click(object sender, EventArgs e)
        {
            if (des2.Selection)
            {
                des2.Selection = false;
                desSelection--;
            }
            else
            {
                des2.Selection = true;
                desSelection++;
            }
            actualisationDes();
        }

        private void panelDes3_Click(object sender, EventArgs e)
        {
            if (des3.Selection)
            {
                des3.Selection = false;
                desSelection--;
            }
            else
            {
                des3.Selection = true;
                desSelection++;
            }
            actualisationDes();
        }

        private void panelDes4_Click(object sender, EventArgs e)
        {
            if (des4.Selection)
            {
                des4.Selection = false;
                desSelection--;
            }
            else
            {
                des4.Selection = true;
                desSelection++;
            }
            actualisationDes();
        }

        private void panelDes5_Click(object sender, EventArgs e)
        {
            if (des5.Selection)
            {
                des5.Selection = false;
                desSelection--;
            }
            else
            {
                des5.Selection = true;
                desSelection++;
            }
            actualisationDes();
        }
    }
}