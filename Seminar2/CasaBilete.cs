using System.Collections.Generic;
using System.Linq;

namespace Seminar2
{
    public class CasaBilete
    {
        public List<Bilet> Bilete {  get; set; }
        public CasaBilete()//la pornirea clasei, lista e goala
        {
            //daca nu initializezi lista, Bilete ar fi null si ar avea
            //NullReferenceException la prima incercare de adaugare
            Bilete = new List<Bilet>();
        }

        public void AdaugaBilet(Bilet bilet)
        {
            Bilete.Add(bilet);
        }

        public double GetIncasariTotale()
        {
            return Bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        }

        public double GetReduceriAcordate()
        {
            return Bilete.Sum(bilet => bilet.GetReducere());
        }

        public int GetNumarBiletePerTip<T>() where T : Bilet
        {
            return Bilete.Count(bilet => bilet.GetType() == typeof(T));
        }

        public Bilet GetBiletCelMaiScump()
        {
            return Bilete.OrderByDescending(bilet => bilet.CalculeazaPretFinal() ).FirstOrDefault();
        }
    }
}
