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
        decimal cps;

        public frmMain()
        {
            InitializeComponent();

            MySqlConnection myBdd = new MySqlConnection("server=127.0.0.1;database=cookieClicker;user=wikbergs;password=1234");
            MyConnection connection = new MyConnection(myBdd);

            List<Buildings> lstBuilding = new List<Buildings>(connection.GetBuildings);
            lstBuiCtrl = new List<BuildingsControl>();

            #region comm
            /*ImageList imgLstBuilding = new ImageList();
            decimal basePrice = 0;

            decimal testx;
            decimal testy;
            decimal testr;

            testx = (decimal)lstBuilding[13].BasePrice;
            testy = (decimal)lstBuilding[13].BasePricePuissance10;

            testr = (decimal)Math.Pow(10.0, (double)testy) * testx;


            foreach (Buildings bui in lstBuilding)
            {
                ListViewItem tmp = new ListViewItem("");
                tmp.SubItems.Add(bui.Name);
                tmp.SubItems.Add(((decimal)Math.Pow(10, bui.BasePricePuissance10) * (decimal)bui.BasePrice).ToString());
                tmp.SubItems.Add(((decimal)Math.Pow(10, bui.BaseCpsPuissance10) * (decimal)bui.BaseCps).ToString());
                //tmp.ImageKey = "img/buildings/" + bui.ImgFileName;
                lstViewBuildings.Items.Add(tmp);
            }*/
            #endregion

            for (int i = 0; i < lstBuilding.Count; i++)
            {
                lstBuiCtrl.Add(new BuildingsControl(tPageBuilding, new Point(20, i * 40), lstBuilding[i].Name, (decimal)Math.Pow(10, lstBuilding[i].BasePricePuissance10) * (decimal)lstBuilding[i].BasePrice, (decimal)Math.Pow(10, lstBuilding[i].BaseCpsPuissance10) * (decimal)lstBuilding[i].BaseCps, new Bitmap(Image.FromFile("img/buildings/" + lstBuilding[i].ImgFileName))));
                lstBuiCtrl[i].drawBuildingsControl();
                lstBuiCtrl[i].NudCount.ValueChanged += BuiCtrlNud_ValueChanged;
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
                cps += Decimal.Multiply(buiCtrl.BaseCps, (decimal)buiCtrl.NudCount.Value);
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
                lbxBestItem.Items.Add(String.Format("{0}. {1}", i + 1,lstCpsItem[i].Name));
            }
        }
    }
}
