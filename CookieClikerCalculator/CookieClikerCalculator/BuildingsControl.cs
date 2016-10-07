using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClikerCalculator
{
    class BuildingsControl
    {
        TabPage _myPage;
        Point _location;
        string _name;
        decimal _basePrice;
        decimal _price;
        decimal _baseCps;
        decimal _cps;
        Image _img;

        PictureBox _pbx;
        Label _lblName;
        Label _lblPrice;
        Label _lblCps;
        NumericUpDown _nudCount;

        public NumericUpDown NudCount
        {
            get
            {
                return _nudCount;
            }
        }

        public decimal BaseCps
        {
            get
            {
                return _baseCps;
            }
        }

        public BuildingsControl(TabPage myPage, Point location, string name, decimal basePrice, decimal baseCps, Image img)
        {
            _myPage = myPage;
            _location = location;
            _name = name;
            _basePrice = basePrice;
            _price = basePrice;
            _baseCps = baseCps;
            _cps = baseCps;
            _img = img;
        }
        

        public void drawBuildingsControl()
        {
            _pbx = new PictureBox();
            _pbx.Location = _location;
            _pbx.Size = new Size(40, 40);
            _pbx.Image = _img;
            _pbx.SizeMode = PictureBoxSizeMode.StretchImage;

            _lblName = new Label();
            _lblName.Location = new Point(_pbx.Location.X + 50, _location.Y + 15);
            _lblName.Text = _name;

            _lblPrice = new Label();
            _lblPrice.Location = new Point(_lblName.Location.X + 100, _location.Y + 15);
            _lblPrice.Text = String.Format("{0:0.00}", _price);

            _lblCps = new Label();
            _lblCps.Location = new Point(_lblPrice.Location.X + 120, _location.Y + 15);
            _lblCps.Text = _cps.ToString();

            _nudCount = new NumericUpDown();
            _nudCount.Location = new Point(_lblCps.Location.X + 120, _location.Y + 15);
            _nudCount.Maximum = 300;
            _nudCount.ValueChanged += addBuilding;

            _myPage.Controls.Add(_pbx);
            _myPage.Controls.Add(_lblName);
            _myPage.Controls.Add(_lblPrice);
            _myPage.Controls.Add(_lblCps);
            _myPage.Controls.Add(_nudCount);
        }

        private void addBuilding(object sender, EventArgs e)
        {
            //_basePrice = Decimal.Multiply(_basePrice, (decimal)1.15);
            _price = Decimal.Multiply(_basePrice, (decimal)Math.Pow(1.15, (double)_nudCount.Value));

            _lblPrice.Text = String.Format("{0:0.00}", _price);
        }
    }
}
