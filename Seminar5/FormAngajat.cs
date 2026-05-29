using System;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class FormAngajat : Form
    {
        // 1. CÂMP PRIVAT — stochez referința la angajatul de editat
        //Null dacă e mod adăugare, obiect dacă e mod editare
        private Angajat angajatDeEditat;
        // 2. PROPRIETATE PUBLICĂ — Form1 citește rezultatul prin asta
        //private set` = setată DOAR din interiorul clasei (din btnOk_Click)
        public Angajat AngajatRezultat {  get; private set; }

        public FormAngajat(Angajat angajat)// -- folosit de cod
        {
            InitializeComponent();
            angajatDeEditat = angajat;
        }

        //apeleaza celalalt constructor cu null --folosit de designer
        public FormAngajat() : this(null)
        {
        }

        private void FormAngajat_Load(object sender, EventArgs e)
        {
            cmbDepartament.Items.AddRange(new string[] { "IT", "HR", "Financiar", "Vanzari" });

            if(angajatDeEditat != null)
            {
                this.Text = "Editeaza angajat";
                txtNume.Text = angajatDeEditat.Nume;
                txtPrenume.Text = angajatDeEditat.Prenume;
                cmbDepartament.SelectedItem = angajatDeEditat.Departament;
                txtSalariu.Text = angajatDeEditat.Salariu.ToString("F2");
                dtpDataAngajarii.Value = angajatDeEditat.DataAngajarii;
                chkEstePermanent.Checked = angajatDeEditat.EstePermanent;

            }
            else
            {
                this.Text = "Angajat nou";
                cmbDepartament.SelectedIndex = 0;
                dtpDataAngajarii.Value = DateTime.Today;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Numele este obligatoriu.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNume.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                MessageBox.Show("Prenumele este obligatoriu.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenume.Focus();
                return;
            }
            decimal salariu;
            if(!decimal.TryParse(txtSalariu.Text.Trim(), out salariu) || salariu <= 0)
            {
                MessageBox.Show("Salariul trebuie sa fie un numar pozitiv", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalariu.Focus();
                return;
            }

            AngajatRezultat = new Angajat
            {
                Nume = txtNume.Text.Trim(),
                Prenume = txtPrenume.Text.Trim(),
                Departament = cmbDepartament.SelectedItem.ToString(),
                Salariu = salariu,
                DataAngajarii = dtpDataAngajarii.Value.Date,
                EstePermanent = chkEstePermanent.Checked,
            };

            this.DialogResult = DialogResult.OK;

            
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
