using NolexModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NolexController
{
    public class AmbulatorioCtrl
    {
        IList<Ambulatorio> _ambulatori;
        Ambulatorio _selectedAmb;
        SqlConnection myConnection;

        public AmbulatorioCtrl(SqlConnection connection)
        {
            myConnection = connection;
            _ambulatori = new List<Ambulatorio>();
        }

        public IList<Ambulatorio> Ambulatori
        {
            get { return _ambulatori; }
        }


        public bool LoadAmbulatori()
        {
            bool res = true;
            try
            {
                _ambulatori.Clear(); 
                myConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    command.CommandText = "SELECT * FROM Ambulatori";
                    //whenever you want to get some data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var amb = new Ambulatorio()
                            {
                                Id = (int)reader["Id"],
                                Descrizione = reader["Descrizione"].ToString()
                            };
                            _ambulatori.Add(amb);
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
