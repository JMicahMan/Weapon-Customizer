namespace CustWeaps
{
    partial class AssualtRifles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M16 : 5.56x45mm\n",
            "AKM : 7.62x39mm\n",
            "SKS : 7.62x39mm\n",
            "Mini-14 : 5.56x45mm\n",
            "H&K 33 : 5.56x45mm\n",
            "H&K 32 : 7.62x39mm\n",
            "Galil : 5.56x45mm\n",
            "CAR-15 : 5.56x45mm\n",
            "AUG : 5.56x45mm\n",
            "FNC : 5.56x45mm\n",
            "AK-74 : 5.45x39mm\n",
            "AKS : 7.62x39mm\n",
            "AKS-74U : 5.45x39mm\n",
            "VZ-58 : 7.62x39mm\n",
            "T65 : 5.56x45mm\n",
            "IMBEL MD : 5.56x45mm\n",
            "SG 540 : 5.56x45mm\n",
            "SG 540 : 5.6x45mm GP90\n",
            "AR-70 : 5.56x45mm\n",
            "AR-180 : 5.56x45mm\n",
            "M17S : 5.56x45mm\n",
            "K1 : 5.56x45mm\n",
            "K2 : 5.56x45mm\n",
            "M76 : 5.56x45mm\n",
            "M76: 7.62x39mm\n",
            "LAR : 7.62x39mm\n",
            "C7 : 5.56x45mm\n",
            "Model L : 5.56x45mm\n",
            "Stoner 63 : 5.56x45mm\n",
            "AMD-65 : 7.62x39mm\n",
            "MAS-223 : 5.56x45mm\n",
            "Rasheed : 7.62x39mm\n",
            "VZ-52 : 7.62x39mm\n",
            "CAL : 5.56x45mm\n",
            "Franchi 641 : 5.56x45mm\n",
            "STG 44 : 8x33mm\n",
            "STG 45 : 8x33mm\n"});
            this.comboBox1.Location = new System.Drawing.Point(255, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssualtRifles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AssualtRifles";
            this.Text = "AssualtRifles";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button1;
    }
}