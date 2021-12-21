﻿namespace ProjetYams
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelBy = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxJoueur2 = new System.Windows.Forms.TextBox();
            this.textBoxJoueur1 = new System.Windows.Forms.TextBox();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.labelBy);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1024, 100);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::ProjetYams.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(917, 24);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjetYams.Properties.Resources.close2;
            this.btnClose.Location = new System.Drawing.Point(958, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelBy
            // 
            this.labelBy.AutoSize = true;
            this.labelBy.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBy.ForeColor = System.Drawing.Color.White;
            this.labelBy.Location = new System.Drawing.Point(438, 59);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(125, 15);
            this.labelBy.TabIndex = 2;
            this.labelBy.Text = "By Florent Deswaerte";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(450, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "YAMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetYams.Properties.Resources.game_control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBackground.Controls.Add(this.pictureBox3);
            this.panelBackground.Controls.Add(this.pictureBox2);
            this.panelBackground.Controls.Add(this.buttonPlay);
            this.panelBackground.Controls.Add(this.textBoxJoueur2);
            this.panelBackground.Controls.Add(this.textBoxJoueur1);
            this.panelBackground.Controls.Add(this.labelJoueur2);
            this.panelBackground.Controls.Add(this.labelJoueur1);
            this.panelBackground.Location = new System.Drawing.Point(292, 204);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(437, 450);
            this.panelBackground.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetYams.Properties.Resources.users;
            this.pictureBox3.Location = new System.Drawing.Point(134, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetYams.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(134, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(121, 340);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(200, 56);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Jouer";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxJoueur2
            // 
            this.textBoxJoueur2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxJoueur2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJoueur2.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJoueur2.ForeColor = System.Drawing.Color.White;
            this.textBoxJoueur2.Location = new System.Drawing.Point(121, 254);
            this.textBoxJoueur2.MaxLength = 8;
            this.textBoxJoueur2.Name = "textBoxJoueur2";
            this.textBoxJoueur2.PlaceholderText = "Pseudo";
            this.textBoxJoueur2.Size = new System.Drawing.Size(200, 32);
            this.textBoxJoueur2.TabIndex = 8;
            this.textBoxJoueur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJoueur1
            // 
            this.textBoxJoueur1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxJoueur1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJoueur1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJoueur1.ForeColor = System.Drawing.Color.White;
            this.textBoxJoueur1.Location = new System.Drawing.Point(121, 146);
            this.textBoxJoueur1.MaxLength = 8;
            this.textBoxJoueur1.Name = "textBoxJoueur1";
            this.textBoxJoueur1.PlaceholderText = "Pseudo";
            this.textBoxJoueur1.Size = new System.Drawing.Size(200, 32);
            this.textBoxJoueur1.TabIndex = 7;
            this.textBoxJoueur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur2.ForeColor = System.Drawing.Color.White;
            this.labelJoueur2.Location = new System.Drawing.Point(179, 203);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(133, 37);
            this.labelJoueur2.TabIndex = 6;
            this.labelJoueur2.Text = "Joueur 2";
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoueur1.ForeColor = System.Drawing.Color.White;
            this.labelJoueur1.Location = new System.Drawing.Point(179, 91);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(128, 37);
            this.labelJoueur1.TabIndex = 5;
            this.labelJoueur1.Text = "Joueur 1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitleBar;
        private Label labelBy;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panelBackground;
        private Button buttonPlay;
        private TextBox textBoxJoueur2;
        private TextBox textBoxJoueur1;
        private Label labelJoueur2;
        private Label labelJoueur1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}