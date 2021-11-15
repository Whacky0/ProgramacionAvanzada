using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServidorTest
{
    public class Services
    {
        public int TurnId { get; set; }
        public int Turn { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public int HistoryId { get; set; }
        public int lastIndex { get; set; }

        public bool GuardarTurn()
        {
            DAO mDAO = new DAO();
            string mSQL = "";
            if (TurnId > 0)
            {
                mSQL = "UPDATE PlayerTurn SET Turn= '" + Turn + "', id=" + TurnId;

            }
            else
            {
                int mId = mDAO.ProximoId("PlayerTurn");
                mId += 1;
                mSQL = "INSERT INTO PlayerTurn (Turn, id) VALUES ('" + Turn + "', '" + mId + "')";
            }
            return mDAO.Ejecutar(mSQL) > 0;
        }

        public bool EliminarTurn()
        {
            string mSQL = "DELETE FROM PlayerTurn WHERE id = " + TurnId;

            DAO mDAO = new DAO();

            return mDAO.Ejecutar(mSQL) > 0;
        }

        public void ObtenerTurn()
        {
            if (TurnId > 0)
            {
                string mSQL = "SELECT * FROM PlayerTurn WHERE id=" + TurnId;
                DAO mDAO = new DAO();
                DataSet mDS = mDAO.Obtener(mSQL);

                if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
                {
                    ValorizarTurn(mDS.Tables[0].Rows[0], this);
                }
            }
        }

        public List<Services> ListarTurn()
        {
            string mSQL = "SELECT * FROM PlayerTurn";
            DAO mDAO = new DAO();
            DataSet mDS = mDAO.Obtener(mSQL);

            List<Services> mLista = new List<Services>();
            if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDS.Tables[0].Rows)
                {
                    Services mNivel = new Services();
                    ValorizarTurn(mDr, mNivel);
                    mLista.Add(mNivel);
                }
                return mLista;
            }
            else
                return null;
        }



        public bool GuardarHistory()
        {
            DAO mDAO = new DAO();
            string mSQL = "";
            if (HistoryId > 0)
            {
                mSQL = "UPDATE History SET Player1= '" + Player1 + "', Player2='" + Player2 + "', id='" + HistoryId;

            }
            else
            {
                int mId = mDAO.ProximoId("History");
                mId += 1;
                mSQL = "INSERT INTO History (Player1, Player2, id) VALUES ('" + Player1 + "', '" + Player2 + "' , '" + mId + "' )";
            }
            return mDAO.Ejecutar(mSQL) > 0;
        }



        public void ObtenerHistory()
        {
            if (HistoryId > 0)
            {
                string mSQL = "SELECT * FROM History WHERE id=" + HistoryId;
                DAO mDAO = new DAO();
                DataSet mDS = mDAO.Obtener(mSQL);

                if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
                {
                    ValorizarHistory(mDS.Tables[0].Rows[0], this);
                }
            }
        }

        public List<Services> ListarHistory()
        {
            string mSQL = "SELECT * FROM History";
            DAO mDAO = new DAO();
            DataSet mDS = mDAO.Obtener(mSQL);

            List<Services> mLista = new List<Services>();
            if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDS.Tables[0].Rows)
                {
                    Services mNivel = new Services();
                    ValorizarHistory(mDr, mNivel);
                    mLista.Add(mNivel);
                }
                return mLista;
            }
            else
                return null;
        }


        public List<Services> lastIndices()
        {
            string mSQL = "SELECT * FROM lastIndex";
            DAO mDAO = new DAO();
            DataSet mDS = mDAO.Obtener(mSQL);

            List<Services> mLista = new List<Services>();
            if (mDS.Tables.Count > 0 && mDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDS.Tables[0].Rows)
                {
                    Services mNivel = new Services();
                    ValorizarIndice(mDr, mNivel);
                    mLista.Add(mNivel);
                }
                return mLista;
            }
            else
                return null;
        }

        public bool GuardarIndex()
        {
            DAO mDAO = new DAO();
            string mSQL = "";
            int mId = mDAO.ProximoIndice("lastIndex");
            mId += 1;
            lastIndex= mId;
            mSQL = "INSERT INTO lastIndex (lastIndex) VALUES ('" + mId + "' )";
           
            return mDAO.Ejecutar(mSQL) > 0;
        }

        public void getIndex()
        {
            DAO mDAO = new DAO();
            string mSQL = "";
           mSQL= "SELECT * FROM lastIndex WHERE lastIndex=(SELECT max(lastIndex) FROM lastIndex);";
            lastIndex = mDAO.Ejecutar(mSQL);
        }

        private void ValorizarTurn(DataRow pDr, Services services)
        {
            services.TurnId = int.Parse(pDr["PlayerTurn_id"].ToString());
            services.Turn = int.Parse(pDr["PlayerTurn_Turn"].ToString());
        }

        private void ValorizarHistory(DataRow pDr, Services services)
        {
            services.HistoryId = int.Parse(pDr["History_id"].ToString());
            services.Player1 = int.Parse(pDr["History_Player1"].ToString());
            services.Player2 = int.Parse(pDr["History_Player2"].ToString());
        }

        public void ValorizarIndice(DataRow pDr, Services services)
        {
            services.lastIndex = int.Parse(pDr["lastIndex"].ToString());
        }


    }
}
