namespace CustWeaps
{
    partial class Shotguns
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Winchester 1897 : 12 Gauge\n",
            "Winchester 1200 : 12 Gauge\n",
            "Stevens 520/620 : 12 Gauge\n",
            "Stevens 77E : 12 Gauge\n",
            "Remington 10 : 12 Gauge\n",
            "Remington 31 : 12 Gauge\n",
            "Remington 870 : 12 Gauge\n",
            "Mossberg 500 : 12 Gauge\n",
            "Beretta 1200FPT : 12 Gauge\n",
            "Ithaca 37 : 12 Gauge\n",
            "PM-5 : 12 Gauge\n",
            "Franchi SPAS 12 : 12 Gauge\n",
            "Franchi SPAS 15 : 12 Gauge\n",
            "Remington 1100 : 12 Gauge\n",
            "Remington 11 : 12 Gauge\n",
            "Auto 5 : 12 Gauge\n",
            "Benelli 121 : 12 Gauge\n",
            "S&W Super 12 : 12 Gauge\n",
            "High Standard 10 : 12 Gauge\n",
            "Armsel Striker : 12 Gauge\n",
            "USAS 12 : 12 Gauge\n"});
            this.comboBox1.Location = new System.Drawing.Point(518, 383);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(644, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1426, 798);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 127);
            this.textBox1.TabIndex = 3;
            // 
            // Shotguns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Shotguns";
            this.Text = "Shotguns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}