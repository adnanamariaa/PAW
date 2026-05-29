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
    public partial class FormCarte : Form
    {
        //ca sa poata edita/adauga carti
        private CarteRepository repository = new CarteRepository();
        //retine daca suntem in mod adaugare(null) sau editare(id concret)
        //il primeste prin constructor si l salveaza aici ca sa l foloseasca in form_load si la ok
        private Guid? id;
        public FormCarte(Guid? id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormCarte_Load(object sender, EventArgs e)
        {
            //umplerea combobox ului din enum
            cmbGen.DataSource = Enum.GetValues(typeof(GenCarte));

            if (id == null)//mod adaugare
            {
                this.Text = "Carte noua";//titlul ferestrei
            }
            else
            { //mod editare - completez campurile cu datele cartii existente
                this.Text = "Editeaza carte";
                Carte c = repository.GetById(id.Value);
                txtTitlu.Text = c.Titlu;
                txtAutor.Text = c.Autor;
                numAn.Value = c.AnAparitie;
                cmbGen.SelectedItem = c.Gen;
                numPret.Value = (decimal)c.Pret;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            epCarte.Clear();//sterg erorile vechi
            if(string.IsNullOrWhiteSpace(txtTitlu.Text))
            {
                epCarte.SetError(txtTitlu, "Titlul este obligatoriu");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                epCarte.SetError(txtAutor, "Autorul este obligatoriu");
                return;
            }

            if (id == null){
                //adaugare - creez o carte noua si o adaug
                Carte c = new Carte();
                c.Titlu = txtTitlu.Text;
                c.Autor = txtAutor.Text;
                c.AnAparitie = (int)numAn.Value;
                c.Gen = (GenCarte)cmbGen.SelectedItem;
                c.Pret = (double)numPret.Value;
                repository.Add(c);
            }
            else
            {
                //editare - iau cartea existenta, ii schimb proprietatile, o salvez
                Carte c = repository.GetById(id.Value);
                c.Titlu = txtTitlu.Text;
                c.Autor = txtAutor.Text;
                c.AnAparitie = (int)numAn.Value;
                c.Gen = (GenCarte)cmbGen.SelectedItem;
                c.Pret = (double)numPret.Value;
                repository.Update(c);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
