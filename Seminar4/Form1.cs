using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {
        private List<Contact> contacte = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshLista()
        {
            lstContacte.Items.Clear();
            foreach (Contact c in contacte)
                lstContacte.Items.Add(c);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool notificari = chkNotificari.Checked;

            if(string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(prenume) || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show(
                    "Nume, Prenume si Telefon sunt obligatorii",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            Contact c = new Contact() //object initializer
            {
                Nume = nume,
                Prenume = prenume,
                Telefon = telefon,
                Email = email,
                NotificariActive = notificari
            };
            contacte.Add(c);
            RefreshLista();

            txtNume.Clear();
            txtPrenume.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            chkNotificari.Checked = false;

            lblStatus.Text = $"Contact adaugat. Total: {contacte.Count} contacte.";

        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            string termen = txtCautare.Text.Trim().ToLower();

            List<Contact> filtrate = new List<Contact>();

            if (string.IsNullOrEmpty(termen))
            {
                filtrate = contacte;
            }
            else
            {
                filtrate = contacte.Where(
                    c => c.Nume.ToLower().Contains(termen) ||
                    c.Prenume.ToLower().Contains(termen)
                ).ToList();
            }

            lstContacte.Items.Clear();
            foreach (Contact c in filtrate)
                lstContacte.Items.Add(c);

            if (string.IsNullOrEmpty(termen))
            {
                lblStatus.Text = $"Total: {contacte.Count} contacte.";
            }
            else
            {
                lblStatus.Text = $"Se afiseaza {filtrate.Count} din {contacte.Count} contacte.";
            }

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lstContacte.SelectedItem  == null)
            {
                MessageBox.Show(
                    "Selecteaza un buton pentru a-l sterge.",
                    "Atentie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            Contact selectat = lstContacte.SelectedItem as Contact;
            DialogResult rezultat = MessageBox.Show(
                $"Sigur vrei să ștergi contactul {selectat.Prenume} {selectat.Nume}?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (rezultat == DialogResult.Yes)
            {
                contacte.Remove(selectat);
                RefreshLista();
                lblStatus.Text = $"Contact șters. Total: {contacte.Count} contacte.";

            }
        }
    }
}
