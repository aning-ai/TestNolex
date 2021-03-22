using NolexModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NolexController
{
    public class ParteCorpoCtrl
    {
        IList<ParteCorpo> _parcorp;
        //ParteCorpo _selectedParCor;
        SqlConnection myConnection;

        public ParteCorpoCtrl(SqlConnection connection)
        {
            myConnection = connection;
            _parcorp = new List<ParteCorpo>();
        }

        public IList<ParteCorpo> PartiCorpo
        {
            get { return _parcorp; }
        }


        public bool LoadPartiCorpo(int idambulatorio)
        {
            bool res = true;
            try
            {
                _parcorp.Clear(); 
                myConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    //command.CommandText = "SELECT * FROM PartiCorpo";
                    StringBuilder sql = new StringBuilder("SELECT DISTINCT [PartiCorpo].id, [PartiCorpo].descrizione");
                            sql.Append(" FROM[Ambulatori]");
                            sql.Append(" JOIN[AmbulatoriEsami] ON[AmbulatoriEsami].idambulatorio = [Ambulatori].id");
                            sql.Append(" JOIN[Esami] ON[AmbulatoriEsami].idesame = [Esami].id");
                            sql.Append(" JOIN[PartiCorpo] ON[PartiCorpo].id =[Esami].idpartecorpo");
                            sql.Append(" where[Ambulatori].id = ");
                            sql.Append(idambulatorio);
                    command.CommandText = sql.ToString();
                    //whenever you want to get some data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var par = new ParteCorpo()
                            {
                                Id = (int)reader["Id"],
                                Descrizione = reader["Descrizione"].ToString()
                            };
                            _parcorp.Add(par);
                        }
                    }
                }
                res = true;
            }
            catch (Exception l)
            {
                System.Console.WriteLine("Error:" + l);
            }
            finally
            {
                myConnection.Close();
            }

            return res;
        }
    }

}
