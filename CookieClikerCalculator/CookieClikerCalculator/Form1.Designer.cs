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
            this.lblBestItem = new System.Windows.Forms.Label();
            this.lbxBestItem = new System.Windows.Forms.ListBox();
            this.lbNameBui = new System.Windows.Forms.Label();
            this.lblCpsBui = new System.Windows.Forms.Label();
            this.lblPriceBui = new System.Windows.Forms.Label();
            this.lblQuantityBui = new System.Windows.Forms.Label();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.lblPriceUp = new System.Windows.Forms.Label();
            this.tCtrlBuiUp.SuspendLayout();
            this.tPageBuilding.SuspendLayout();
            this.tPageUpgrade.SuspendLayout();
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
            this.tPageBuilding.Controls.Add(this.lblQuantityBui);
            this.tPageBuilding.Controls.Add(this.lblPriceBui);
            this.tPageBuilding.Controls.Add(this.lblCpsBui);
            this.tPageBuilding.Controls.Add(this.lbNameBui);
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
            this.tPageUpgrade.AutoScroll = true;
            this.tPageUpgrade.Controls.Add(this.lblPriceUp);
            this.tPageUpgrade.Controls.Add(this.lblNameUp);
            this.tPageUpgrade.Location = new System.Drawing.Point(4, 22);
            this.tPageUpgrade.Name = "tPageUpgrade";
            this.tPageUpgrade.Padding = new System.Windows.Forms.Padding(3);
            this.tPageUpgrade.Size = new System.Drawing.Size(592, 570);
            this.tPageUpgrade.TabIndex = 1;
            this.tPageUpgrade.Text = "Upgrades";
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
            this.lblCps.Location = new System.Drawing.Point(13, 35);
            this.lblCps.Name = "lblCps";
            this.lblCps.Size = new System.Drawing.Size(13, 13);
            this.lblCps.TabIndex = 2;
            this.lblCps.Text = "0";
            // 
            // lblBestItem
            // 
            this.lblBestItem.AutoSize = true;
            this.lblBestItem.Location = new System.Drawing.Point(13, 188);
            this.lblBestItem.Name = "lblBestItem";
            this.lblBestItem.Size = new System.Drawing.Size(56, 13);
            this.lblBestItem.TabIndex = 3;
            this.lblBestItem.Text = "Best Items";
            // 
            // lbxBestItem
            // 
            this.lbxBestItem.FormattingEnabled = true;
            this.lbxBestItem.Location = new System.Drawing.Point(16, 205);
            this.lbxBestItem.Name = "lbxBestItem";
            this.lbxBestItem.Size = new System.Drawing.Size(275, 69);
            this.lbxBestItem.TabIndex = 4;
            // 
            // lbNameBui
            // 
            this.lbNameBui.AutoSize = true;
            this.lbNameBui.Location = new System.Drawing.Point(70, 12);
            this.lbNameBui.Name = "lbNameBui";
            this.lbNameBui.Size = new System.Drawing.Size(35, 13);
            this.lbNameBui.TabIndex = 5;
            this.lbNameBui.Text = "Name";
            // 
            // lblCpsBui
            // 
            this.lblCpsBui.AutoSize = true;
            this.lblCpsBui.Location = new System.Drawing.Point(290, 12);
            this.lblCpsBui.Name = "lblCpsBui";
            this.lblCpsBui.Size = new System.Drawing.Size(25, 13);
            this.lblCpsBui.TabIndex = 6;
            this.lblCpsBui.Text = "Cps";
            // 
            // lblPriceBui
            // 
            this.lblPriceBui.AutoSize = true;
            this.lblPriceBui.Location = new System.Drawing.Point(170, 12);
            this.lblPriceBui.Name = "lblPriceBui";
            this.lblPriceBui.Size = new System.Drawing.Size(31, 13);
            this.lblPriceBui.TabIndex = 7;
            this.lblPriceBui.Text = "Price";
            // 
            // lblQuantityBui
            // 
            this.lblQuantityBui.AutoSize = true;
            this.lblQuantityBui.Location = new System.Drawing.Point(410, 12);
            this.lblQuantityBui.Name = "lblQuantityBui";
            this.lblQuantityBui.Size = new System.Drawing.Size(46, 13);
            this.lblQuantityBui.TabIndex = 8;
            this.lblQuantityBui.Text = "Quantity";
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Location = new System.Drawing.Point(70, 12);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(35, 13);
            this.lblNameUp.TabIndex = 0;
            this.lblNameUp.Text = "Name";
            // 
            // lblPriceUp
            // 
            this.lblPriceUp.AutoSize = true;
            this.lblPriceUp.Location = new System.Drawing.Point(170, 12);
            this.lblPriceUp.Name = "lblPriceUp";
            this.lblPriceUp.Size = new System.Drawing.Size(31, 13);
            this.lblPriceUp.TabIndex = 6;
            this.lblPriceUp.Text = "Price";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 598);
            this.Controls.Add(this.lbxBestItem);
            this.Controls.Add(this.lblBestItem);
            this.Controls.Add(this.lblCps);
            this.Controls.Add(this.lblCurrentCps);
            this.Controls.Add(this.tCtrlBuiUp);
            this.MaximumSize = new System.Drawing.Size(915, 636);
            this.MinimumSize = new System.Drawing.Size(915, 636);
            this.Name = "frmMain";
            this.Text = "Cookie Clicker Calculator";
            this.tCtrlBuiUp.ResumeLayout(false);
            this.tPageBuilding.ResumeLayout(false);
            this.tPageBuilding.PerformLayout();
            this.tPageUpgrade.ResumeLayout(false);
            this.tPageUpgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tCtrlBuiUp;
        private System.Windows.Forms.TabPage tPageBuilding;
        private System.Windows.Forms.TabPage tPageUpgrade;
        private System.Windows.Forms.Label lblCurrentCps;
        private System.Windows.Forms.Label lblCps;
        private System.Windows.Forms.Label lblBestItem;
        private System.Windows.Forms.ListBox lbxBestItem;
        private System.Windows.Forms.Label lblQuantityBui;
        private System.Windows.Forms.Label lblPriceBui;
        private System.Windows.Forms.Label lblCpsBui;
        private System.Windows.Forms.Label lbNameBui;
        private System.Windows.Forms.Label lblPriceUp;
        private System.Windows.Forms.Label lblNameUp;
    }
}

