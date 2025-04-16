using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g
{
    internal class Podcl
    {
        public string str()
        {
            string configPath = Path.Combine(AppContext.BaseDirectory, "config.ini");
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath,
                    "server=localhost;\r\nuser=root;\r\npassword=;\r\ndatabase=Ychet;");
            }
            try
            {
                return File.ReadAllText(configPath);
            }
            catch (Exception ex)
            {
                return $"Ошибка чтения файла: {ex.Message}";
            }
        }
    }

}
