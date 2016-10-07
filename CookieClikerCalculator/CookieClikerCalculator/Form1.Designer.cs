namespace CookieClikerCalculator
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCtrlBuiUp = new System.Windows.Forms.TabControl();
            this.tPageBuilding = new System.Windows.Forms.TabPage();
            this.tPageUpgrade = new System.Windows.Forms.TabPage();
            this.lblCurrentCps = new System.Windows.Forms.Label();
            this.lblCps = new System.Windows.Forms.Label();
            this.tCtrlBuiUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCtrlBuiUp
            // 
            this.tCtrlBuiUp.Controls.Add(this.tPageBuilding);
            this.tCtrlBuiUp.Controls.Add(this.tPageUpgrade);
            this.tCtrlBuiUp.Location = new System.Drawing.Point(297, 1);
            this.tCtrlBuiUp.Name = "tCtrlBuiUp";
            this.tCtrlBuiUp.SelectedIndex = 0;
            this.tCtrlBuiUp.Size = new System.Drawing.Size(600, 596);
            this.tCtrlBuiUp.TabIndex = 0;
            // 
            // tPageBuilding
            // 
            this.tPageBuilding.AutoScroll = true;
            this.tPageBuilding.Location = new System.Drawing.Point(4, 22);
            this.tPageBuilding.Name = "tPageBuilding";
            this.tPageBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tPageBuilding.Size = new System.Drawing.Size(592, 570);
            this.tPageBuilding.TabIndex = 0;
            this.tPageBuilding.Text = "Buildings";
            this.tPageBuilding.UseVisualStyleBackColor = true;
            // 
            // tPageUpgrade
            // 
            this.tPageUpgrade.Location = new System.Drawing.Point(4, 22);
            this.tPageUpgrade.Name = "tPageUpgrade";
            this.tPageUpgrade.Padding = new System.Windows.Forms.Padding(3);
            this.tPageUpgrade.Size = new System.Drawing.Size(592, 523);
            this.tPageUpgrade.TabIndex = 1;
            this.tPageUpgrade.Text = "tabPage2";
            this.tPageUpgrade.UseVisualStyleBackColor = true;
            // 
            // lblCurrentCps
            // 
            this.lblCurrentCps.AutoSize = true;
            this.lblCurrentCps.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentCps.Name = "lblCurrentCps";
            this.lblCurrentCps.Size = new System.Drawing.Size(62, 13);
            this.lblCurrentCps.TabIndex = 1;
            this.lblCurrentCps.Text = "Current Cps";
            // 
            // lblCps
            // 
            this.lblCps.AutoSize = true;
            this.lblCps.Location = new System.Drawing.Point(13, 30);
            this.lblCps.Name = "lblCps";
            this.lblCps.Size = new System.Drawing.Size(13, 13);
            this.lblCps.TabIndex = 2;
            this.lblCps.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 598);
            this.Controls.Add(this.lblCps);
            this.Controls.Add(this.lblCurrentCps);
            this.Controls.Add(this.tCtrlBuiUp);
            this.Name = "frmMain";
            this.Text = "Cookie Clicker Calculator";
            this.tCtrlBuiUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tCtrlBuiUp;
        private System.Windows.Forms.TabPage tPageBuilding;
        private System.Windows.Forms.TabPage tPageUpgrade;
        private System.Windows.Forms.Label lblCurrentCps;
        private System.Windows.Forms.Label lblCps;
    }
}

