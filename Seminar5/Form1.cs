using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class Form1 : Form
    {
        // BindingList — notifică automat DataGridView-ul la modificări
        private BindingList<Angajat> angajati = new BindingList<Angajat>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Leg DataGridView-ul de BindingList
            dgvAngajati.DataSource = angajati;

            // 2. Populez ComboBox de filtrare
            cmbFiltruDepartament.Items.AddRange(new string[] {
                "Toate", "IT", "HR", "Financiar", "Vanzari"
            });
            cmbFiltruDepartament.SelectedIndex = 0;  // "Toate" implicit

            // 3. Câteva date de test (opțional, ca să nu pornești cu listă goală)
            angajati.Add(new Angajat
            {
                Nume = "Popescu",
                Prenume = "Ion",
                Departament = "IT",
                Salariu = 5000,
                DataAngajarii = new DateTime(2020, 3, 15),
                EstePermanent = true
            });
            angajati.Add(new Angajat
            {
                Nume = "Ionescu",
                Prenume = "Maria",
                Departament = "HR",
                Salariu = 4200,
                DataAngajarii = new DateTime(2021, 6, 1),
                EstePermanent = true
            });

            lblStatus.Text = $"Total: {angajati.Count} angajati.";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            // Deschid FormAngajat cu null = mod adăugare
            using (FormAngajat f = new FormAngajat(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    angajati.Add(f.AngajatRezultat);
                    lblStatus.Text = $"Angajat adaugat: {f.AngajatRezultat.GetNumeComplet()}. Total: {angajati.Count}";
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            // Verific dacă e selectat ceva
            if (dgvAngajati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un angajat pentru editare.", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Iau indexul rândului selectat
            int index = dgvAngajati.SelectedRows[0].Index;
            Angajat selectat = angajati[index];

            // Deschid FormAngajat cu obiectul = mod editare
            using (FormAngajat f = new FormAngajat(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    angajati[index] = f.AngajatRezultat;  // înlocuiesc la același index
                    lblStatus.Text = $"Angajat actualizat: {f.AngajatRezultat.GetNumeComplet()}.";
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            // Verific selecția
            if (dgvAngajati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un angajat pentru stergere.", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvAngajati.SelectedRows[0].Index;
            Angajat selectat = angajati[index];

            // Confirmare
            DialogResult rezultat = MessageBox.Show(
                $"Sigur vrei sa stergi angajatul {selectat.GetNumeComplet()}?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                angajati.RemoveAt(index);
                lblStatus.Text = $"Angajat sters. Total: {angajati.Count}";
            }
        }

        private void cmbFiltruDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamentSelectat = cmbFiltruDepartament.SelectedItem.ToString();

            if (departamentSelectat == "Toate")
            {
                // Arăt toți
                dgvAngajati.DataSource = angajati;
            }
            else
            {
                // Filtrez cu LINQ și creez un BindingList nou (temporar)
                var filtrati = angajati.Where(a => a.Departament == departamentSelectat).ToList();
                dgvAngajati.DataSource = new BindingList<Angajat>(filtrati);
            }
        }
    }
}