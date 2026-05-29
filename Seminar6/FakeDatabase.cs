using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    static class FakeDatabase//nu se instantiaza, nu poti sa ai mai multe obiecte din ea
    {
        //lista e static, o singura copie globala, apartine clasei, o singura copie
        //accesare: FaleDatabase.Carti
        public static List<Carte> Carti = new List<Carte>
        {
            new Carte { Titlu = "Clean Code", Autor = "Robert Martin", AnAparitie = 2008, Gen = GenCarte.Tehnic, Pret = 89.99 },
            new Carte { Titlu = "Dune", Autor = "Frank Herbert", AnAparitie = 1965, Gen = GenCarte.Fictiune, Pret = 49.99 },
            new Carte { Titlu = "Sapiens", Autor = "Yuval Noah Harari", AnAparitie = 2011, Gen = GenCarte.Biografie, Pret = 65.00 },
            new Carte { Titlu = "1984", Autor = "George Orwell", AnAparitie = 1949, Gen = GenCarte.Roman, Pret = 39.50 }
        };

    }
}
