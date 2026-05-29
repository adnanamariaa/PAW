using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    //Repository = intermediarul dintre date și restul aplicației.
    //Formularele nu ating niciodată direct FakeDatabase — întreabă repository-ul:
    //„dă-mi toate cărțile", „adaugă cartea asta", „șterge cartea cu Id-ul X".
    //repository-ul doar operează pe date — fără MessageBox, fără validări, fără UI. Validarea o face formularul.
    //Așa repository-ul poate fi refolosit oriunde.
    public class CarteRepository
    {
        //returneaza o copie a listei din faedatabase,
        //ca sa nu poata cineva din afara sa strice lista originala
        public List<Carte> GetAll()
        {
            return new List<Carte>(FakeDatabase.Carti);
        }

        public Carte GetById(Guid id)
        {
            return FakeDatabase.Carti.FirstOrDefault(c =>  c.Id == id); 
        }

        public void Add(Carte carte)
        {
            FakeDatabase.Carti.Add(carte);
        }

        public void Update(Carte carte)
        {
            int index = FakeDatabase.Carti.FindIndex(c => c.Id == carte.Id);
            if(index >=0)
            {
                FakeDatabase.Carti[index] = carte;
            }
        }

        public void Delete(Guid id) 
        { 
            FakeDatabase.Carti.RemoveAll(c => c.Id == id);
        }
    }
}
