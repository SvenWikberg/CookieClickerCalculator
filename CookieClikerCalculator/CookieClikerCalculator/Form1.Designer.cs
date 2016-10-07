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
            this.lstViewBuildings = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buildingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.basePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbxBuildings = new System.Windows.Forms.ListBox();
            this.tPageUpgrade = new System.Windows.Forms.TabPage();
            this.baseCps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tCtrlBuiUp.SuspendLayout();
            this.tPageBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCtrlBuiUp
            // 
            this.tCtrlBuiUp.Controls.Add(this.tPageBuilding);
            this.tCtrlBuiUp.Controls.Add(this.tPageUpgrade);
            this.tCtrlBuiUp.Location = new System.Drawing.Point(299, 0);
            this.tCtrlBuiUp.Name = "tCtrlBuiUp";
            this.tCtrlBuiUp.SelectedIndex = 0;
            this.tCtrlBuiUp.Size = new System.Drawing.Size(600, 549);
            this.tCtrlBuiUp.TabIndex = 0;
            // 
            // tPageBuilding
            // 
            this.tPageBuilding.Controls.Add(this.lstViewBuildings);
            this.tPageBuilding.Controls.Add(this.lbxBuildings);
            this.tPageBuilding.Location = new System.Drawing.Point(4, 22);
            this.tPageBuilding.Name = "tPageBuilding";
            this.tPageBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tPageBuilding.Size = new System.Drawing.Size(592, 523);
            this.tPageBuilding.TabIndex = 0;
            this.tPageBuilding.Text = "Buildings";
            this.tPageBuilding.UseVisualStyleBackColor = true;
            // 
            // lstViewBuildings
            // 
            this.lstViewBuildings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.buildingName,
            this.basePrice,
            this.baseCps});
            this.lstViewBuildings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewBuildings.FullRowSelect = true;
            this.lstViewBuildings.GridLines = true;
            this.lstViewBuildings.Location = new System.Drawing.Point(3, 3);
            this.lstViewBuildings.Name = "lstViewBuildings";
            this.lstViewBuildings.Size = new System.Drawing.Size(586, 517);
            this.lstViewBuildings.TabIndex = 1;
            this.lstViewBuildings.TileSize = new System.Drawing.Size(10, 10);
            this.lstViewBuildings.UseCompatibleStateImageBehavior = false;
            this.lstViewBuildings.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // buildingName
            // 
            this.buildingName.Text = "Name";
            this.buildingName.Width = 148;
            // 
            // basePrice
            // 
            this.basePrice.Text = "Prix de base";
            this.basePrice.Width = 178;
            // 
            // lbxBuildings
            // 
            this.lbxBuildings.FormattingEnabled = true;
            this.lbxBuildings.Location = new System.Drawing.Point(6, 6);
            this.lbxBuildings.Name = "lbxBuildings";
            this.lbxBuildings.Size = new System.Drawing.Size(580, 511);
            this.lbxBuildings.TabIndex = 0;
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
            // baseCps
            // 
            this.baseCps.Text = "Cps de base";
            this.baseCps.Width = 196;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 550);
            this.Controls.Add(this.tCtrlBuiUp);
            this.Name = "frmMain";
            this.Text = "Cookie Clicker Calculator";
            this.tCtrlBuiUp.ResumeLayout(false);
            this.tPageBuilding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCtrlBuiUp;
        private System.Windows.Forms.TabPage tPageBuilding;
        private System.Windows.Forms.TabPage tPageUpgrade;
        private System.Windows.Forms.ListBox lbxBuildings;
        private System.Windows.Forms.ListView lstViewBuildings;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader buildingName;
        private System.Windows.Forms.ColumnHeader basePrice;
        private System.Windows.Forms.ColumnHeader baseCps;
    }
}

