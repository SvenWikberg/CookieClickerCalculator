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

        public Upgrades(int idUpgrade, string name, double basePrice, double basePricePuissance10, int buiQuantityNeeded, string imgFileName, int idEffect)
        {
            _idUpgrade = idUpgrade;
            _name = name;
            _basePrice = basePrice;
            _basePricePuissance10 = basePricePuissance10;
            _buiQuantityNeeded = buiQuantityNeeded;
            _imgFileName = imgFileName;
            _idEffect = idEffect;
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
        #endregion

    }
}
