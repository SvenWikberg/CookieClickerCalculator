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

        public List<Buildings> SelectBuildings()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM buildings", _myBdd);
            MySqlDataReader reader = command.ExecuteReader();

            List<Buildings> lstBuilding = new List<Buildings>();
            while (reader.Read())
            {
                lstBuilding.Add(new Buildings(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetString(6)));
            }

            return lstBuilding;
        }
    }
}
