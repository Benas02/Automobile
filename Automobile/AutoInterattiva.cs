using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    internal class AutoInterattiva : Auto {
        #region "Costruttore"
        // -------------------- Costruttore Vuoto --------------------
        public AutoInterattiva() { }

        #endregion

        #region "Menu"
        // -------------------- Motodo Menu --------------------
        public int stampaMenu()
        {
            int answer;

            Console.WriteLine("\n---------------------------------");

            Console.WriteLine("\n1) ACCENDERE il Veicolo");
            Console.WriteLine("2) RIFORNIRE il Veicolo");
            Console.WriteLine("3) ACCELERARE il Veicolo");
            Console.WriteLine("4) RALLENTARE il Veicolo");
            Console.WriteLine("5) SPEGNERE il Veicolo");
            Console.WriteLine("6) STATO del veicolo");

            Console.WriteLine("0) USCIRE");

            do
            {
                Console.Write("\nSelezionare l'Azione da Eseguire: ");
                answer = Int32.Parse(Console.ReadLine());
            } while (answer < 0 || answer > 6);

            return answer;
        }

        // -------------------- Motodo che Setta il Menu --------------------
        public void setScelta() {
            int menu;

            do {
                menu = stampaMenu();

                switch (menu) {
                    case 1:
                        this.accendi();
                        Console.WriteLine("\n- Tento di Accendere il Veicolo");
                        this.stampaStato();
                        break;
                    case 5:
                        this.spegni();
                        Console.WriteLine("\n- Spengo il Veicolo");
                        this.stampaStato();
                        break;
                    case 2:                             
                        this.rifornisci(this.chiediCarburante());
                        Console.WriteLine("\n- Rifornisco il Veicolo");
                        this.stampaStatoNoStato();
                        break;
                    case 3:
                        if (this.isAccesa() == true) {
                            this.accelera(this.chiediAccelerazione());
                            Console.WriteLine("\n- Accelero il Veicolo");
                            this.stampaStatoVel();
                        } else {
                            Console.WriteLine("Veicolo SPENTO, Accenderlo per Accelerare");
                        } 
                        break;
                    case 4:
                        if (this.isAccesa() == true) {
                            this.decelera(this.chiediDecelerazione());
                            Console.WriteLine("\n- Decelero il Veicolo");
                            this.stampaStatoVel();
                        }
                        else {
                            Console.WriteLine("Veicolo SPENTO, Accenderlo per Decelerare");
                        }
                        break;
                    case 6:
                        this.stampaStatoAutomobile();
                        break;
                    case 0:
                        //Environment.Exit(0);              // CHIUDE IL PROGRAMMA
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            } while (menu != 0);
        }
        #endregion

        #region "Chiedi Carburante"
        // -------------------- Motodo che Chiede il Carburante --------------------
        private int chiediCarburante() {
            int livelloCarburante;

            do
            {
                Console.Write("Quanto Rifornimento vuoi aggiungere: ");
                livelloCarburante = Int32.Parse(Console.ReadLine());
            } while (livelloCarburante < 0);

            return livelloCarburante;
        }
        #endregion

        #region "Chiedi Accelerazione"
        // -------------------- Motodo che Chiede l'Accelerazione --------------------
        private int chiediAccelerazione()
        {
            int livelloAccelera;

            do
            {
                Console.Write("Quanto vuoi Accelerare: ");
                livelloAccelera = Int32.Parse(Console.ReadLine());
            } while (livelloAccelera < 0);

            return livelloAccelera;
        }
        #endregion

        #region "Chiedi Decelerazione"
        // -------------------- Motodo che Chiede la Decelerazione --------------------
        private int chiediDecelerazione()
        {
            int livelloDecelerazione;

            do
            {
                Console.Write("Quanto vuoi Deceleare: ");
                livelloDecelerazione = Int32.Parse(Console.ReadLine());
            } while (livelloDecelerazione < 0);

            return livelloDecelerazione;
        }
        #endregion
    }
}
