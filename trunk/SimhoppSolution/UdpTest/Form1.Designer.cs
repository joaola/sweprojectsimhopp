namespace UdpSend
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpDown1 = new System.Windows.Forms.NumericUpDown();
            this.judgebox = new System.Windows.Forms.TextBox();
            this.ipadrBox = new System.Windows.Forms.TextBox();
            this.de = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innehallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 114);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Skicka";
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
            this.UpDown1.Location = new System.Drawing.Point(159, 211);
            this.UpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown1.Name = "UpDown1";
            this.UpDown1.Size = new System.Drawing.Size(56, 20);
            this.UpDown1.TabIndex = 3;
            // 
            // judgebox
            // 
            this.judgebox.BackColor = System.Drawing.SystemColors.Info;
            this.judgebox.Location = new System.Drawing.Point(22, 211);
            this.judgebox.Name = "judgebox";
            this.judgebox.ReadOnly = true;
            this.judgebox.Size = new System.Drawing.Size(85, 20);
            this.judgebox.TabIndex = 14;
            this.judgebox.TabStop = false;
            // 
            // ipadrBox
            // 
            this.ipadrBox.Location = new System.Drawing.Point(22, 50);
            this.ipadrBox.Name = "ipadrBox";
            this.ipadrBox.Size = new System.Drawing.Size(113, 20);
            this.ipadrBox.TabIndex = 1;
            // 
            // de
            // 
            this.de.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.de.Location = new System.Drawing.Point(22, 33);
            this.de.Name = "de";
            this.de.ReadOnly = true;
            this.de.Size = new System.Drawing.Size(50, 13);
            this.de.TabIndex = 16;
            this.de.TabStop = false;
            this.de.Text = "IP-adress:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(140, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(30, 13);
            this.textBox2.TabIndex = 18;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(140, 50);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 20);
            this.portBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(243, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.innehallToolStripMenuItem,
            this.omToolStripMenuItem});
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjälpToolStripMenuItem.Text = "&Hjälp";
            // 
            // innehallToolStripMenuItem
            // 
            this.innehallToolStripMenuItem.Name = "innehallToolStripMenuItem";
            this.innehallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.innehallToolStripMenuItem.Text = "&Information";
            this.innehallToolStripMenuItem.Click += new System.EventHandler(this.innehallToolStripMenuItem_Click);
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.omToolStripMenuItem.Text = "&Om";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avslutaToolStripMenuItem.Text = "&Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 293);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.de);
            this.Controls.Add(this.ipadrBox);
            this.Controls.Add(this.judgebox);
            this.Controls.Add(this.UpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Domare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown UpDown1;
        private System.Windows.Forms.TextBox judgebox;
        private System.Windows.Forms.TextBox ipadrBox;
        private System.Windows.Forms.TextBox de;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innehallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
    }
}

