using NolexModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NolexController
{
    public class EsameCtrl
    {
        IList<Esame> _esami;
        //Esame _selectedEsa;
        SqlConnection myConnection;
        string _camporicerca;
        string _valorericerca;
        public string CampoRicerca { get => _camporicerca; set => _camporicerca = value; }
        public string ValoreRicerca { get => _valorericerca; set => _valorericerca = value; }



        public EsameCtrl(SqlConnection connection)
        {
            myConnection = connection;
            _esami = new List<Esame>();
        }

        public IList<Esame> Esami
        {
            get { return _esami; }
        }


        public bool LoadEsami(int idambulatorio, int idpartecorpo)
        {
            bool res = true;
            try
            {
                _esami.Clear(); 
                myConnection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    //command.CommandText = "SELECT * FROM Esami";

                    StringBuilder sql = new StringBuilder("SELECT[Esami].id, ");
                    sql.Append(" [Esami].descrizione, ");
                    sql.Append(" [Esami].codiceinterno, ");
                    sql.Append(" [Esami].codiceministeriale, ");
                    sql.Append(" [Esami].idpartecorpo, ");
                    //sql.Append(" [Ambulatori].descrizione as Ambulatori, ");
                    sql.Append(" [PartiCorpo].descrizione as 'Parte' ");
                    sql.Append(" FROM[Ambulatori] ");
                    sql.Append(" JOIN[AmbulatoriEsami] ON[AmbulatoriEsami].idambulatorio = [Ambulatori].id ");
                    sql.Append(" JOIN[Esami] ON[AmbulatoriEsami].idesame = [Esami].id ");
                    sql.Append(" JOIN[PartiCorpo] ON[PartiCorpo].id =[Esami].idpartecorpo ");
                    sql.Append(" where");
                    sql.Append(" [Ambulatori].id = ");
                    sql.Append(idambulatorio);
                    if (idpartecorpo > 0)
                    {
                        sql.Append(" and [PartiCorpo].id = ");
                        sql.Append(idpartecorpo);
                    }
                    if (_camporicerca != null && _camporicerca != "")
                    {
                        sql.Append(" and LOWER([Esami].");
                        sql.Append(_camporicerca);
                        sql.Append(") like ");
                        sql.Append("'%");
                        sql.Append(_valorericerca.ToLower());
                        sql.Append("%'");
                    }
                    command.CommandText = sql.ToString();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var esa = new Esame()
                            {
                                Id = (int)reader["id"],
                                Descrizione = reader["descrizione"].ToString(),
                                CodiceInterno = reader["codiceinterno"].ToString(),
                                CodiceMinisteriale = reader["codiceministeriale"].ToString(),
                                IdParteCorpo = (int)reader["IdParteCorpo"],
                                DescrizioneParteCorpo = (string)reader["Parte"],
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
