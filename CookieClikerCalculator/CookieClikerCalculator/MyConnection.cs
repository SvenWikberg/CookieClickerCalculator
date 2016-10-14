using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClikerCalculator
{
    class MyConnection
    {
        MySqlConnection _myBdd;

        public MyConnection(MySqlConnection myBdd)
        {
            _myBdd = myBdd;
            _myBdd.Open();
        }

        public List<Buildings> GetBuildings
        {
            get
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM buildings", _myBdd);
                MySqlDataReader reader = command.ExecuteReader();

                List<Buildings> lstBuilding = new List<Buildings>();
                while (reader.Read())
                {
                    lstBuilding.Add(new Buildings(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetString(6)));
                }

                reader.Close();
                return lstBuilding;
            }
        }

        public List<Upgrades> GetUpgrades
        {
            get
            {
                MySqlCommand command = new MySqlCommand("SELECT upgrades.idUpgrade, upgrades.name, upgrades.basePrice, upgrades.basePricePuissanceDe10, upgrades.buildingsQuantityNeeded, upgrades.imgFileName , ue.idEffect FROM upgrades JOIN upgrades_has_effects AS ue ON ue.idUpgrade = upgrades.idUpgrade ORDER BY upgrades.basePricePuissanceDe10 ASC", _myBdd);
                MySqlDataReader reader = command.ExecuteReader();

                List<Upgrades> lstUpgrade = new List<Upgrades>();
                while (reader.Read())
                {
                    lstUpgrade.Add(new Upgrades(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6)));
                }

                reader.Close();
                return lstUpgrade;
            }
        }
    }
}
