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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.poangsumbox = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.ortruta = new System.Windows.Forms.TextBox();
            this.konruta = new System.Windows.Forms.TextBox();
            this.fodeseruta = new System.Windows.Forms.TextBox();
            this.foreningruta = new System.Windows.Forms.TextBox();
            this.IDruta = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.nytthopp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(186, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(503, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // hoppkod
            // 
            this.hoppkod.FillWeight = 65F;
            this.hoppkod.HeaderText = "Hoppkod";
            this.hoppkod.Name = "hoppkod";
            this.hoppkod.ReadOnly = true;
            this.hoppkod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hoppkod.Width = 65;
            // 
            // hojd
            // 
            this.hojd.FillWeight = 55F;
            this.hojd.HeaderText = "Höjd";
            this.hojd.Name = "hojd";
            this.hojd.ReadOnly = true;
            this.hojd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hojd.Width = 55;
            // 
            // Stile
            // 
            this.Stile.FillWeight = 55F;
            this.Stile.HeaderText = "Stil";
            this.Stile.Name = "Stile";
            this.Stile.ReadOnly = true;
            this.Stile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Stile.Width = 55;
            // 
            // svarighet
            // 
            this.svarighet.FillWeight = 55F;
            this.svarighet.HeaderText = "Svårighetsgrad";
            this.svarighet.Name = "svarighet";
            this.svarighet.ReadOnly = true;
            this.svarighet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.svarighet.Width = 80;
            // 
            // betyg
            // 
            this.betyg.HeaderText = "Betyg";
            this.betyg.Name = "betyg";
            this.betyg.ReadOnly = true;
            this.betyg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.betyg.Width = 140;
            // 
            // points
            // 
            this.points.FillWeight = 120F;
            this.points.HeaderText = "Poäng";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.points.Width = 85;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(14, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(34, 13);
            this.textBox3.TabIndex = 11;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Namn:";
            // 
            // simnamn1
            // 
            this.simnamn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simnamn1.Location = new System.Drawing.Point(70, 24);
            this.simnamn1.Name = "simnamn1";
            this.simnamn1.ReadOnly = true;
            this.simnamn1.Size = new System.Drawing.Size(100, 13);
            this.simnamn1.TabIndex = 10;
            this.simnamn1.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(450, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Stäng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(260, 277);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(96, 23);
            this.redButton.TabIndex = 2;
            this.redButton.Text = "&Redigera hopp...";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(500, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 13);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Poängsumma:";
            // 
            // poangsumbox
            // 
            this.poangsumbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poangsumbox.Location = new System.Drawing.Point(589, 283);
            this.poangsumbox.Name = "poangsumbox";
            this.poangsumbox.ReadOnly = true;
            this.poangsumbox.Size = new System.Drawing.Size(100, 13);
            this.poangsumbox.TabIndex = 12;
            this.poangsumbox.TabStop = false;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(362, 277);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(82, 23);
            this.remove.TabIndex = 3;
            this.remove.Text = "Ta &bort hopp";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // ortruta
            // 
            this.ortruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ortruta.Location = new System.Drawing.Point(70, 191);
            this.ortruta.Name = "ortruta";
            this.ortruta.ReadOnly = true;
            this.ortruta.Size = new System.Drawing.Size(100, 13);
            this.ortruta.TabIndex = 34;
            this.ortruta.TabStop = false;
            // 
            // konruta
            // 
            this.konruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konruta.Location = new System.Drawing.Point(70, 156);
            this.konruta.Name = "konruta";
            this.konruta.ReadOnly = true;
            this.konruta.Size = new System.Drawing.Size(100, 13);
            this.konruta.TabIndex = 33;
            this.konruta.TabStop = false;
            // 
            // fodeseruta
            // 
            this.fodeseruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fodeseruta.Location = new System.Drawing.Point(70, 121);
            this.fodeseruta.Name = "fodeseruta";
            this.fodeseruta.ReadOnly = true;
            this.fodeseruta.Size = new System.Drawing.Size(100, 13);
            this.fodeseruta.TabIndex = 32;
            this.fodeseruta.TabStop = false;
            // 
            // foreningruta
            // 
            this.foreningruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foreningruta.Location = new System.Drawing.Point(70, 86);
            this.foreningruta.Name = "foreningruta";
            this.foreningruta.ReadOnly = true;
            this.foreningruta.Size = new System.Drawing.Size(100, 13);
            this.foreningruta.TabIndex = 31;
            this.foreningruta.TabStop = false;
            // 
            // IDruta
            // 
            this.IDruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDruta.Location = new System.Drawing.Point(70, 55);
            this.IDruta.Name = "IDruta";
            this.IDruta.ReadOnly = true;
            this.IDruta.Size = new System.Drawing.Size(100, 13);
            this.IDruta.TabIndex = 30;
            this.IDruta.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(15, 121);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(51, 13);
            this.textBox9.TabIndex = 25;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Födelseår:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(15, 156);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(26, 13);
            this.textBox10.TabIndex = 26;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Kön: ";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(15, 86);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(47, 13);
            this.textBox11.TabIndex = 27;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Förening:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(15, 53);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(20, 13);
            this.textBox12.TabIndex = 28;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "ID:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(15, 191);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(23, 13);
            this.textBox16.TabIndex = 29;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Ort:";
            // 
            // nytthopp
            // 
            this.nytthopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nytthopp.Location = new System.Drawing.Point(186, 277);
            this.nytthopp.Name = "nytthopp";
            this.nytthopp.Size = new System.Drawing.Size(68, 23);
            this.nytthopp.TabIndex = 1;
            this.nytthopp.Text = "&Nytt hopp";
            this.nytthopp.UseVisualStyleBackColor = true;
            this.nytthopp.Click += new System.EventHandler(this.nytthopp_Click);
            // 
            // ListHopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(718, 316);
            this.Controls.Add(this.nytthopp);
            this.Controls.Add(this.ortruta);
            this.Controls.Add(this.konruta);
            this.Controls.Add(this.fodeseruta);
            this.Controls.Add(this.foreningruta);
            this.Controls.Add(this.IDruta);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.poangsumbox);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.simnamn1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ListHopp";
            this.Text = "Personlig information";
            this.Load += new System.EventHandler(this.ListHopp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListHopp_KeyDown);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox poangsumbox;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox ortruta;
        private System.Windows.Forms.TextBox konruta;
        private System.Windows.Forms.TextBox fodeseruta;
        private System.Windows.Forms.TextBox foreningruta;
        private System.Windows.Forms.TextBox IDruta;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button nytthopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoppkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn hojd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stile;
        private System.Windows.Forms.DataGridViewTextBoxColumn svarighet;
        private System.Windows.Forms.DataGridViewTextBoxColumn betyg;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
    }
}