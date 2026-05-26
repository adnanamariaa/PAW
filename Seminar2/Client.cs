using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Client
    {
        public string Nume {  get; set; }
        public string Prenume {  get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("Adresa de email este invalida.");
                _email = value;
            }
        }

        private string _telefon;
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Numarul de telefon este invalid.");
                _telefon = value;
            }
        }

        public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }

    }
}
