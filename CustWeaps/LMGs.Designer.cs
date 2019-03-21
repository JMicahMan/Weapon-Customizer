namespace CustWeaps
{
    partial class LMGs
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
            "M60 : 7.62x51mm\n",
            "PKM : 7.62x54mmR\n",
            "FN MAG : 7.62x51mm\n",
            "FM Minimi : 5.56x45mm\n",
            "KAC LAMG : 7.62x51mm\n",
            "KAC LAMG : 5.56x45mm\n",
            "MAS-AAT : 7.5x54mm\n",
            "MAS-AAT : 7.62x51mm\n",
            "Madsen Saetter : 7.62x51mm\n",
            "Madsen Saetter : .30-06\n",
            "VZ-59 : 7.62x54mmR\n",
            "MG3 : 7.62x51mm\n",
            "RPD : 7.62x39mm\n",
            "Ameli : 5.56x45mm\n",
            "H&K 21 : 7.62x51mm\n",
            "H&K 23 : 5.56x45mm\n",
            "Stoner 63 : 5.56x45mm\n",
            "RPK : 7.62x39mm\n",
            "RPK-74 : 5.45x39mm\n",
            "MG42 : 8x57mm\n",
            "MG34 : 8x57mm\n",
            "BREN : .303\n",
            "BREN : 7.62x51mm\n",
            "BREN : 7.62x54mmR\n",
            "BREN : 7.62x39mm\n",
            "ZB-26 : 8x57mm\n",
            "ZB-26 : 7x57mm\n",
            "ZB-26 : .30-06\n",
            "ZB-26 : 7.62x51mm\n",
            "ZB-26 : 7.62x54mmR\n",
            "ZB-26 : 7.65x53mmR\n",
            "FM-24/29 Chatellerault : 7.5x54mm\n",
            "FM-24/29 Chatellerault : 7.62x51mm\n",
            "BAR : .30-06\n",
            "BAR : 6.5x55mm\n",
            "Mendoza RM-2 : 7x57mm\n",
            "Mendoza RM-2 : .30-06\n",
            "Mendoza RM-2 : 7.62x51mm\n"});
            this.comboBox1.Location = new System.Drawing.Point(492, 375);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(620, 33);
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
            this.textBox1.Location = new System.Drawing.Point(492, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 127);
            this.textBox1.TabIndex = 3;
            // 
            // LMGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LMGs";
            this.Text = "LMGs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}