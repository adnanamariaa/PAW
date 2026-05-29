using System;

namespace Seminar5
{
    public class Angajat
    {
        public string Nume { get; set; }
        public string Prenume {  get; set; }
        public string Departament {  get; set; }
        public decimal Salariu {  get; set; }
        public DateTime DataAngajarii {  get; set; }
        public bool EstePermanent { get; set; }

        public override string ToString()
        {
            return $"{Prenume} {Nume}";
        }
        public string GetNumeComplet()
        {
            return $"{Prenume} {Nume}";
        }
    }
}
