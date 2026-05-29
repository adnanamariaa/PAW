using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class Form1 : Form
    {
        private CarteRepository repository = new CarteRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setari
            lvCarti.View = View.Details;
            lvCarti.FullRowSelect = true;
            lvCarti.MultiSelect = false;
            lvCarti.GridLines = true;
            lvCarti.AllowColumnReorder = true;
            //dimenisune coloane
            int w = lvCarti.ClientSize.Width;
            lvCarti.Columns.Add("Titlu", (int)(w * 0.30));
            lvCarti.Columns.Add("Autor", (int)(w * 0.30));
            lvCarti.Columns.Add("An", (int)(w * 0.20));
            lvCarti.Columns.Add("Gen", (int)(w * 0.20));

            btnEditeaza.Enabled = false;
            btnSterge.Enabled = false;
            RefreshLista();
        }

        private void RefreshLista()
        {
            lvCarti.Items.Clear();//golesc lista

            foreach (Carte c in repository.GetAll())//pentru fiecare carte
            {
                ListViewItem item = new ListViewItem(c.Titlu);//coloana 1 :titlu
                item.SubItems.Add(c.Autor);//coloana 2: autor si tot asa pana la gen
                item.SubItems.Add(c.AnAparitie.ToString());//cu to string pt ca e int
                item.SubItems.Add(c.Gen.ToString());//cu to string pt ca e enum
                item.Tag = c;// leg obiectul

                lvCarti.Items.Add(item);//adaug randul
            }
            lblStatus.Text = "Total: " + repository.GetAll().Count + " carti.";
        }

        private void lvCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esteSelectat = lvCarti.SelectedItems.Count > 0;
            btnEditeaza.Enabled = esteSelectat;
            btnSterge .Enabled = esteSelectat;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            //se asigură că formularul e „curățat" din memorie după închidere
            using (FormCarte f = new FormCarte(null))//null = mod adaugare
            {
                //ShowDialog() deschide fereastra și așteaptă până o închizi. Dacă verdictul e OK → reîmprospătez lista.
                //Dacă a anulat → nu fac nimic.
                if (f.ShowDialog() == DialogResult.OK)
                    RefreshLista();
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvCarti.SelectedItems.Count == 0)//siguranta
                return;

            Carte selectata = lvCarti.SelectedItems[0].Tag as Carte;//recuperez obiectul din tag
            //Aici e plata pentru item.Tag = c de mai devreme: SelectedItems[0].Tag as Carte
            //îți dă exact cartea de pe rândul selectat.
            //Îi iei Id-ul și-l trimiți la FormCarte → se deschide în mod editare.
            using (FormCarte f = new FormCarte(selectata.Id))//trimit id ul, mod editare
            {
                if(f.ShowDialog() == DialogResult.OK)
                    RefreshLista();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lvCarti.SelectedItems.Count == 0)
                return; 
            Carte selectata = lvCarti.SelectedItems[0].Tag as Carte;

            DialogResult r = MessageBox.Show(
                $"Sigur stergi cartea {selectata.Titlu} ?",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if(r== DialogResult.Yes)
            {
                repository.Delete(selectata.Id);
                RefreshLista();
            }
        }
    }
}
