namespace CustWeaps
{
    partial class BattleRifles
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
            "FAL : 7.62x51mm\n",
            "G3 : 7.62x51mm\n",
            "M14 : 7.62x51mm\n",
            "AR-10 : 7.62x51mm\n",
            "LAR : 7.62x51mm\n",
            "BM-59 : 7.62x51mm\n",
            "Galil SAR : 7.62x51mm\n",
            "SG 542 : 7.62x51mm\n",
            "LF-59 : 7.62x51mm\n",
            "FN 49 : 7.62x51mm\n",
            "FN 49 : .30-06\n",
            "FN 49 : 7x57mm\n",
            "FN 49 : 8x57mm\n",
            "FN49 : 7.65x53mmR\n",
            "MAS-49 : 7.5x54mm\n",
            "MAS-49 : 7.62x51mm\n",
            "PSL : 7.62x54mmR\n",
            "PSL : 7.62x51mm\n",
            "SG 510 : 7.5x55mm\n",
            "SG 510 : 7.62x51mm\n",
            "AG/42 : 6.5x55mm\n",
            "AG/42 : 8x57mm\n",
            "M1 Garand : .30-06\n",
            "1941 Johnson : .30-06\n",
            "SVT-40 : 7.62x54mmR\n",
            "G43 : 8x57mm\n",
            "Mauser 98k : 8x57mm\n",
            "Mauser 98k : 7x57mm\n",
            "Mauser 98k : .30-06\n",
            "Mauser 98k : 7.62x51mm\n",
            "Mosin-Nagant M44 : 7.62x54mmR\n",
            "Madsen M47 : .30-06\n",
            "Madsen M47 : 7.62x51mm\n",
            "Madsen M47 : 7x57mm\n",
            "Lee Enfield No. 4 : .303\n",
            "Lee Enfield No. 4 : 7.62x51mm\n",
            "P14 : .303\n",
            "MAS-36 : 7.5x54mm\n",
            "K31 : 7.5x55mm\n",
            "Type 44 Arisaka : 6.5x50mmSR\n",
            "Type 99 Arisaka : 7.7x58mm\n",
            "Springfield M1903 : .30-06\n",
            "M1917 : .30-06\n",
            "M1894 : 6.5x55mm\n",
            "1891/38 Carcano : 6.5x52mm\n",
            "M38 Carcano : 7.35x51mm\n",
            "FR-3 : 7.62x51mm\n",
            "FR-3 : 7x57mm\n",
            "FR-3 : 8x57mm\n",
            "FN M1935 : 7.65x53mmR\n"});
            this.comboBox1.Location = new System.Drawing.Point(247, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
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
            // BattleRifles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "BattleRifles";
            this.Text = "BattleRifles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}