using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClikerCalculator
{
    class UpgradesControl
    {
        TabPage _myPage;
        Point _location;
        string _name;
        double _basePrice;
        Image _img;

        PictureBox _pbx;
        Label _lblName;
        Label _lblPrice;
        CheckBox _ckbxBuyed;

        public UpgradesControl(TabPage myPage, Point location, string name, double basePrice, Image img)
        {
            _myPage = myPage;
            _location = location;
            _name = name;
            _basePrice = basePrice;
            _img = img;
        }

        #region Properties
        public CheckBox CkbxBuyed
        {
            get
            {
                return _ckbxBuyed;
            }
        }

        public Point Location
        {
            get
            {
                return _location;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double BasePrice
        {
            get
            {
                return _basePrice;
            }
        }

        public Image Img
        {
            get
            {
                return _img;
            }
        }
        #endregion

        public void drawUpgradesControl()
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
            _lblPrice.Text = String.Format("{0}", _basePrice);

            _ckbxBuyed = new CheckBox();
            _ckbxBuyed.Location = new Point(_lblPrice.Location.X + 300, _location.Y + 15);
            _ckbxBuyed.Checked = false;
            //_ckbxBuyed.CheckedChanged

            _myPage.Controls.Add(_pbx);
            _myPage.Controls.Add(_lblName);
            _myPage.Controls.Add(_lblPrice);
            _myPage.Controls.Add(_ckbxBuyed);
        }
    }
}
