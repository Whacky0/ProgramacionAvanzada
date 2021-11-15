using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ServidorTest
{
    class DAO
    {
        SqlConnection mCon = new SqlConnection(@"Data Source=N048-HP250G7\SQLEXPRESS;Initial Catalog=CardWars;Integrated Security=True");

        public int Ejecutar(string pSQL)
        {
            try
            {
                SqlCommand mCOm = new SqlCommand(pSQL, mCon);
                mCon.Open();
                return mCOm.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                mCon.Close();
            }

        }

        public DataSet Obtener(string pSQL)
        {
            SqlDataAdapter mDa = new SqlDataAdapter(pSQL, mCon);
            DataSet mDs = new DataSet();

            mDa.Fill(mDs);

            return mDs;
        }

        public int ProximoId(string pTabla)
        {
            string mSQL = "SELECT ISNULL(MAX(id), 0) FROM " + pTabla;
            DataSet mDs = Obtener(mSQL);

            return int.Parse(mDs.Tables[0].Rows[0][0].ToString());
        }

        public int ProximoIndice(string pTabla)
        {
            string mSQL = "SELECT ISNULL(MAX(lastIndex), 0) FROM " + pTabla;
            DataSet mDs = Obtener(mSQL);

            return int.Parse(mDs.Tables[0].Rows[0][0].ToString());
        }


    }
}
