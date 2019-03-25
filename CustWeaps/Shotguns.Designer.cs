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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Armsel Striker : 12 Gauge",
            "Auto 5 : 12 Gauge",
            "Benelli 121 : 12 Gauge",
            "Beretta 1200FPT : 12 Gauge",
            "Franchi SPAS 12 : 12 Gauge",
            "Franchi SPAS 15 : 12 Gauge",
            "High Standard 10 : 12 Gauge",
            "Ithaca 37 : 12 Gauge",
            "Mossberg 500 : 12 Gauge",
            "PM-5 : 12 Gauge",
            "Remington 10 : 12 Gauge",
            "Remington 11 : 12 Gauge",
            "Remington 1100 : 12 Gauge",
            "Remington 31 : 12 Gauge",
            "Remington 870 : 12 Gauge",
            "S&W Super 12 : 12 Gauge",
            "Stevens 520/620 : 12 Gauge",
            "Stevens 77E : 12 Gauge",
            "USAS 12 : 12 Gauge",
            "Winchester 1200 : 12 Gauge",
            "Winchester 1897 : 12 Gauge"});
            this.comboBox1.Location = new System.Drawing.Point(259, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shotguns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Shotguns";
            this.Text = "Shotguns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}