using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BL
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Posicion { get; set; }

        public string Pierna_Habil { get; set; }




        public bool Guardar()
        {
            DAO mDAO = new DAO();
            string mSQL = "";
            if (Id > 0)
            {
                mSQL = "UPDATE Jugador_table SET Jugador_nombre= '" + Nombre + ", Jugador_posicion=" + Posicion+ ", Jugador_pierna=" + Pierna_Habil + " WHERE Jugador_id = " + Id;

            }
            else
            {
                int mId = mDAO.ProximoId("Jugador_table");
                mId += 1;
                mSQL = "INSERT INTO Jugador_table (Jugador_id, Jugador_posicion, Jugador_pierna, Jugador_nombre) VALUES (" + mId + ", '" + Posicion+ "', '" + Pierna_Habil+ "', '" + Nombre+ "')";
            }
            return mDAO.Ejecutar(mSQL) > 0;
        }

        public bool Eliminar()
        {
            string mSQL = "DELETE FROM Jugador_table WHERE Jugador_id = " + Id;

            DAO mDAO = new DAO();

            return mDAO.Ejecutar(mSQL) > 0;
        }

        public void Obtener()
        {
            if (Id > 0)
            {
                string mSQL = "SELECT * FROM Jugador_table WHERE Jugador_id=" + Id;
                DAO mDAO = new DAO();
                DataSet mDS = mDAO.Obtener(mSQL);

                if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
                {
                    Valorizar(mDS.Tables[0].Rows[0], this);
                }
            }
        }

        public List<Jugador> Listar()
        {
            string mSQL = "SELECT * FROM Jugador_table";
            DAO mDAO = new DAO();
            DataSet mDS = mDAO.Obtener(mSQL);

            List<Jugador> mLista = new List<Jugador>();
            if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDS.Tables[0].Rows)
                {
                    Jugador jugador= new Jugador();
                    Valorizar(mDr, jugador);
                    mLista.Add(jugador);
                }
                return mLista;
            }
            else
                return null;
        }

        private void Valorizar(DataRow pDr, Jugador jugador)
        {
            jugador.Id = int.Parse(pDr["Jugador_id"].ToString());
            jugador.Nombre = pDr["Jugador_nombre"].ToString();
            jugador.Pierna_Habil = pDr["Jugador_pierna"].ToString();
            jugador.Posicion = pDr["Jugador_posicion"].ToString();
        }
    }
}
