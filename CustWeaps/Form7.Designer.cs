namespace CustWeaps
{
    partial class Form7
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

      
        private void InitializeComponent()
        {
            this.Save = new System.Windows.Forms.Button();
            this.GunSaved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(713, 415);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GunSaved
            // 
            this.GunSaved.Location = new System.Drawing.Point(277, 184);
            this.GunSaved.Name = "GunSaved";
            this.GunSaved.Size = new System.Drawing.Size(343, 23);
            this.GunSaved.TabIndex = 3;
            this.GunSaved.Text = "Enter Weapon Name";
            this.GunSaved.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GunSaved);
            this.Controls.Add(this.Save);
            this.Name = "Form7";
            this.Text = "Weapon Info";
            this.ResumeLayout(false);

        }

        #endregion

     private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button GunSaved;
    }

}
