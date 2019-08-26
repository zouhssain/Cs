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
    public partial class Espace_admin : Form
    {
        String Liaison = "Server = 127.0.0.1; Port = 3306; UID = Zak; PASSWORD = 0000; DATABASE = Gestion_des_notes; SslMode = none;";

        public Espace_admin()
        {
            InitializeComponent();
        }

        private void Espace_admin_Load(object sender, EventArgs e)
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(tailleFenetreX / 5, tailleFenetreY / 5);
            this.Size = new Size(tailleFenetreX * 3 / 5, tailleFenetreY * 3 / 5);
            label1.Text = "Welcome " + this.Text;
        }

        private void deco_Click(object sender, EventArgs e)
        {
            Acceuil Form1 = new Acceuil();
            Form1.Show();
            this.Close();
        }

        private void lISTEETUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeEtudiants();
        }

        public void ListeEtudiants()
        {
            dataGridView1.Rows.Clear();
            Column6.HeaderText = "CNE";
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);


            string query = "SELECT * FROM `etudiant` ";
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
                        dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetString(5) );
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lISTEPROFESSEURSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProf();
        }
        public void ListeProf()
        {
            dataGridView1.Rows.Clear();
            Column6.HeaderText = "MATIERE";
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);


            string query = "SELECT * FROM `prof` ";
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
                        dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetString(5));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
