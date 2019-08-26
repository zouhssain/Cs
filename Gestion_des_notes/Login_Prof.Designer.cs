namespace Gestion_des_notes
{
    partial class Login_Prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Prof));
            this.loginP = new System.Windows.Forms.TextBox();
            this.passwordP = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.titre_espace_prof = new System.Windows.Forms.Label();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.password_img_EP = new System.Windows.Forms.Label();
            this.login_image_EP = new System.Windows.Forms.Label();
            this.backdeprof = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginP
            // 
            this.loginP.Location = new System.Drawing.Point(172, 112);
            this.loginP.Name = "loginP";
            this.loginP.Size = new System.Drawing.Size(194, 20);
            this.loginP.TabIndex = 2;
            // 
            // passwordP
            // 
            this.passwordP.Location = new System.Drawing.Point(173, 147);
            this.passwordP.Name = "passwordP";
            this.passwordP.Size = new System.Drawing.Size(193, 20);
            this.passwordP.TabIndex = 4;
            this.passwordP.UseSystemPasswordChar = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(349, 150);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // titre_espace_prof
            // 
            this.titre_espace_prof.AutoSize = true;
            this.titre_espace_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_espace_prof.ForeColor = System.Drawing.Color.SteelBlue;
            this.titre_espace_prof.Location = new System.Drawing.Point(172, 38);
            this.titre_espace_prof.Name = "titre_espace_prof";
            this.titre_espace_prof.Size = new System.Drawing.Size(186, 24);
            this.titre_espace_prof.TabIndex = 6;
            this.titre_espace_prof.Text = "Espace Professeur";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(291, 182);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 7;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // password_img_EP
            // 
            this.password_img_EP.Image = ((System.Drawing.Image)(resources.GetObject("password_img_EP.Image")));
            this.password_img_EP.Location = new System.Drawing.Point(143, 145);
            this.password_img_EP.Name = "password_img_EP";
            this.password_img_EP.Size = new System.Drawing.Size(23, 23);
            this.password_img_EP.TabIndex = 3;
            // 
            // login_image_EP
            // 
            this.login_image_EP.Image = ((System.Drawing.Image)(resources.GetObject("login_image_EP.Image")));
            this.login_image_EP.Location = new System.Drawing.Point(143, 112);
            this.login_image_EP.Name = "login_image_EP";
            this.login_image_EP.Size = new System.Drawing.Size(23, 23);
            this.login_image_EP.TabIndex = 1;
            // 
            // backdeprof
            // 
            this.backdeprof.Image = ((System.Drawing.Image)(resources.GetObject("backdeprof.Image")));
            this.backdeprof.Location = new System.Drawing.Point(12, 9);
            this.backdeprof.Name = "backdeprof";
            this.backdeprof.Size = new System.Drawing.Size(46, 43);
            this.backdeprof.TabIndex = 0;
            this.backdeprof.Click += new System.EventHandler(this.label1_Click);
            this.backdeprof.MouseEnter += new System.EventHandler(this.label1_MouseHover);
            this.backdeprof.MouseLeave += new System.EventHandler(this.backdeprof_MouseLeave);
            // 
            // Login_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.titre_espace_prof);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.passwordP);
            this.Controls.Add(this.password_img_EP);
            this.Controls.Add(this.loginP);
            this.Controls.Add(this.login_image_EP);
            this.Controls.Add(this.backdeprof);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login_Prof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Professeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label backdeprof;
        private System.Windows.Forms.Label login_image_EP;
        private System.Windows.Forms.TextBox loginP;
        private System.Windows.Forms.Label password_img_EP;
        private System.Windows.Forms.TextBox passwordP;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label titre_espace_prof;
        private System.Windows.Forms.Button btnEnvoyer;
    }
}