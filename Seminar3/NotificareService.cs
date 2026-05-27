using System;

namespace Seminar3
{
    //clasa statica -> nu poti crea obiecte din ea
    //e doar un container pentru metode
    //apelezi metodele direct prin numele clasei
    //se foloseste doar cand vrei sa obtii functionalitate, nu are stare(nu retine date personale)
    public static class NotificareService
    {
        //metoda statica -> apartine clasei nu unei instante
        //o apelezi cu numeClasa.numeMetoda
        //intr o clasa statica toate metodele sunt statice
        public static void NotificaPrinEmail(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[EMAIL] Comanda {numarComanda}: {mesaj}");
        }

        public static void NotificaPrinSms(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[SMS] Comanda {numarComanda}: {mesaj}");
        }

        public static void Log(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[LOG] Comanda {numarComanda}: {mesaj}");
        }
    }
}
