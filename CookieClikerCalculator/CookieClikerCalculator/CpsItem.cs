using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClikerCalculator
{
    class CpsItem
    {
        decimal _price;
        decimal _cps;
        decimal _ratio;
        string _name;

        public decimal Ratio
        {
            get
            {
                return _price / _cps;
            }
        }

        public CpsItem(decimal price, decimal cps, string name)
        {
            _price = price;
            _cps = cps;
            _name = name;
        }
    }
}
