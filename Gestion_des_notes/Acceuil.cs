using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_notes
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
            panel1.Visible = false;
            label3.Font = new Font(label3.Font.Name, 12);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 1 / 3;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height * 2 / 3;
            this.Size = new Size(tailleFenetreX, tailleFenetreY);
        }
        


        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Underline);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Underline);
            label3.ForeColor = Color.FromArgb(166, 6, 6);
        }
        
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, 12);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void etudiant_Click(object sender, EventArgs e)
        {
            Login_Etudiant Login_Etudiant = new Login_Etudiant();
            Login_Etudiant.Show();
            this.Hide();
        }

        private void prof_Click(object sender, EventArgs e)
        {
            Login_Prof Login_Prof = new Login_Prof();
            Login_Prof.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Login_admin Login_admin = new Login_admin();
            Login_admin.Show();
            this.Hide();
        }
    }
}
