namespace CustWeaps
{
    partial class BaseWeapon
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
            this.components = new System.ComponentModel.Container();
            this.WeaponChoice = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assualtRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMGsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lMGsGPMGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotgunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sniperRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeaponChoice
            // 
            this.WeaponChoice.Location = new System.Drawing.Point(344, 179);
            this.WeaponChoice.Name = "WeaponChoice";
            this.WeaponChoice.Size = new System.Drawing.Size(121, 23);
            this.WeaponChoice.TabIndex = 0;
            this.WeaponChoice.Text = "WeaponChoice";
            this.WeaponChoice.UseVisualStyleBackColor = true;
            this.WeaponChoice.Click += new System.EventHandler(this.WeaponChoice_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(0, 424);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assualtRiflesToolStripMenuItem,
            this.battleRiflesToolStripMenuItem,
            this.sMGsToolStripMenuItem1,
            this.lMGsGPMGsToolStripMenuItem,
            this.shotgunsToolStripMenuItem,
            this.sniperRiflesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 158);
            // 
            // assualtRiflesToolStripMenuItem
            // 
            this.assualtRiflesToolStripMenuItem.Name = "assualtRiflesToolStripMenuItem";
            this.assualtRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assualtRiflesToolStripMenuItem.Text = "Assault Rifles";
            this.assualtRiflesToolStripMenuItem.Click += new System.EventHandler(this.assualtRiflesToolStripMenuItem_Click);
            // 
            // battleRiflesToolStripMenuItem
            // 
            this.battleRiflesToolStripMenuItem.Name = "battleRiflesToolStripMenuItem";
            this.battleRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.battleRiflesToolStripMenuItem.Text = "Battle Rifles";
            this.battleRiflesToolStripMenuItem.Click += new System.EventHandler(this.battleRiflesToolStripMenuItem_Click);
            // 
            // sMGsToolStripMenuItem1
            // 
            this.sMGsToolStripMenuItem1.Name = "sMGsToolStripMenuItem1";
            this.sMGsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sMGsToolStripMenuItem1.Text = "SMGs";
            this.sMGsToolStripMenuItem1.Click += new System.EventHandler(this.sMGsToolStripMenuItem_Click);
            // 
            // lMGsGPMGsToolStripMenuItem
            // 
            this.lMGsGPMGsToolStripMenuItem.Name = "lMGsGPMGsToolStripMenuItem";
            this.lMGsGPMGsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lMGsGPMGsToolStripMenuItem.Text = "LMGs/GPMGs";
            this.lMGsGPMGsToolStripMenuItem.Click += new System.EventHandler(this.lMGsGPMGsToolStripMenuItem_Click);
            // 
            // shotgunsToolStripMenuItem
            // 
            this.shotgunsToolStripMenuItem.Name = "shotgunsToolStripMenuItem";
            this.shotgunsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shotgunsToolStripMenuItem.Text = "Shotguns";
            this.shotgunsToolStripMenuItem.Click += new System.EventHandler(this.shotgunsToolStripMenuItem_Click);
            // 
            // sniperRiflesToolStripMenuItem
            // 
            this.sniperRiflesToolStripMenuItem.Name = "sniperRiflesToolStripMenuItem";
            this.sniperRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sniperRiflesToolStripMenuItem.Text = "Sniper Rifles";
            this.sniperRiflesToolStripMenuItem.Click += new System.EventHandler(this.sniperRiflesToolStripMenuItem_Click);
            // 
            // BaseWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.WeaponChoice);
            this.Name = "BaseWeapon";
            this.Text = "BaseWeapon";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WeaponChoice;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assualtRiflesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleRiflesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMGsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lMGsGPMGsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotgunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sniperRiflesToolStripMenuItem;
    }
}

