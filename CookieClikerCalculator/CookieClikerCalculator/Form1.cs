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
        public frmMain()
        {
            InitializeComponent();

            MySqlConnection myBdd = new MySqlConnection("server=127.0.0.1;database=cookieClicker;user=wikbergs;password=1234");
            MyConnection connection = new MyConnection(myBdd);

            List<Buildings> lstBuilding = new List<Buildings>(connection.SelectBuildings());
            ImageList imgLstBuilding = new ImageList();

            BigInteger testx = new BigInteger();
            int testy;
            BigInteger testr = new BigInteger();

            testx = (BigInteger)lstBuilding[13].BasePrice;
            testy = (int)lstBuilding[13].BasePricePuissance10;

            testr = testx * BigInteger.Pow(10, testy);


            foreach (Buildings bui in lstBuilding)
            {
                ListViewItem tmp = new ListViewItem("");
                tmp.SubItems.Add(bui.Name);
                //tmp.ImageKey = "img/buildings/" + bui.ImgFileName;
                lstViewBuildings.Items.Add(tmp);
            }
        }
    }
}
