using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace CookieClikerCalculator
{
    public partial class frmMain : Form
    {
        List<BuildingsControl> lstBuiCtrl;
        List<UpgradesControl> lstUpCtrl;
        List<Upgrades> lstUpgrade;
        List<Buildings> lstBuilding;
        MyConnection connection;

        double cps;

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;

            connection = new MyConnection();

            lstBuilding = new List<Buildings>(connection.GetBuildings);
            lstBuiCtrl = new List<BuildingsControl>();

            lstUpgrade = new List<Upgrades>(connection.GetUpgrades);
            lstUpCtrl = new List<UpgradesControl>();

            for (int i = 0; i < lstBuilding.Count; i++)
            {
                lstBuiCtrl.Add(new BuildingsControl(tPageBuilding, new Point(20, i * 40 + 40), lstBuilding[i].Name, Math.Pow(10, lstBuilding[i].BasePricePuissance10) * lstBuilding[i].BasePrice, Math.Pow(10, lstBuilding[i].BaseCpsPuissance10) * lstBuilding[i].BaseCps, new Bitmap(Image.FromFile("img/buildings/" + lstBuilding[i].ImgFileName))));
                lstBuiCtrl[i].drawBuildingsControl();
                lstBuiCtrl[i].NudCount.ValueChanged += BuiCtrlNud_ValueChanged;
            }

            for (int i = 0; i < lstUpgrade.Count; i++)
            {
                lstUpCtrl.Add(new UpgradesControl(tPageUpgrade, new Point(20, i * 40 + 40), lstUpgrade[i].Name, Math.Pow(10, lstUpgrade[i].BasePricePuissance10) * lstUpgrade[i].BasePrice, new Bitmap(Image.FromFile("img/upgrades/" + lstUpgrade[i].ImgFileName)), lstUpgrade[i]));
                lstUpCtrl[i].drawUpgradesControl();
                lstUpCtrl[i].CkbxBuyed.CheckedChanged += UpCtrlCkBx_CheckedChanged;
            }

            calculateBestItem();
        }

        public void BuiCtrlNud_ValueChanged(object sender, EventArgs e)
        {
            calculateCps();
            calculateBestItem();
        }

        public void UpCtrlCkBx_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBuilding.Count; i++)
            {
                lstBuiCtrl[i].BaseCps = Math.Pow(10, lstBuilding[i].BaseCpsPuissance10) * lstBuilding[i].BaseCps;
            }

            calculateCps();
            calculateBestItem();
        }

        public void calculateCps()
        {
            cps = 0;

            foreach (BuildingsControl buiCtrl in lstBuiCtrl)
            {
                cps += buiCtrl.BaseCps * (double)buiCtrl.NudCount.Value;
            }

            lblCps.Text = String.Format("{0:0.00}", cps);
        }

        public void calculateBestItem()
        {
            List<CpsItem> lstCpsItem = new List<CpsItem>();

            lbxBestItem.Items.Clear();

            foreach (BuildingsControl bui in lstBuiCtrl)
            {
                lstCpsItem.Add(new CpsItem(bui.Price, bui.Cps, bui.Name));
            }

            lstCpsItem = lstCpsItem.OrderBy(o => o.Ratio).ToList();
            for (int i = 0; i < 5; i++)
            {
                lbxBestItem.Items.Add(String.Format("{0}. {1}", i + 1, lstCpsItem[i].Name));
            }
        }
    }
}
