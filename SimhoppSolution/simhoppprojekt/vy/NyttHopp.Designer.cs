﻿namespace simhoppprojekt
{
    partial class NyttHopp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyttHopp));
            this.antalDomare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.antaldomdrop = new System.Windows.Forms.ComboBox();
            this.simnamn = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UpDown2 = new System.Windows.Forms.NumericUpDown();
            this.UpDown3 = new System.Windows.Forms.NumericUpDown();
            this.UpDown4 = new System.Windows.Forms.NumericUpDown();
            this.UpDown5 = new System.Windows.Forms.NumericUpDown();
            this.UpDown6 = new System.Windows.Forms.NumericUpDown();
            this.UpDown7 = new System.Windows.Forms.NumericUpDown();
            this.de = new System.Windows.Forms.TextBox();
            this.domare1 = new System.Windows.Forms.TextBox();
            this.domare2 = new System.Windows.Forms.TextBox();
            this.domare3 = new System.Windows.Forms.TextBox();
            this.domare4 = new System.Windows.Forms.TextBox();
            this.domare5 = new System.Windows.Forms.TextBox();
            this.domare6 = new System.Windows.Forms.TextBox();
            this.domare7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.svarighetsbox = new System.Windows.Forms.TextBox();
            this.poangbox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.stilDrop = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hojddrop = new System.Windows.Forms.ComboBox();
            this.HoppkodBox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.UdpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // antalDomare
            // 
            this.antalDomare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.antalDomare.Location = new System.Drawing.Point(24, 144);
            this.antalDomare.Name = "antalDomare";
            this.antalDomare.ReadOnly = true;
            this.antalDomare.Size = new System.Drawing.Size(78, 13);
            this.antalDomare.TabIndex = 0;
            this.antalDomare.TabStop = false;
            this.antalDomare.Text = "Antal domare:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpDown1
            // 
            this.UpDown1.DecimalPlaces = 1;
            this.UpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown1.Location = new System.Drawing.Point(85, 170);
            this.UpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown1.Name = "UpDown1";
            this.UpDown1.Size = new System.Drawing.Size(56, 20);
            this.UpDown1.TabIndex = 6;
            this.UpDown1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Räkna";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // antaldomdrop
            // 
            this.antaldomdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antaldomdrop.FormattingEnabled = true;
            this.antaldomdrop.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.antaldomdrop.Location = new System.Drawing.Point(102, 141);
            this.antaldomdrop.Name = "antaldomdrop";
            this.antaldomdrop.Size = new System.Drawing.Size(38, 21);
            this.antaldomdrop.TabIndex = 5;
            this.antaldomdrop.Tag = "";
            this.antaldomdrop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // simnamn
            // 
            this.simnamn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simnamn.Location = new System.Drawing.Point(128, 14);
            this.simnamn.Name = "simnamn";
            this.simnamn.ReadOnly = true;
            this.simnamn.Size = new System.Drawing.Size(100, 13);
            this.simnamn.TabIndex = 6;
            this.simnamn.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(24, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(99, 13);
            this.textBox3.TabIndex = 7;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Simhopparens namn:";
            // 
            // UpDown2
            // 
            this.UpDown2.DecimalPlaces = 1;
            this.UpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown2.Location = new System.Drawing.Point(85, 196);
            this.UpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown2.Name = "UpDown2";
            this.UpDown2.Size = new System.Drawing.Size(56, 20);
            this.UpDown2.TabIndex = 7;
            this.UpDown2.Visible = false;
            // 
            // UpDown3
            // 
            this.UpDown3.DecimalPlaces = 1;
            this.UpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown3.Location = new System.Drawing.Point(85, 222);
            this.UpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown3.Name = "UpDown3";
            this.UpDown3.Size = new System.Drawing.Size(56, 20);
            this.UpDown3.TabIndex = 8;
            this.UpDown3.Visible = false;
            // 
            // UpDown4
            // 
            this.UpDown4.DecimalPlaces = 1;
            this.UpDown4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown4.Location = new System.Drawing.Point(85, 248);
            this.UpDown4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown4.Name = "UpDown4";
            this.UpDown4.Size = new System.Drawing.Size(56, 20);
            this.UpDown4.TabIndex = 9;
            this.UpDown4.Visible = false;
            // 
            // UpDown5
            // 
            this.UpDown5.DecimalPlaces = 1;
            this.UpDown5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown5.Location = new System.Drawing.Point(85, 274);
            this.UpDown5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown5.Name = "UpDown5";
            this.UpDown5.Size = new System.Drawing.Size(56, 20);
            this.UpDown5.TabIndex = 10;
            this.UpDown5.Visible = false;
            // 
            // UpDown6
            // 
            this.UpDown6.DecimalPlaces = 1;
            this.UpDown6.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown6.Location = new System.Drawing.Point(85, 300);
            this.UpDown6.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown6.Name = "UpDown6";
            this.UpDown6.Size = new System.Drawing.Size(56, 20);
            this.UpDown6.TabIndex = 11;
            this.UpDown6.Visible = false;
            // 
            // UpDown7
            // 
            this.UpDown7.DecimalPlaces = 1;
            this.UpDown7.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpDown7.Location = new System.Drawing.Point(85, 326);
            this.UpDown7.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown7.Name = "UpDown7";
            this.UpDown7.Size = new System.Drawing.Size(56, 20);
            this.UpDown7.TabIndex = 12;
            this.UpDown7.Visible = false;
            // 
            // de
            // 
            this.de.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.de.Location = new System.Drawing.Point(24, 38);
            this.de.Name = "de";
            this.de.ReadOnly = true;
            this.de.Size = new System.Drawing.Size(50, 13);
            this.de.TabIndex = 15;
            this.de.TabStop = false;
            this.de.Text = "Hoppkod:";
            // 
            // domare1
            // 
            this.domare1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare1.Location = new System.Drawing.Point(24, 175);
            this.domare1.Name = "domare1";
            this.domare1.ReadOnly = true;
            this.domare1.Size = new System.Drawing.Size(55, 13);
            this.domare1.TabIndex = 0;
            this.domare1.TabStop = false;
            this.domare1.Text = "Domare 1:";
            this.domare1.Visible = false;
            // 
            // domare2
            // 
            this.domare2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare2.Location = new System.Drawing.Point(24, 201);
            this.domare2.Name = "domare2";
            this.domare2.ReadOnly = true;
            this.domare2.Size = new System.Drawing.Size(55, 13);
            this.domare2.TabIndex = 0;
            this.domare2.TabStop = false;
            this.domare2.Text = "Domare 2:";
            this.domare2.Visible = false;
            // 
            // domare3
            // 
            this.domare3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare3.Location = new System.Drawing.Point(25, 227);
            this.domare3.Name = "domare3";
            this.domare3.ReadOnly = true;
            this.domare3.Size = new System.Drawing.Size(55, 13);
            this.domare3.TabIndex = 0;
            this.domare3.TabStop = false;
            this.domare3.Text = "Domare 3:";
            this.domare3.Visible = false;
            // 
            // domare4
            // 
            this.domare4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare4.Location = new System.Drawing.Point(24, 253);
            this.domare4.Name = "domare4";
            this.domare4.ReadOnly = true;
            this.domare4.Size = new System.Drawing.Size(55, 13);
            this.domare4.TabIndex = 0;
            this.domare4.TabStop = false;
            this.domare4.Text = "Domare 4:";
            this.domare4.Visible = false;
            // 
            // domare5
            // 
            this.domare5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare5.Location = new System.Drawing.Point(25, 279);
            this.domare5.Name = "domare5";
            this.domare5.ReadOnly = true;
            this.domare5.Size = new System.Drawing.Size(55, 13);
            this.domare5.TabIndex = 0;
            this.domare5.TabStop = false;
            this.domare5.Text = "Domare 5:";
            this.domare5.Visible = false;
            // 
            // domare6
            // 
            this.domare6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare6.Location = new System.Drawing.Point(25, 305);
            this.domare6.Name = "domare6";
            this.domare6.ReadOnly = true;
            this.domare6.Size = new System.Drawing.Size(55, 13);
            this.domare6.TabIndex = 0;
            this.domare6.TabStop = false;
            this.domare6.Text = "Domare 6:";
            this.domare6.Visible = false;
            // 
            // domare7
            // 
            this.domare7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domare7.Location = new System.Drawing.Point(25, 331);
            this.domare7.Name = "domare7";
            this.domare7.ReadOnly = true;
            this.domare7.Size = new System.Drawing.Size(55, 13);
            this.domare7.TabIndex = 0;
            this.domare7.TabStop = false;
            this.domare7.Text = "Domare 7:";
            this.domare7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(25, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(78, 13);
            this.textBox1.TabIndex = 23;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Svårighetsgrad:";
            // 
            // svarighetsbox
            // 
            this.svarighetsbox.Location = new System.Drawing.Point(100, 60);
            this.svarighetsbox.Name = "svarighetsbox";
            this.svarighetsbox.Size = new System.Drawing.Size(44, 20);
            this.svarighetsbox.TabIndex = 2;
            // 
            // poangbox
            // 
            this.poangbox.BackColor = System.Drawing.SystemColors.Info;
            this.poangbox.Location = new System.Drawing.Point(202, 217);
            this.poangbox.Name = "poangbox";
            this.poangbox.ReadOnly = true;
            this.poangbox.Size = new System.Drawing.Size(109, 20);
            this.poangbox.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(24, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(43, 13);
            this.textBox6.TabIndex = 25;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Höjd (m):";
            // 
            // stilDrop
            // 
            this.stilDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stilDrop.FormattingEnabled = true;
            this.stilDrop.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.stilDrop.Location = new System.Drawing.Point(102, 115);
            this.stilDrop.Name = "stilDrop";
            this.stilDrop.Size = new System.Drawing.Size(38, 21);
            this.stilDrop.TabIndex = 4;
            this.stilDrop.Tag = "";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(24, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(25, 13);
            this.textBox5.TabIndex = 26;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Stil:";
            // 
            // hojddrop
            // 
            this.hojddrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hojddrop.FormattingEnabled = true;
            this.hojddrop.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "10"});
            this.hojddrop.Location = new System.Drawing.Point(102, 89);
            this.hojddrop.Name = "hojddrop";
            this.hojddrop.Size = new System.Drawing.Size(38, 21);
            this.hojddrop.TabIndex = 3;
            this.hojddrop.Tag = "";
            // 
            // HoppkodBox
            // 
            this.HoppkodBox.Location = new System.Drawing.Point(100, 35);
            this.HoppkodBox.Name = "HoppkodBox";
            this.HoppkodBox.Size = new System.Drawing.Size(44, 20);
            this.HoppkodBox.TabIndex = 1;
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(202, 373);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 16;
            this.cancelbutton.Text = "Avbryt";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // UdpButton
            // 
            this.UdpButton.Location = new System.Drawing.Point(202, 305);
            this.UdpButton.Name = "UdpButton";
            this.UdpButton.Size = new System.Drawing.Size(75, 23);
            this.UdpButton.TabIndex = 28;
            this.UdpButton.Text = "Begär betyg";
            this.UdpButton.UseVisualStyleBackColor = true;
            this.UdpButton.Click += new System.EventHandler(this.UdpButton_Click);
            // 
            // NyttHopp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbutton;
            this.ClientSize = new System.Drawing.Size(366, 419);
            this.Controls.Add(this.UdpButton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.HoppkodBox);
            this.Controls.Add(this.hojddrop);
            this.Controls.Add(this.stilDrop);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.poangbox);
            this.Controls.Add(this.svarighetsbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.domare7);
            this.Controls.Add(this.domare6);
            this.Controls.Add(this.domare5);
            this.Controls.Add(this.domare4);
            this.Controls.Add(this.domare3);
            this.Controls.Add(this.domare2);
            this.Controls.Add(this.domare1);
            this.Controls.Add(this.de);
            this.Controls.Add(this.UpDown7);
            this.Controls.Add(this.UpDown6);
            this.Controls.Add(this.UpDown5);
            this.Controls.Add(this.UpDown4);
            this.Controls.Add(this.UpDown3);
            this.Controls.Add(this.UpDown2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.simnamn);
            this.Controls.Add(this.antaldomdrop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.antalDomare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NyttHopp";
            this.Text = "Nytt hopp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NyttHopp_FormClosing);
            this.Load += new System.EventHandler(this.NyttHopp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox antalDomare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown UpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox antaldomdrop;
        private System.Windows.Forms.TextBox simnamn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown UpDown2;
        private System.Windows.Forms.NumericUpDown UpDown3;
        private System.Windows.Forms.NumericUpDown UpDown4;
        private System.Windows.Forms.NumericUpDown UpDown5;
        private System.Windows.Forms.NumericUpDown UpDown6;
        private System.Windows.Forms.NumericUpDown UpDown7;
        private System.Windows.Forms.TextBox de;
        private System.Windows.Forms.TextBox domare1;
        private System.Windows.Forms.TextBox domare2;
        private System.Windows.Forms.TextBox domare3;
        private System.Windows.Forms.TextBox domare4;
        private System.Windows.Forms.TextBox domare5;
        private System.Windows.Forms.TextBox domare6;
        private System.Windows.Forms.TextBox domare7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox svarighetsbox;
        private System.Windows.Forms.TextBox poangbox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox stilDrop;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox hojddrop;
        private System.Windows.Forms.TextBox HoppkodBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button UdpButton;
    }
}