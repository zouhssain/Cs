namespace Gestion_des_notes
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.etudiant = new System.Windows.Forms.Button();
            this.prof = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // etudiant
            // 
            this.etudiant.BackColor = System.Drawing.Color.Teal;
            this.etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etudiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.etudiant.Location = new System.Drawing.Point(81, 99);
            this.etudiant.Margin = new System.Windows.Forms.Padding(4);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(280, 53);
            this.etudiant.TabIndex = 1;
            this.etudiant.Text = "Etudiant";
            this.etudiant.UseVisualStyleBackColor = false;
            this.etudiant.Click += new System.EventHandler(this.etudiant_Click);
            // 
            // prof
            // 
            this.prof.BackColor = System.Drawing.Color.Teal;
            this.prof.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prof.Location = new System.Drawing.Point(81, 160);
            this.prof.Margin = new System.Windows.Forms.Padding(4);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(280, 53);
            this.prof.TabIndex = 2;
            this.prof.Text = "Professeur";
            this.prof.UseVisualStyleBackColor = false;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Teal;
            this.admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin.Location = new System.Drawing.Point(81, 221);
            this.admin.Margin = new System.Windows.Forms.Padding(4);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(280, 53);
            this.admin.TabIndex = 3;
            this.admin.Text = "Administration";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.Color.Teal;
            this.quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitter.Location = new System.Drawing.Point(81, 282);
            this.quitter.Margin = new System.Windows.Forms.Padding(4);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(280, 53);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quiter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 613);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "About us";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(177, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ABOUT US";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.StyleChanged += new System.EventHandler(this.label3_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 459);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "z.ouhssain@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUHSSAIN ZAKARIAE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.etudiant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button etudiant;
        private System.Windows.Forms.Button prof;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

