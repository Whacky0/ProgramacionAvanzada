using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BL
{
    public class Equipo
    {
        public int Id { get; set; }
        public int Jugadores_Id { get; set; }


            public bool Guardar(int jugador_id)
            {
            Jugadores_Id = jugador_id;
                DAO mDAO = new DAO();
                string mSQL = "";
                if (Id > 0)
                {
                    mSQL = "UPDATE Equipo_id SET Jugadores_id= '" + Jugadores_Id + "' WHERE Equipo_id = " + Id;

                }
                else
                {
                    int mId = mDAO.ProximoIdEquipo("Equipo_id");
                    mId += 1;
                    mSQL = "INSERT INTO Equipo_id (Equipo_id, Jugadores_id) VALUES (" + mId + ", '" + Jugadores_Id+ "')";
                }
                return mDAO.Ejecutar(mSQL) > 0;
            }

        public void Obtener()
        {
            if (Id > 0)
            {
                string mSQL = "SELECT * FROM Equipo_id WHERE Equipo_id=" + Id;
                DAO mDAO = new DAO();
                DataSet mDS = mDAO.Obtener(mSQL);

                if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
                {
                    Valorizar(mDS.Tables[0].Rows[0], this);
                }
            }
        }

        private void Valorizar(DataRow pDr, Equipo equipo)
        {
            equipo.Id = int.Parse(pDr["Equipo_id"].ToString());
            equipo.Jugadores_Id = int.Parse (pDr["Jugador_nombre"].ToString());
            
        }

        public List<Equipo> Listar()
        {
            string mSQL = "SELECT * FROM Equipo_id";
            DAO mDAO = new DAO();
            DataSet mDS = mDAO.Obtener(mSQL);

            List<Equipo> mLista = new List<Equipo>();
            if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDS.Tables[0].Rows)
                {
                    Equipo equipo = new Equipo();
                    Valorizar(mDr, equipo);
                    mLista.Add(equipo);
                }
                return mLista;
            }
            else
                return null;
        }

    }
}
