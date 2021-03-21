using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using NolexController;

namespace TestNolex
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection;
        AmbulatorioCtrl ambulatorioCtrl;
        ParteCorpoCtrl particorpoCtrl;
        EsameCtrl esamiCtrl;
        public Form1()
        {
            InitializeComponent();

            myConnection = new SqlConnection("user id=sa;" +
                                                   "password=;server=DESKTOP-1E566DR;" +
                                                   "Trusted_Connection=yes;" +
                                                   "database=TestNolex; " +
                                                   "connection timeout=30");

            ambulatorioCtrl = new AmbulatorioCtrl(myConnection);
            if(ambulatorioCtrl.LoadAmbulatori())
                loadAmbulatori();

            particorpoCtrl = new ParteCorpoCtrl(myConnection);
            if (particorpoCtrl.LoadPartiCorpo())
                loadPartiCorpo();

            esamiCtrl = new EsameCtrl(myConnection);
            if (esamiCtrl.LoadEsami())
                loadEsami();
        }

        private void loadAmbulatori()
        {
            try
            {
                foreach (var amb in ambulatorioCtrl.Ambulatori)
                {
                    lstAmbul.Items.Add(amb.Descrizione);
                }
                lstAmbul.SelectedIndex = 0;
            }
            catch (Exception l)
            {
                MessageBox.Show("Error:" + l);
            }

        }
        private void loadPartiCorpo()
        {
            try
            {
                foreach (var amb in particorpoCtrl.PartiCorpo)
                {
                    lstPartiCorpo.Items.Add(amb.Descrizione);
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("Error:" + l);
            }
        }

        private void loadEsami()
        {
            try
            {
                foreach (var esa in esamiCtrl.Esami)
                {
                    lstEsami.Items.Add(esa.Descrizione);
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("Error:" + l);
            }
        }

        private void lstAmbul_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo: selezionare esami offerti dall'ambulatorio e relative parti del corpo
        }

        private void lstPartiCorpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo: selezionare esami eseguiti per la parte del corpo e relativi ambulatori
        }

        private void btnSelEsame_Click(object sender, EventArgs e)
        {
            //todo: aggiungere riga alla griglia
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            //todo: riesegui la query col filtro selezionato (valore e tipo)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: svuota filtro e riesegui la query 
        }
    }
}
