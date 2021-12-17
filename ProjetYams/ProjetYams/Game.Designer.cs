namespace ProjetYams
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar2 = new System.Windows.Forms.Panel();
            this.btnMinimize2 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.labelBy = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPseudoGame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetYams.Properties.Resources.game_control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar2
            // 
            this.panelTitleBar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar2.Controls.Add(this.btnMinimize2);
            this.panelTitleBar2.Controls.Add(this.btnClose2);
            this.panelTitleBar2.Controls.Add(this.labelBy);
            this.panelTitleBar2.Controls.Add(this.labelTitle);
            this.panelTitleBar2.Controls.Add(this.pictureBox2);
            this.panelTitleBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar2.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar2.Name = "panelTitleBar2";
            this.panelTitleBar2.Size = new System.Drawing.Size(1024, 100);
            this.panelTitleBar2.TabIndex = 3;
            this.panelTitleBar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar2_MouseDown);
            // 
            // btnMinimize2
            // 
            this.btnMinimize2.FlatAppearance.BorderSize = 0;
            this.btnMinimize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize2.Image = global::ProjetYams.Properties.Resources.minimize;
            this.btnMinimize2.Location = new System.Drawing.Point(917, 24);
            this.btnMinimize2.Name = "btnMinimize2";
            this.btnMinimize2.Size = new System.Drawing.Size(35, 50);
            this.btnMinimize2.TabIndex = 4;
            this.btnMinimize2.UseVisualStyleBackColor = true;
            this.btnMinimize2.Click += new System.EventHandler(this.btnMinimize2_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.FlatAppearance.BorderSize = 0;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Image = global::ProjetYams.Properties.Resources.close2;
            this.btnClose2.Location = new System.Drawing.Point(958, 24);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(35, 50);
            this.btnClose2.TabIndex = 3;
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetYams.Properties.Resources.game_control;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelPseudoGame
            // 
            this.labelPseudoGame.AutoSize = true;
            this.labelPseudoGame.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPseudoGame.ForeColor = System.Drawing.Color.Black;
            this.labelPseudoGame.Location = new System.Drawing.Point(8, 709);
            this.labelPseudoGame.Name = "labelPseudoGame";
            this.labelPseudoGame.Size = new System.Drawing.Size(95, 37);
            this.labelPseudoGame.TabIndex = 5;
            this.labelPseudoGame.Text = "YAMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tour de :";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPseudoGame);
            this.Controls.Add(this.panelTitleBar2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar2.ResumeLayout(false);
            this.panelTitleBar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelTitleBar2;
        private Button btnMinimize2;
        private Button btnClose2;
        private Label labelBy;
        private Label labelTitle;
        private PictureBox pictureBox2;
        private Label labelPseudoGame;
        private Label label2;
    }
}