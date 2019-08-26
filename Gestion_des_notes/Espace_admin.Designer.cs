namespace Gestion_des_notes
{
    partial class Espace_admin
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
            this.deco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aJOUTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTEETUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTEPROFESSEURSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJOUTERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSEURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSEURToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mETTREAJOURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSEURToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete
            // 
            this.entete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.entete.Controls.Add(this.label1);
            this.entete.Controls.Add(this.deco);
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
            // deco
            // 
            this.deco.Location = new System.Drawing.Point(729, 4);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(84, 23);
            this.deco.TabIndex = 0;
            this.deco.Text = "Deconnexion";
            this.deco.UseVisualStyleBackColor = true;
            this.deco.Click += new System.EventHandler(this.deco_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(173, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 416);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aJOUTERToolStripMenuItem,
            this.aJOUTERToolStripMenuItem1,
            this.mODIFIERToolStripMenuItem,
            this.mETTREAJOURToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(170, 460);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aJOUTERToolStripMenuItem
            // 
            this.aJOUTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTEETUDIANTToolStripMenuItem,
            this.lISTEPROFESSEURSToolStripMenuItem});
            this.aJOUTERToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.aJOUTERToolStripMenuItem.Name = "aJOUTERToolStripMenuItem";
            this.aJOUTERToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.aJOUTERToolStripMenuItem.Text = "AFFICHER";
            // 
            // lISTEETUDIANTToolStripMenuItem
            // 
            this.lISTEETUDIANTToolStripMenuItem.Name = "lISTEETUDIANTToolStripMenuItem";
            this.lISTEETUDIANTToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.lISTEETUDIANTToolStripMenuItem.Text = "LISTE ETUDIANTS";
            this.lISTEETUDIANTToolStripMenuItem.Click += new System.EventHandler(this.lISTEETUDIANTToolStripMenuItem_Click);
            // 
            // lISTEPROFESSEURSToolStripMenuItem
            // 
            this.lISTEPROFESSEURSToolStripMenuItem.Name = "lISTEPROFESSEURSToolStripMenuItem";
            this.lISTEPROFESSEURSToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.lISTEPROFESSEURSToolStripMenuItem.Text = "LISTE PROFESSEURS";
            this.lISTEPROFESSEURSToolStripMenuItem.Click += new System.EventHandler(this.lISTEPROFESSEURSToolStripMenuItem_Click);
            // 
            // aJOUTERToolStripMenuItem1
            // 
            this.aJOUTERToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANTToolStripMenuItem,
            this.pROFESSEURToolStripMenuItem});
            this.aJOUTERToolStripMenuItem1.Name = "aJOUTERToolStripMenuItem1";
            this.aJOUTERToolStripMenuItem1.Size = new System.Drawing.Size(157, 29);
            this.aJOUTERToolStripMenuItem1.Text = "AJOUTER";
            // 
            // eTUDIANTToolStripMenuItem
            // 
            this.eTUDIANTToolStripMenuItem.Name = "eTUDIANTToolStripMenuItem";
            this.eTUDIANTToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.eTUDIANTToolStripMenuItem.Text = "ETUDIANT";
            // 
            // pROFESSEURToolStripMenuItem
            // 
            this.pROFESSEURToolStripMenuItem.Name = "pROFESSEURToolStripMenuItem";
            this.pROFESSEURToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.pROFESSEURToolStripMenuItem.Text = "PROFESSEUR";
            // 
            // mODIFIERToolStripMenuItem
            // 
            this.mODIFIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANNTToolStripMenuItem,
            this.pROFESSEURToolStripMenuItem1});
            this.mODIFIERToolStripMenuItem.Name = "mODIFIERToolStripMenuItem";
            this.mODIFIERToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.mODIFIERToolStripMenuItem.Text = "MODIFIER";
            // 
            // eTUDIANNTToolStripMenuItem
            // 
            this.eTUDIANNTToolStripMenuItem.Name = "eTUDIANNTToolStripMenuItem";
            this.eTUDIANNTToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.eTUDIANNTToolStripMenuItem.Text = "ETUDIANNT";
            // 
            // pROFESSEURToolStripMenuItem1
            // 
            this.pROFESSEURToolStripMenuItem1.Name = "pROFESSEURToolStripMenuItem1";
            this.pROFESSEURToolStripMenuItem1.Size = new System.Drawing.Size(196, 30);
            this.pROFESSEURToolStripMenuItem1.Text = "PROFESSEUR";
            // 
            // mETTREAJOURToolStripMenuItem
            // 
            this.mETTREAJOURToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANTToolStripMenuItem1,
            this.pROFESSEURToolStripMenuItem2});
            this.mETTREAJOURToolStripMenuItem.Name = "mETTREAJOURToolStripMenuItem";
            this.mETTREAJOURToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.mETTREAJOURToolStripMenuItem.Text = "METTRE A JOUR";
            // 
            // eTUDIANTToolStripMenuItem1
            // 
            this.eTUDIANTToolStripMenuItem1.Name = "eTUDIANTToolStripMenuItem1";
            this.eTUDIANTToolStripMenuItem1.Size = new System.Drawing.Size(196, 30);
            this.eTUDIANTToolStripMenuItem1.Text = "ETUDIANT";
            // 
            // pROFESSEURToolStripMenuItem2
            // 
            this.pROFESSEURToolStripMenuItem2.Name = "pROFESSEURToolStripMenuItem2";
            this.pROFESSEURToolStripMenuItem2.Size = new System.Drawing.Size(196, 30);
            this.pROFESSEURToolStripMenuItem2.Text = "PROFESSEUR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Login";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom et Prenom";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Filiere";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Niveau";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CNE";
            this.Column6.Name = "Column6";
            // 
            // Espace_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.entete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Espace_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace_admin";
            this.Load += new System.EventHandler(this.Espace_admin_Load);
            this.entete.ResumeLayout(false);
            this.entete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel entete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aJOUTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTEETUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTEPROFESSEURSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJOUTERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESSEURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANNTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESSEURToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mETTREAJOURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pROFESSEURToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}