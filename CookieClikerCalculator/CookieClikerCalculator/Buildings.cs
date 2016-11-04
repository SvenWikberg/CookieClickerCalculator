using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CookieClikerCalculator
{
    public class Buildings
    {
        int _idBuilding;
        string _name;
        double _basePrice;
        double _basePricePuissance10;
        double _baseCps;
        double _baseCpsPuissance10;
        string _imgFileName;

        public Buildings(int idBuildings, string name, double basePrice, double basePricePuissance10, double baseCps, double baseCpsPuissance10, string imgFileName)
        {
            _idBuilding = idBuildings;
            _name = name;
            _basePrice = basePrice;
            _basePricePuissance10 = basePricePuissance10;
            _baseCps = baseCps;
            _baseCpsPuissance10 = baseCpsPuissance10;
            _imgFileName = imgFileName;
        }

        public int IdBuilding
        {
            get
            {
                return _idBuilding;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string ImgFileName
        {
            get
            {
                return _imgFileName;
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

        public double BaseCps
        {
            get
            {
                return _baseCps;
            }
            set
            {
                _baseCps = value;
            }
        }

        public double BaseCpsPuissance10
        {
            get
            {
                return _baseCpsPuissance10;
            }
        }
    }
}
