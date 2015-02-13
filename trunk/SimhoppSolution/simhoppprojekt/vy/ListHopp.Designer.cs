namespace simhoppprojekt
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
            this.hoppkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hojd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svarighet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betyg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.simnamn1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.hoppkod,
            this.hojd,
            this.Stile,
            this.svarighet,
            this.betyg,
            this.points});
            this.dataGridView1.Location = new System.Drawing.Point(39, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(475, 236);
            this.dataGridView1.TabIndex = 9;
            // 
            // hoppkod
            // 
            this.hoppkod.FillWeight = 65F;
            this.hoppkod.HeaderText = "Hoppkod";
            this.hoppkod.Name = "hoppkod";
            this.hoppkod.ReadOnly = true;
            this.hoppkod.Width = 65;
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
            // svarighet
            // 
            this.svarighet.FillWeight = 55F;
            this.svarighet.HeaderText = "Svårighetsgrad";
            this.svarighet.Name = "svarighet";
            this.svarighet.ReadOnly = true;
            this.svarighet.Width = 55;
            // 
            // betyg
            // 
            this.betyg.HeaderText = "Betyg";
            this.betyg.Name = "betyg";
            this.betyg.ReadOnly = true;
            // 
            // points
            // 
            this.points.FillWeight = 120F;
            this.points.HeaderText = "Poäng";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Width = 120;
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
            this.button1.Location = new System.Drawing.Point(320, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stäng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(105, 340);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(101, 23);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "Tillåt redigering";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Verkställ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListHopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.redButton);
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
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoppkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn hojd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stile;
        private System.Windows.Forms.DataGridViewTextBoxColumn svarighet;
        private System.Windows.Forms.DataGridViewTextBoxColumn betyg;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
    }
}