using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CookieClikerCalculator
{
    class MyConnection
    {
        List<Buildings> lstBuilding;
        bool test = true;

        public static MySqlConnection MyConnector
        {
            get
            {
                MySqlConnection tmp = new MySqlConnection("server=127.0.0.1;database=cookieClicker;user=wikbergs;password=1234");
                tmp.Open();
                return tmp;
            }
        }

        public List<Buildings> GetBuildings
        {
            get
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM buildings", MyConnector);
                MySqlDataReader reader = command.ExecuteReader();

                lstBuilding = new List<Buildings>();
                while (reader.Read())
                {
                    lstBuilding.Add(new Buildings(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetString(6)));
                }

                test = false;
                reader.Close();
                return lstBuilding;
            }
        }

        /*public Buildings GetBuildingById(int buiId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM buildings WHERE idBuilding =" + buiId.ToString(), MyConnector);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Buildings bui = new Buildings(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetString(6));


            reader.Close();
            return bui;
        }*/

        public List<Upgrades> GetUpgrades
        {
            get
            {

                MySqlCommand command = new MySqlCommand("SELECT upgrades.idUpgrade, upgrades.name, upgrades.basePrice, upgrades.basePricePuissanceDe10, upgrades.buildingsQuantityNeeded, upgrades.imgFileName, ue.idEffect, ub.idBuilding FROM upgrades JOIN upgrades_has_effects AS ue ON ue.idUpgrade = upgrades.idUpgrade JOIN upgrades_isfor_buildings AS ub ON ub.idUpgrade = upgrades.idUpgrade ORDER BY upgrades.basePricePuissanceDe10 ASC", MyConnector);
                MySqlDataReader reader = command.ExecuteReader();

                List<Upgrades> lstUpgrade = new List<Upgrades>();

                while (reader.Read())
                {
                    //Buildings building = GetBuildingById(reader.GetInt32(7));

                    int test = reader.GetInt32(7) - 1;
                    lstUpgrade.Add(new Upgrades(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), lstBuilding[test]));
                }

                reader.Close();
                return lstUpgrade;
            }
        }
    }
}
