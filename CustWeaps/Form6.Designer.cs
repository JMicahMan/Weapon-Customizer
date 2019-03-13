namespace CustWeaps
{
    partial class Form6
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
            this.SavedGun = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SavedGun
            // 
            this.SavedGun.Location = new System.Drawing.Point(313, 165);
            this.SavedGun.Name = "SavedGun";
            this.SavedGun.Size = new System.Drawing.Size(212, 23);
            this.SavedGun.TabIndex = 0;
            this.SavedGun.Text = "Select Ptr-loaded Custom Weapon";
            this.SavedGun.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(713, 415);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.SavedGun);
            this.Name = "Form6";
            this.Text = "Load Weapon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavedGun;
        private System.Windows.Forms.Button Load;
    }
}