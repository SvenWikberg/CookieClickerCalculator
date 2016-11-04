using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClikerCalculator
{
    class Upgrades
    {
        int _idUpgrade;
        string _name;
        double _basePrice;
        double _basePricePuissance10;
        int _buiQuantityNeeded;
        string _imgFileName;
        int _idEffect;
        Buildings _bui;

        public Upgrades(int idUpgrade, string name, double basePrice, double basePricePuissance10, int buiQuantityNeeded, string imgFileName, int idEffect, Buildings bui)
        {
            _idUpgrade = idUpgrade;
            _name = name;
            _basePrice = basePrice;
            _basePricePuissance10 = basePricePuissance10;
            _buiQuantityNeeded = buiQuantityNeeded;
            _imgFileName = imgFileName;
            _idEffect = idEffect;
            _bui = bui;
        }

        #region Properties
        public int IdUpgrade
        {
            get
            {
                return _idUpgrade;
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

        public double BasePricePuissance10
        {
            get
            {
                return _basePricePuissance10;
            }
        }

        public int BuiQuantityNeeded
        {
            get
            {
                return _buiQuantityNeeded;
            }
        }

        public string ImgFileName
        {
            get
            {
                return _imgFileName;
            }
        }

        public Buildings Bui
        {
            get
            {
                return _bui;
            }

            set
            {
                _bui = value;
            }
        }
        #endregion

        public void applyEffect()
        {
            Effects tmp = new Effects();
            tmp.applyEffect(_idEffect, _bui);
        }

        public void desapplyEffect()
        {
            Effects tmp = new Effects();
            tmp.desapplyEffect(_idEffect, _bui);
        }
    }
}
