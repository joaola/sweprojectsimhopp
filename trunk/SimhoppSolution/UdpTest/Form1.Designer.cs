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
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 114);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SKICKA";
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
            this.UpDown1.Location = new System.Drawing.Point(41, 167);
            this.UpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown1.Name = "UpDown1";
            this.UpDown1.Size = new System.Drawing.Size(56, 20);
            this.UpDown1.TabIndex = 7;
            // 
            // judgebox
            // 
            this.judgebox.BackColor = System.Drawing.SystemColors.Info;
            this.judgebox.Location = new System.Drawing.Point(12, 132);
            this.judgebox.Name = "judgebox";
            this.judgebox.ReadOnly = true;
            this.judgebox.Size = new System.Drawing.Size(85, 20);
            this.judgebox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 230);
            this.Controls.Add(this.judgebox);
            this.Controls.Add(this.UpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Domare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown UpDown1;
        private System.Windows.Forms.TextBox judgebox;
    }
}

