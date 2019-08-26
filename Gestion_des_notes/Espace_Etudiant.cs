using MySql.Data.MySqlClient;
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
    public partial class Espace_Etudiant : Form
    {
        String Liaison = "Server = 127.0.0.1; Port = 3306; UID = Zak; PASSWORD = 0000; DATABASE = Gestion_des_notes; SslMode = none;";
        String pourrequette;

        int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width;
        int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;

        public Espace_Etudiant(String cne)
        {
            InitializeComponent();
            pourrequette = cne;
            runQueryNote();
        }

        private void Espace_Etudiant_Load(object sender, EventArgs e)
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(tailleFenetreX/5, tailleFenetreY/5);
            this.Size = new Size(tailleFenetreX * 3 / 5, tailleFenetreY * 3 / 5);
            label1.Text = "Welcome "+this.Text;
        }
        
        public static Point getSize()
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 3 / 5;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;
            Point x = new Point(tailleFenetreX,33);
            return x;
        }

        public static int GetWidth()
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 3 / 5;
            return tailleFenetreX;
        }

        public static int GetWidthTab()
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 3 / 10;
            return tailleFenetreX-40;
        }



        private void Deco_Click(object sender, EventArgs e)
        {
            Acceuil Form1 = new Acceuil();
            Form1.Show();
            this.Close();
        }


        private void runQueryNote()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);
            

            string query = "SELECT * FROM `note` WHERE CNE = '"+pourrequette+"' ";
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
                        dataGridView1.Rows.Add(reader.GetString(3), reader.GetFloat(1));
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
