﻿namespace CustWeaps
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
            "1891/38 Carcano : 6.5x52mm",
            "1941 Johnson : .30-06",
            "AG/42 : 6.5x55mm",
            "AG/42 : 8x57mm",
            "AR-10 : 7.62x51mm",
            "BM-59 : 7.62x51mm",
            "FAL : 7.62x51mm",
            "FN 49 : .30-06",
            "FN 49 : 7.62x51mm",
            "FN 49 : 7x57mm",
            "FN 49 : 8x57mm",
            "FN M1935 : 7.65x53mmR",
            "FN49 : 7.65x53mmR",
            "FR-3 : 7.62x51mm",
            "FR-3 : 7x57mm",
            "FR-3 : 8x57mm",
            "G3 : 7.62x51mm",
            "G43 : 8x57mm",
            "Galil SAR : 7.62x51mm",
            "K31 : 7.5x55mm",
            "LAR : 7.62x51mm",
            "Lee Enfield No. 4 : .303",
            "Lee Enfield No. 4 : 7.62x51mm",
            "LF-59 : 7.62x51mm",
            "M1 Garand : .30-06",
            "M14 : 7.62x51mm",
            "M1894 : 6.5x55mm",
            "M1917 : .30-06",
            "M38 Carcano : 7.35x51mm",
            "Madsen M47 : .30-06",
            "Madsen M47 : 7.62x51mm",
            "Madsen M47 : 7x57mm",
            "MAS-36 : 7.5x54mm",
            "MAS-49 : 7.5x54mm",
            "MAS-49 : 7.62x51mm",
            "Mauser 98k : .30-06",
            "Mauser 98k : 7.62x51mm",
            "Mauser 98k : 7x57mm",
            "Mauser 98k : 8x57mm",
            "Mosin-Nagant M44 : 7.62x54mmR",
            "P14 : .303",
            "PSL : 7.62x51mm",
            "PSL : 7.62x54mmR",
            "SG 510 : 7.5x55mm",
            "SG 510 : 7.62x51mm",
            "SG 542 : 7.62x51mm",
            "Springfield M1903 : .30-06",
            "SVT-40 : 7.62x54mmR",
            "Type 44 Arisaka : 6.5x50mmSR",
            "Type 99 Arisaka : 7.7x58mm"});
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