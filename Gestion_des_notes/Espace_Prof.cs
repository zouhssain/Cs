using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_des_notes
{
    public partial class Espace_Prof : Form
    {
        String Liaison = "Server = 127.0.0.1; Port = 3306; UID = Zak; PASSWORD = 0000; DATABASE = Gestion_des_notes; SslMode = none;";

        Boolean etat = true;
        Boolean etat_1 = true;
        Boolean etat_2 = true;
        String pourrequette;
        public Espace_Prof(String matiere)
        {
            InitializeComponent();
            pourrequette = matiere;
            runQueryNote();
            ToutlesNoms();
            ToutlesNoms_combo_modifier();
            comboBox3.Visible = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            panel7.Visible = false;
        }
        private void Deco_Click(object sender, EventArgs e)
        {
            Acceuil Form1 = new Acceuil();
            Form1.Show();
            this.Close();
        }

        private void Espace_Prof_Load(object sender, EventArgs e)
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(tailleFenetreX / 5, tailleFenetreY / 5);
            this.Size = new Size(tailleFenetreX * 3 / 5, tailleFenetreY * 3 / 5);
            label1.Text = "Welcome " + this.Text;
        }

        public static Point getSize()
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 3 / 5;
            int tailleFenetreY = Screen.PrimaryScreen.Bounds.Height;
            Point x = new Point(tailleFenetreX, 33);
            return x;
        }

        public static int GetWidth()
        {
            int tailleFenetreX = Screen.PrimaryScreen.Bounds.Width * 3 / 5;
            return tailleFenetreX;
        }
        
        //--------- dbut style--------------------------------------------
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 100);
            this.button1.Size = new System.Drawing.Size(154, 51);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 100);
            this.button1.Size = new System.Drawing.Size(154, 51);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 154);
            this.button2.Size = new System.Drawing.Size(154, 51);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 154);
            this.button2.Size = new System.Drawing.Size(154, 51);
        }        

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 208);
            this.button3.Size = new System.Drawing.Size(154, 51);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 208);
            this.button3.Size = new System.Drawing.Size(154, 51);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(24, 262);
            this.button4.Size = new System.Drawing.Size(154, 51);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(24, 262);
            this.button4.Size = new System.Drawing.Size(154, 51);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(24, 316);
            this.button5.Size = new System.Drawing.Size(154, 51);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(24, 316);
            this.button5.Size = new System.Drawing.Size(154, 51);
        }
        //-------------------fin style--------------------------------


        private void runQueryNote()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);


            string query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ";
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
                        dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(5), reader.GetFloat(1));
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            runQueryNote();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        public void ToutlesNoms()
        {
            dataGridView1.Rows.Clear();
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
                        String obj = reader.GetString("NOM_COMPLET");
                        comboBox1.Items.Add(obj);
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

        public void ToutlesNoms_combo_modifier()
        {
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
                        String obj = reader.GetString("NOM_COMPLET");
                        comboBox2.Items.Add(obj);
                        comboBox3.Items.Add(obj);
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

        private void button6_Click(object sender, EventArgs e)
        {
            runQueryAdd();
            textBox1.Text = "";
        }

        public void runQueryAdd()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);
            String name = comboBox1.SelectedItem.ToString();
            String note_string = textBox1.Text.ToString().Replace('.',',');
            
            float note = float.Parse(note_string, CultureInfo.InvariantCulture.NumberFormat);

            if (note > 100) { note = note / 10; }
            if (note > 1000) note /= 100;

            string query = "UPDATE `note` SET `Note_Module` = '"+ note + "' WHERE NOM_COMPLET = '" + name + "' AND MATIERE = '"+pourrequette+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("l'ajout de la note est exécuté avec succès!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            runQueryDelete();
        }

        public void runQueryDelete()
        {

            dataGridView2.Rows.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);

            string query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ";
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
                        dataGridView2.Rows.Add(reader.GetString("NOM_COMPLET"), reader.GetFloat("Note_Module"));
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

        private void button7_Click(object sender, EventArgs e)
        {
            int[] nombres;
            nombres = new int[dataGridView2.Rows.Count];
            
            for (int i=0;i<dataGridView2.Rows.Count;i++)
            {
                MySqlConnection databaseConnection = new MySqlConnection(Liaison);
                MySqlDataReader reader;
                string query = "UPDATE `note` SET `Note_Module` = '0' WHERE '"+ dataGridView2.Rows[i].Cells[2].Selected + "' = 'TRUE' AND NOM_COMPLET = '"+ dataGridView2.Rows[i].Cells[0].Value + "' ";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                databaseConnection.Open();

            reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }            
            MessageBox.Show("Succesful!");
            runQueryDelete();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if(!Char.IsDigit(ch) && ch != 8 && ch!= 46 )
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String choix = comboBox2.Text.ToString();
            //String choix = comboBox2.Items.ToString();
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);
            string query = "SELECT * FROM `note` WHERE NOM_COMPLET = '" + choix + "' AND MATIERE = '"+pourrequette+"' ";

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
                        textBox2.Text = reader.GetFloat("Note_Module").ToString();
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


        public void runQueryUpdate()
        {
            MySqlConnection databaseConnection = new MySqlConnection(Liaison);
            String name = comboBox2.SelectedItem.ToString();
            String note_string = textBox2.Text.ToString().Replace('.', ',');

            float note = float.Parse(note_string, CultureInfo.InvariantCulture.NumberFormat);

            if (note > 100) { note = note / 10; }
            if (note > 1000) note /= 100;

            string query = "UPDATE `note` SET `Note_Module` = '" + note + "' WHERE NOM_COMPLET = '" + name + "' AND MATIERE = '"+pourrequette+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("la modification de la note est exécuté avec succès!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            runQueryUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (etat)
            {
                comboBox3.Visible = true;
                textBox3.Visible = false;
                etat = false;
            }
            else
            {
                comboBox3.Visible = false;
                textBox3.Visible = true;
                etat = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (etat)
            {
                //textBox3
                if (textBox3.Text == "") MessageBox.Show("Veuillez Saisir un nom");
                else
                {
                    dataGridView3.Rows.Clear();
                    String choix = textBox3.Text;
                    MySqlConnection databaseConnection = new MySqlConnection(Liaison);
                    string query = "SELECT * FROM `note` WHERE NOM_COMPLET LIKE '" + choix + "' AND MATIERE = '" + pourrequette + "' ";
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
                                dataGridView3.Rows.Add(reader.GetString("CNE"), reader.GetString("NOM_COMPLET"), reader.GetFloat("Note_Module"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune résultat trouvés");
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
            else
            {
                //comboBox3
                if (comboBox3.Text == "") MessageBox.Show("Veuillez choisir un nom");
                else
                {
                    dataGridView3.Rows.Clear();
                    String choix = comboBox3.Text.ToString();
                    MySqlConnection databaseConnection = new MySqlConnection(Liaison);
                    string query = "SELECT * FROM `note` WHERE NOM_COMPLET = '" + choix + "' AND MATIERE = '" + pourrequette + "' ";
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
                                dataGridView3.Rows.Add(reader.GetString("CNE"), reader.GetString("NOM_COMPLET"), reader.GetFloat("Note_Module"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune résultat trouvés");
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

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            MySqlCommand commandDatabase;
            string query="";
            if (etat_1 && etat_2) MessageBox.Show("Veuillez choisir au moins un choix!");
            else
            {
                MySqlConnection databaseConnection = new MySqlConnection(Liaison);
                string VorR=comboBox4.Text.ToString();
                string classement = comboBox5.Text.ToString();
                if (etat_1==false) {
                    if (VorR == "VALIDANTS") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette+"'"; }
                    if (VorR == "RATTRAPPANTS") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "'"; }
                    if (VorR == "TOUS") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "'"; }
                    if (etat_2 == false) {
                        if (VorR == "VALIDANTS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE `Note_Module` >= '12' AND MATIERE = 'C#' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement== "SANS ORDRE") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette + "'"; }
                        }
                        if (VorR == "RATTRAPPANTS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "'"; }
                        }
                        if (VorR == "TOUS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "'"; }
                        }
                    }
                }
                if (etat_2 == false) {
                    if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                    if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC"; }
                    if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "'"; }

                    if (etat_1 == false) {
                        if (VorR == "VALIDANTS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE Note_Module >= 12 AND MATIERE = '" + pourrequette + "'"; }
                        }
                        if (VorR == "RATTRAPPANTS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE Note_Module < 12 AND MATIERE = '" + pourrequette + "'"; }
                        }
                        if (VorR == "TOUS")
                        {
                            if (classement == "ASCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` ASC"; }
                            if (classement == "DESCENDANT") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "' ORDER BY `note`.`Note_Module` DESC "; }
                            if (classement == "SANS ORDRE") { query = "SELECT * FROM `note` WHERE MATIERE = '" + pourrequette + "'"; }
                        }
                    }
                }

                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView3.Rows.Add(reader.GetString("CNE"), reader.GetString("NOM_COMPLET"), reader.GetFloat("Note_Module"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune résultat trouvés");
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (etat_1)
            {etat_1 = false;}
            else
            {etat_1 = true;}
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (etat_2)
            { etat_2 = false; }
            else
            { etat_2 = true; }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = true;
        }
    }
}
