using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC09
{
    public class cnn
    {
        public static string db = @"server=LADOBLEAA; database=DBPRACTICA04; integrated security =true";
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string _name, int _value)
        {
            Name = _name;
            Value = _value;
        }
        public override string ToString()
        {
            return Name;
        }

    }

    public class Busco
    {
        public static string BuscaUltimoNumero(string nmID)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos
            SqlCommand cmmnd = new SqlCommand("SELECT SECUENCIA + 1 AS ULTIMO FROM SECUENCIA WHERE ID ='" + nmID + "'", cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmmnd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui pregunta HasRow = true
            {
                return Convert.ToString(rdr["ULTIMO"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }
    }
}
