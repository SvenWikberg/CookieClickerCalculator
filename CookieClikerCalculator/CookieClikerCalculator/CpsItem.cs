using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClikerCalculator
{
    class CpsItem
    {
        double _price;
        double _cps;
        string _name;

        public double Ratio
        {
            get
            {
                return _price / _cps;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public CpsItem(double price, double cps, string name)
        {
            _price = price;
            _cps = cps;
            _name = name;
        }
    }
}
