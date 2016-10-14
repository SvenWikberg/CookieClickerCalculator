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
        double cps;

        public frmMain()
        {
            InitializeComponent();

            MySqlConnection myBdd = new MySqlConnection("server=127.0.0.1;database=cookieClicker;user=wikbergs;password=1234");
            MyConnection connection = new MyConnection(myBdd);

            List<Buildings> lstBuilding = new List<Buildings>(connection.GetBuildings);
            lstBuiCtrl = new List<BuildingsControl>();

            List<Upgrades> lstUpgrade = new List<Upgrades>(connection.GetUpgrades);
            lstUpCtrl = new List<UpgradesControl>();


            for (int i = 0; i < lstBuilding.Count; i++)
            {
                lstBuiCtrl.Add(new BuildingsControl(tPageBuilding, new Point(20, i * 40), lstBuilding[i].Name, Math.Pow(10, lstBuilding[i].BasePricePuissance10) * lstBuilding[i].BasePrice, Math.Pow(10, lstBuilding[i].BaseCpsPuissance10) * lstBuilding[i].BaseCps, new Bitmap(Image.FromFile("img/buildings/" + lstBuilding[i].ImgFileName))));
                lstBuiCtrl[i].drawBuildingsControl();
                lstBuiCtrl[i].NudCount.ValueChanged += BuiCtrlNud_ValueChanged;
            }

            for (int i = 0; i < lstUpgrade.Count; i++)
            {
                lstUpCtrl.Add(new UpgradesControl(tPageUpgrade, new Point(20, i * 40), lstUpgrade[i].Name, Math.Pow(10, lstUpgrade[i].BasePricePuissance10) * lstUpgrade[i].BasePrice, new Bitmap(Image.FromFile("img/upgrades/" + lstUpgrade[i].ImgFileName))));
                lstUpCtrl[i].drawUpgradesControl();
            }

            calculateBestItem();
        }

        public void BuiCtrlNud_ValueChanged(object sender, EventArgs e)
        {
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

        public void applyEffect(int idBuilding)
        {
            switch (idBuilding)
            {
                case 0: //Grandmas are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 1: //Frams are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 2: //Mines are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 3: //Factories are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 4: //Banks are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;

                    break;

                case 5: //Temples are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 6: //Wizard are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 7: //Shipments are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 8: //Alchemy labs are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 9: //Portals are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 10: //Time machines are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 11: //Antimatter condensers are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                case 12: //Prisms are twice as efficient.
                    lstBuiCtrl[idBuilding].Cps = lstBuiCtrl[idBuilding].Cps * 2;
                    break;

                default:
                    break;
            }
        }
    }
}
