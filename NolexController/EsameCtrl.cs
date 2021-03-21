using NolexModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NolexController
{
    public class EsameCtrl
    {
        IList<Esame> _esami;
        Esame _selectedEsa;
        SqlConnection myConnection;

        public EsameCtrl(SqlConnection connection)
        {
            myConnection = connection;
            _esami = new List<Esame>();
        }

        public IList<Esame> Esami
        {
            get { return _esami; }
        }


        public bool LoadEsami()
        {
            bool res = true;
            try
            {
                _esami.Clear(); 
                myConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    command.CommandText = "SELECT * FROM Esami";
                    //whenever you want to get some data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var esa = new Esame()
                            {
                                Id = (int)reader["Id"],
                                Descrizione = reader["Descrizione"].ToString(),
                                CodiceInterno = reader["CodiceInterno"].ToString(),
                                CodiceMinisteriale = reader["CodiceMinisteriale"].ToString(),
                                IdParteCorpo = (int)reader["IdParteCorpo"],
                            };
                            _esami.Add(esa);
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
