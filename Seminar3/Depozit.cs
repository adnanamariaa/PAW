using System;
using System.Collections.Generic;
using System.Linq;

namespace Seminar3
{
    public class Depozit
    {
        public string Nume {  get; set; }
        public event EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public event EventHandler<ComandaLivrataEventArgs> ComandaLivrata;
        private List<Comanda> _comenzi;

        public Depozit(string nume)
        {
            Nume = nume;
            _comenzi = new List<Comanda>();
        }

        public void InregistreazaComanda(Comanda comanda, NotificareClient notificator = null)
        {
            _comenzi.Add(comanda);
            notificator?.Invoke(comanda.NumarComanda, "Comanda a fost inregistrata");
        }

        public void AvanseazaComanda(string numarComanda)
        {
            //gasesc dupa numar cu LINQ
            var comanda = _comenzi.FirstOrDefault(c => c.NumarComanda == numarComanda);
            if (comanda == null)
                return;
            //daca e deja livrata, ies
            if (comanda.Stare == StareComanda.Livrata)
                return;

            //pregates EventArgs cu starea Veche(cea curenta)
            var args = new ComandaSchimbatStareEventArgs()
            {
                Comanda = comanda,
                StareVeche = comanda.Stare
            };

            //avansez starea: enum + 1 (Plasata -> Procesata -> Expediata -> Livrata)
            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            args.StareNoua = comanda.Stare;

            //declansez evenimentul de schimbare stare
            OnComandaSchimbatStare(args);

            if(comanda.Stare == StareComanda.Livrata)
            {
                var livrataArgs = new ComandaLivrataEventArgs()
                {
                    Comanda = comanda,
                    DataLivrare = DateTime.Now
                };
                OnComandaLivrata(livrataArgs);
            }
        }

        protected virtual void OnComandaSchimbatStare(ComandaSchimbatStareEventArgs e)
        {
            ComandaSchimbatStare?.Invoke(this, e);
        }

        protected virtual void OnComandaLivrata(ComandaLivrataEventArgs e)
        {
            ComandaLivrata?.Invoke(this, e);
        }

        public List<Comanda> GetComenziActive()
        {
            return _comenzi.Where(c => c.Stare != StareComanda.Livrata).ToList();
        }



    }
}
