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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M60 : 7.62x51mm",
            "PKM : 7.62x54mmR",
            "FN MAG : 7.62x51mm",
            "FM Minimi : 5.56x45mm",
            "KAC LAMG : 7.62x51mm",
            "KAC LAMG : 5.56x45mm",
            "MAS-AAT : 7.5x54mm",
            "MAS-AAT : 7.62x51mm",
            "Madsen Saetter : 7.62x51mm",
            "Madsen Saetter : .30-06",
            "VZ-59 : 7.62x54mmR",
            "MG3 : 7.62x51mm",
            "RPD : 7.62x39mm",
            "Ameli : 5.56x45mm",
            "H&K 21 : 7.62x51mm",
            "H&K 23 : 5.56x45mm",
            "Stoner 63 : 5.56x45mm",
            "RPK : 7.62x39mm",
            "RPK-74 : 5.45x39mm",
            "MG42 : 8x57mm",
            "MG34 : 8x57mm",
            "BREN : .303",
            "BREN : 7.62x51mm",
            "BREN : 7.62x54mmR",
            "BREN : 7.62x39mm",
            "ZB-26 : 8x57mm",
            "ZB-26 : 7x57mm",
            "ZB-26 : .30-06",
            "ZB-26 : 7.62x51mm",
            "ZB-26 : 7.62x54mmR",
            "ZB-26 : 7.65x53mmR",
            "FM-24/29 Chatellerault : 7.5x54mm",
            "FM-24/29 Chatellerault : 7.62x51mm",
            "BAR : .30-06",
            "BAR : 6.5x55mm",
            "Mendoza RM-2 : 7x57mm",
            "Mendoza RM-2 : .30-06",
            "Mendoza RM-2 : 7.62x51mm"});
            this.comboBox1.Location = new System.Drawing.Point(246, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 21);
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
            // LMGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "LMGs";
            this.Text = "LMGs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}