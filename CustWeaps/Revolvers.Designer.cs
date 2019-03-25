namespace CustWeaps
{
    partial class Revolvers
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
            "Colt 1917 : .45 ACP",
            "Colt Cobra :  .38 Spc.",
            "Colt Detective Spc. :  .38 Spc.",
            "Colt PPS :  .38 Spc.",
            "Colt Python :  .38 Spc.",
            "Colt Python : .357 Mag.",
            "Colt SAA :  .38 Spc.",
            "Colt SAA : .357 Mag.",
            "Colt SAA : .44 Spc.",
            "Colt SAA : .45 LC",
            "Colt Trooper MKIII :  .38 Spc.",
            "Colt Trooper MKIII : .357 Mag.",
            "Korth Kombat :  .38 Spc.",
            "Korth Kombat : .357 Mag.",
            "Manurhin MR-73 :  .38 Spc.",
            "Manurhin MR-73 : .357 Mag.",
            "Ruger Redhawk :  .38 Spc.",
            "Ruger Redhawk : .357 Mag.",
            "Ruger Redhawk : .44 Mag.",
            "Ruger Redhawk : .44 Spc.",
            "S&W 10 : .38 Spc.",
            "S&W 12 :  .38 Spc.",
            "S&W 1917 : .45 ACP",
            "S&W 27 :  .38 Spc.",
            "S&W 27 : .357 Mag.",
            "S&W 29 : .44 Mag.",
            "S&W 29 : .44 Spc.",
            "S&W 3 : .44 Rus.",
            "S&W 3 : .44 S&W",
            "S&W 3 : .44 Sco.",
            "S&W 3 : .44 Spc.",
            "S&W 3 : .44-40 Win.",
            "S&W 36 :  .38 Spc.",
            "S&W Airweight :  .38 Spc.",
            "S&W Bodyguard :  .38 Spc.",
            "Webley MKII : .45 ACP",
            "Webley MKII : .455 Webley",
            "Webley MKIV : .38 S&W"});
            this.comboBox1.Location = new System.Drawing.Point(259, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 21);
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
            // Revolvers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Revolvers";
            this.Text = "Revolvers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}