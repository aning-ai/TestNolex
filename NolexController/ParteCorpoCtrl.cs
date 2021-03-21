using NolexModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NolexController
{
    public class ParteCorpoCtrl
    {
        IList<ParteCorpo> _parcorp;
        ParteCorpo _selectedParCor;
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


        public bool LoadPartiCorpo()
        {
            bool res = true;
            try
            {
                _parcorp.Clear(); 
                myConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    command.CommandText = "SELECT * FROM PartiCorpo";
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
