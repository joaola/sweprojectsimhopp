﻿namespace simhoppprojekt
{
    partial class ListHopp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListHopp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.simnamn1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Placering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hojd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antalhopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placering,
            this.hojd,
            this.Stile,
            this.name,
            this.antalhopp,
            this.points});
            this.dataGridView1.Location = new System.Drawing.Point(39, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(475, 236);
            this.dataGridView1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(39, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(106, 13);
            this.textBox3.TabIndex = 11;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Simhopparens namn:";
            // 
            // simnamn1
            // 
            this.simnamn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simnamn1.Location = new System.Drawing.Point(141, 28);
            this.simnamn1.Name = "simnamn1";
            this.simnamn1.ReadOnly = true;
            this.simnamn1.Size = new System.Drawing.Size(100, 13);
            this.simnamn1.TabIndex = 10;
            this.simnamn1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stäng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Placering
            // 
            this.Placering.FillWeight = 65F;
            this.Placering.HeaderText = "Hoppkod";
            this.Placering.Name = "Placering";
            this.Placering.ReadOnly = true;
            this.Placering.Width = 65;
            // 
            // hojd
            // 
            this.hojd.FillWeight = 55F;
            this.hojd.HeaderText = "Höjd";
            this.hojd.Name = "hojd";
            this.hojd.ReadOnly = true;
            this.hojd.Width = 55;
            // 
            // Stile
            // 
            this.Stile.FillWeight = 55F;
            this.Stile.HeaderText = "Stil";
            this.Stile.Name = "Stile";
            this.Stile.ReadOnly = true;
            this.Stile.Width = 55;
            // 
            // name
            // 
            this.name.FillWeight = 55F;
            this.name.HeaderText = "Svårighetsgrad";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 55;
            // 
            // antalhopp
            // 
            this.antalhopp.HeaderText = "Betyg";
            this.antalhopp.Name = "antalhopp";
            this.antalhopp.ReadOnly = true;
            // 
            // points
            // 
            this.points.FillWeight = 120F;
            this.points.HeaderText = "Poäng";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Width = 120;
            // 
            // ListHopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.simnamn1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListHopp";
            this.Text = "Hopplista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox simnamn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placering;
        private System.Windows.Forms.DataGridViewTextBoxColumn hojd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn antalhopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
    }
}