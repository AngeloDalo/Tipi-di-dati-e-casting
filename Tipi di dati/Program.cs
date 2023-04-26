using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //TIPI DI DATI
            string nome = "Angelo";
            char lettera = 'a'; //un solo carattere
            int intero = 5;
            long lungo = 10000000000; //cifra oltre i 2mld
            float virgola = 2.3f; //mettere la virgola altrimenti mettere double
            double molte_virgole = 2.22222;
            decimal molte_molte_virgole = 2.22222222222m; //mettere la d
            bool verita = false; //o true

            //CASTING: PASSARE DA UN TIPO AD UN ALTRO
            
            //IMPLICITO
            //gestito da c# da tipo piccolo a tipo grande
            int prova = 345;
            long querty = prova; //non ci da problemi

            float prova2 = 3.45f;
            double querty2 = prova2;
            //il contrario non lo posso fare (non con questo metodo)

            //ESPLICITO
            double prova3 = 32.34;
            int qwerty3 = (int)prova3; //qualche pezzo viene lasciato fuori

            long prova4 = 1000000;
            int qwerty4 = (int)prova4;

            //FUNZIONE
            int prova5 = 34;
            double doppio = 34.34;
            bool qwerty5 = true;

            string stringa = Convert.ToString(prova5);
        }
    }
}