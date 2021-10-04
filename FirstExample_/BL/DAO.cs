using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BL
{
   public class DAO
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=N048-HP250G7\SQLEXPRESS;Initial Catalog=Example;Integrated Security=True");

        public int Ejecutar(string pSQL)
        {
            try
            {
                SqlCommand mCOm = new SqlCommand(pSQL, sqlConnection);
                sqlConnection.Open();
                return mCOm.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataSet Obtener(string pSQL)
        {
            SqlDataAdapter mDa = new SqlDataAdapter(pSQL, sqlConnection);
            DataSet mDs = new DataSet();

            mDa.Fill(mDs);

            return mDs;
        }

        public int ProximoId(string pTabla)
        {
            string mSQL = "SELECT ISNULL (MAX(Jugador_id), 0) FROM " + pTabla;
            DataSet mDs = Obtener(mSQL);

            return int.Parse(mDs.Tables[0].Rows[0][0].ToString());
        }

        public int ProximoIdEquipo(string pTabla)
        {
            string mSQL = "SELECT ISNULL (MAX(Equipo_id), 0) FROM " + pTabla;
            DataSet mDs = Obtener(mSQL);

            return int.Parse(mDs.Tables[0].Rows[0][0].ToString());
        }

    }
}
