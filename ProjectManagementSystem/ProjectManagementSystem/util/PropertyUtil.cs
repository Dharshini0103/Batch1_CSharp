using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.util
{
    public class PropertyUtil
    {
        public static string GetPropertyString()
        {
            string filePath = "db.properties";

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Property file not found: " + filePath);
            }

            string hostname = null;
            string dbname = null;
            string username = null;
            string password = null;
            string port = null;
            string integratedSecurity = null;

            foreach (string line in File.ReadAllLines(filePath))
            {
                if (line.Length == 0 || line.StartsWith("#") || !line.Contains("="))
                {
                    continue;
                }

                int index = line.IndexOf('=');
                string key = line.Substring(0, index);
                string value = line.Substring(index + 1);

                if (key == "hostname") hostname = value;
                else if (key == "dbname") dbname = value;
                else if (key == "username") username = value;
                else if (key == "password") password = value;
                else if (key == "port") port = value;
                else if (key == "integratedSecurity") integratedSecurity = value;
            }

            string dataSource = port != null ? hostname + "," + port : hostname;

            string connectionString = (integratedSecurity == "true")
                ? "Data Source=" + dataSource + ";Initial Catalog=" + dbname + ";Integrated Security=true;"
                : "Data Source=" + dataSource + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";

            return connectionString;
        }
    }
}
