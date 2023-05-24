namespace BabyFoot
{
    partial class Home
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
            this.jouer = new System.Windows.Forms.Button();
            this.joueur1 = new System.Windows.Forms.TextBox();
            this.nom_J1 = new System.Windows.Forms.LinkLabel();
            this.argent_J1 = new System.Windows.Forms.LinkLabel();
            this.argent1 = new System.Windows.Forms.TextBox();
            this.nom_J2 = new System.Windows.Forms.LinkLabel();
            this.joueur2 = new System.Windows.Forms.TextBox();
            this.argent_J2 = new System.Windows.Forms.LinkLabel();
            this.argent2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jouer
            // 
            this.jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jouer.Location = new System.Drawing.Point(303, 304);
            this.jouer.Name = "jouer";
            this.jouer.Size = new System.Drawing.Size(169, 49);
            this.jouer.TabIndex = 0;
            this.jouer.Text = "Jouer";
            this.jouer.UseVisualStyleBackColor = true;
            this.jouer.Click += new System.EventHandler(this.jouer_Click);
            // 
            // joueur1
            // 
            this.joueur1.Location = new System.Drawing.Point(173, 133);
            this.joueur1.Name = "joueur1";
            this.joueur1.Size = new System.Drawing.Size(156, 20);
            this.joueur1.TabIndex = 1;
            this.joueur1.Text = "tafitasoa";
            this.joueur1.TextChanged += new System.EventHandler(this.joueur1_TextChanged);
            // 
            // nom_J1
            // 
            this.nom_J1.AutoSize = true;
            this.nom_J1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_J1.LinkColor = System.Drawing.Color.Black;
            this.nom_J1.Location = new System.Drawing.Point(77, 136);
            this.nom_J1.Name = "nom_J1";
            this.nom_J1.Size = new System.Drawing.Size(71, 20);
            this.nom_J1.TabIndex = 2;
            this.nom_J1.TabStop = true;
            this.nom_J1.Text = "Joueur 1";
            this.nom_J1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // argent_J1
            // 
            this.argent_J1.AutoSize = true;
            this.argent_J1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argent_J1.LinkColor = System.Drawing.Color.Black;
            this.argent_J1.Location = new System.Drawing.Point(77, 187);
            this.argent_J1.Name = "argent_J1";
            this.argent_J1.Size = new System.Drawing.Size(57, 20);
            this.argent_J1.TabIndex = 3;
            this.argent_J1.TabStop = true;
            this.argent_J1.Text = "Argent";
            this.argent_J1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_mise1_LinkClicked);
            // 
            // argent1
            // 
            this.argent1.Location = new System.Drawing.Point(173, 184);
            this.argent1.Name = "argent1";
            this.argent1.Size = new System.Drawing.Size(156, 20);
            this.argent1.TabIndex = 4;
            this.argent1.Text = "5000";
            this.argent1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nom_J2
            // 
            this.nom_J2.AutoSize = true;
            this.nom_J2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_J2.LinkColor = System.Drawing.Color.Black;
            this.nom_J2.Location = new System.Drawing.Point(401, 136);
            this.nom_J2.Name = "nom_J2";
            this.nom_J2.Size = new System.Drawing.Size(71, 20);
            this.nom_J2.TabIndex = 5;
            this.nom_J2.TabStop = true;
            this.nom_J2.Text = "Joueur 2";
            // 
            // joueur2
            // 
            this.joueur2.Location = new System.Drawing.Point(495, 134);
            this.joueur2.Name = "joueur2";
            this.joueur2.Size = new System.Drawing.Size(158, 20);
            this.joueur2.TabIndex = 6;
            this.joueur2.Text = "Fleuris";
            this.joueur2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // argent_J2
            // 
            this.argent_J2.AutoSize = true;
            this.argent_J2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argent_J2.LinkColor = System.Drawing.Color.Black;
            this.argent_J2.Location = new System.Drawing.Point(401, 186);
            this.argent_J2.Name = "argent_J2";
            this.argent_J2.Size = new System.Drawing.Size(57, 20);
            this.argent_J2.TabIndex = 7;
            this.argent_J2.TabStop = true;
            this.argent_J2.Text = "Argent";
            // 
            // argent2
            // 
            this.argent2.Location = new System.Drawing.Point(495, 187);
            this.argent2.Name = "argent2";
            this.argent2.Size = new System.Drawing.Size(158, 20);
            this.argent2.TabIndex = 8;
            this.argent2.Text = "6000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Foot Ball";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // mise
            // 
            this.mise.Location = new System.Drawing.Point(358, 265);
            this.mise.Name = "mise";
            this.mise.Size = new System.Drawing.Size(114, 20);
            this.mise.TabIndex = 10;
            this.mise.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mise";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.argent2);
            this.Controls.Add(this.argent_J2);
            this.Controls.Add(this.joueur2);
            this.Controls.Add(this.nom_J2);
            this.Controls.Add(this.argent1);
            this.Controls.Add(this.argent_J1);
            this.Controls.Add(this.nom_J1);
            this.Controls.Add(this.joueur1);
            this.Controls.Add(this.jouer);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jouer;
        private System.Windows.Forms.TextBox joueur1;
        private System.Windows.Forms.LinkLabel nom_J1;
        private System.Windows.Forms.LinkLabel argent_J1;
        private System.Windows.Forms.TextBox argent1;
        private System.Windows.Forms.LinkLabel nom_J2;
        private System.Windows.Forms.TextBox joueur2;
        private System.Windows.Forms.LinkLabel argent_J2;
        private System.Windows.Forms.TextBox argent2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mise;
        private System.Windows.Forms.Label label3;
    }
}

