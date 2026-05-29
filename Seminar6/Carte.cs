using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    //Serializare = a transforma un obiect din memorie
    //într-o formă care poate fi salvată într-un fișier. (obiect → bytes într-un fișier)
    //Deserializare = fișier → obiect în memorie
    [Serializable] //"ai voie sa ma salvezi pe disc"
    public class Carte
    {
        //identificator unic generat automat,, e garantat unic
        //se creeaza cu Guid.NewGuid()
        public Guid Id { get; set; }
        public string Titlu {  get; set; }
        public string Autor {  get; set; }
        public int AnAparitie {  get; set; }
        public GenCarte Gen {  get; set; }
        public double Pret {  get; set; }

        public Carte()
        {
            Id = Guid.NewGuid();//fiecare carte noua are un id unic, fara sa i l dau eu
        }

        public override string ToString()
        {
            return $"{Titlu}  {Autor} {AnAparitie}";
        }
    }
}
