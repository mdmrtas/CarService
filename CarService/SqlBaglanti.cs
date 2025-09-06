using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarService
{
    public static class SqlBaglanti
    {
        private static readonly string connectionString = "Data Source=LAPTOP-OJS2NRNS\\SQLEXPRESS01;Initial Catalog=DbOtoBakimServis;Integrated Security=True";

        public static SqlConnection BaglantiOlustur()
        {
            return new SqlConnection(connectionString);
        }
    }
}
