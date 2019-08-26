using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_des_notes
{
    public partial class Login_Prof : Form
    {
        public static String Liaison = "Server = 127.0.0.1; Port = 3306; UID = Zak; PASSWORD = 0000; DATABASE = Gestion_des_notes; SslMode = none;";

        Boolean etat = true;
        public Login_Prof()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Acceuil Form1 = new Acceuil();
            Form1.Show();
            this.Hide();
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.backdeprof.Image = global::Gestion_des_notes.Properties.Resources.Back_1;
        }

        private void backdeprof_MouseLeave(object sender, EventArgs e)
        {
            this.backdeprof.Image = global::Gestion_des_notes.Properties.Resources.Back;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (etat)
            {
                this.passwordP.UseSystemPasswordChar = false;
                etat = false;
            }

            else
            {
                this.passwordP.UseSystemPasswordChar = true;
                etat = true;
            }
        }

        private void IsloginValidProf()
        {
            String login1 = loginP.Text;
            String password1 = passwordP.Text;
            string query = "SELECT * FROM `prof` WHERE LOGIN='" + login1 + "' AND PASSWORD='" + password1 + "' ";
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String name = reader.GetString(2);
                        MessageBox.Show("Welcome " + name);
                        Espace_Prof Espace_Prof = new Espace_Prof(reader.GetString(5));
                        Espace_Prof.Text = reader.GetString(2); 
                        Espace_Prof.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (login1 == "" || password1 == "")
                    {
                        MessageBox.Show("Un des champs à remplir est vide");
                    }
                    if (password1 != "" && login1 != "")
                        MessageBox.Show("Les informations sont incorrectes");
                    loginP.Text = "";
                    passwordP.Text = "";
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            IsloginValidProf();
        }
    }
}
