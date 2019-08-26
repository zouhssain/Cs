using System;
using System.Drawing;

namespace Gestion_des_notes
{
    partial class Espace_Etudiant
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
            this.entete = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Deco = new System.Windows.Forms.Button();
            this.TabledeNote = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entete.SuspendLayout();
            this.TabledeNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete
            // 
            this.entete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.entete.Controls.Add(this.label1);
            this.entete.Controls.Add(this.Deco);
            this.entete.Location = new System.Drawing.Point(0, 0);
            this.entete.Name = "entete";
            this.entete.Size = new System.Drawing.Size(819, 33);
            this.entete.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Deco
            // 
            this.Deco.Location = new System.Drawing.Point(729, 4);
            this.Deco.Name = "Deco";
            this.Deco.Size = new System.Drawing.Size(84, 23);
            this.Deco.TabIndex = 0;
            this.Deco.Text = "Deconnexion";
            this.Deco.UseVisualStyleBackColor = true;
            this.Deco.Click += new System.EventHandler(this.Deco_Click);
            // 
            // TabledeNote
            // 
            this.TabledeNote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TabledeNote.Controls.Add(this.dataGridView1);
            this.TabledeNote.Location = new System.Drawing.Point(6, 33);
            this.TabledeNote.Name = "TabledeNote";
            this.TabledeNote.Size = new System.Drawing.Size(807, 421);
            this.TabledeNote.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Module";
            this.Column1.Name = "Column1";
            this.Column1.Width = 380;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Note";
            this.Column2.Name = "Column2";
            this.Column2.Width = 384;
            // 
            // Espace_Etudiant
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 461);
            this.Controls.Add(this.TabledeNote);
            this.Controls.Add(this.entete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Espace_Etudiant";
            this.Load += new System.EventHandler(this.Espace_Etudiant_Load);
            this.entete.ResumeLayout(false);
            this.entete.PerformLayout();
            this.TabledeNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel entete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deco;
        private System.Windows.Forms.Panel TabledeNote;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}