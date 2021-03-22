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
using NolexModel;
using NolexIniSetting;

namespace TestNolex
{
    public partial class Form1 : Form
    {
        AmbulatorioCtrl ambulatorioCtrl;
        ParteCorpoCtrl particorpoCtrl;
        EsameCtrl esamiCtrl;

        public SqlConnection DbConnection { get; }

        public Form1(SqlConnection myConnection)
        {
            DbConnection = myConnection;
            Inizializza();
        }

        public void Inizializza()
        {
            InitializeComponent();

            selectDefaultRicerca();

            esamiCtrl = new EsameCtrl(DbConnection);
            ambulatorioCtrl = new AmbulatorioCtrl(DbConnection);
            particorpoCtrl = new ParteCorpoCtrl(DbConnection);
            
            if (ambulatorioCtrl.LoadAmbulatori())
            {
                loadAmbulatori();
                lstAmbul.SelectedIndex = 0;
                ricercaEsame();
            }

        }

        private void selectDefaultRicerca()
        {
            switch(Predefiniti_Ricerca.Tipo)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
            }

            textCerca.Text = Predefiniti_Ricerca.Valore;
        }

        private void loadAmbulatori()
        {
            try
            {
                lstAmbul.Items.Clear();
                foreach (var amb in ambulatorioCtrl.Ambulatori)
                {
                    lstAmbul.Items.Add(amb);
                }
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
                lstPartiCorpo.Items.Clear();
                foreach (var par in particorpoCtrl.PartiCorpo)
                {
                    lstPartiCorpo.Items.Add(par);
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
                lstEsami.Items.Clear();
                foreach (var esa in esamiCtrl.Esami)
                {
                    lstEsami.Items.Add(esa);
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("Error:" + l);
            }
        }

        private void caricaPartiCorpo()
        {
            Ambulatorio amb = (Ambulatorio)lstAmbul.SelectedItem;
            if (particorpoCtrl.LoadPartiCorpo(amb.Id))
                loadPartiCorpo();
        }
        private void caricaEsami()
        {
            Ambulatorio amb = (Ambulatorio)lstAmbul.SelectedItem;
            ParteCorpo par = (ParteCorpo)lstPartiCorpo.SelectedItem;
            if (esamiCtrl.LoadEsami(amb.Id, par != null ? par.Id : 0))
                loadEsami();
        }
        private void lstAmbul_SelectedIndexChanged(object sender, EventArgs e)
        {
            caricaPartiCorpo();

            caricaEsami();

            abilitaDisabilitaSelezioneEsame();
        }

        private void lstPartiCorpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ambulatorio amb = (Ambulatorio)lstAmbul.SelectedItem;
            ParteCorpo par = (ParteCorpo)lstPartiCorpo.SelectedItem;
            if (esamiCtrl.LoadEsami(amb.Id, par.Id))
                loadEsami();

            abilitaDisabilitaSelezioneEsame();
        }

        private void abilitaDisabilitaSelezioneEsame()
        {
            //btnSelEsame.Enabled = lstAmbul.SelectedItem != null && lstPartiCorpo.SelectedItem != null && lstEsami.SelectedItem != null;
            btnSelEsame.Enabled = lstAmbul.SelectedItem != null && lstEsami.SelectedItem != null;
        }

        private void btnSelEsame_Click(object sender, EventArgs e)
        {
            Ambulatorio amb = (Ambulatorio)lstAmbul.SelectedItem;
            //ParteCorpo par = (ParteCorpo)lstPartiCorpo.SelectedItem;
            Esame esa = (Esame)lstEsami.SelectedItem;

            dataGridView1.Rows.Add(esa.CodiceMinisteriale,
                                   esa.CodiceInterno,
                                   esa.Descrizione,
                                   amb.Descrizione,
                                   //par.Descrizione);
                                   esa.DescrizioneParteCorpo);
        }
        
        private void ricercaEsame()
        {
            if (radioButton1.Checked)
            {
                esamiCtrl.CampoRicerca = "codiceministeriale";
            }
            else if (radioButton2.Checked)
            {
                esamiCtrl.CampoRicerca = "codiceitnerno";
            }
            else if (radioButton3.Checked)
            {
                esamiCtrl.CampoRicerca = "descrizione";
            }
            esamiCtrl.ValoreRicerca = textCerca.Text;

            caricaEsami();
            abilitaDisabilitaSelezioneEsame();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            ricercaEsame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCerca.Text = "";
            esamiCtrl.CampoRicerca = "";
            esamiCtrl.ValoreRicerca = "";
            ricercaEsame();
        }

        private void lstEsami_SelectedIndexChanged(object sender, EventArgs e)
        {
            abilitaDisabilitaSelezioneEsame();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
