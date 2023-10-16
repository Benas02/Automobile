using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    class Auto {
        #region "Proprietà"
        // -------------------- Tipi personalizzati --------------------
        public enum Motore {
            Benzina,
            Diesel,
            Elettrico
        }

        // -------------------- Proprietà --------------------
        public string? marca;
        public string? modello;
        public Motore tipoMotore;
        public string? colore;
        public int livelloCarburante;
        private bool accesa;
        #endregion

        #region "Costruttore"
        // -------------------- Costruttore Vuoto --------------------
        public Auto() { }

        // -------------------- Costruttore Con Parametri --------------------
        public Auto(string? marca, string? modello, Motore tipoMotore, string? colore, int livelloCarburante) {
            this.marca = marca;
            this.modello = modello;
            this.tipoMotore = tipoMotore;
            this.colore = colore;
            this.livelloCarburante = livelloCarburante;
        }
        #endregion

        #region "Accendi - Spegni - Rifornimento"
        // -------------------- Motodo che Accende l'Auto --------------------
        public void accendi() {
            if (this.livelloCarburante > 0) {
                this.accesa = true;
            } else {
                this.accesa = false;
            }
        }

        // -------------------- Motodo che Spegne l'Auto --------------------
        public void spegni() {
            this.accesa = false;
        }

        // -------------------- Motodo che Rifornisce l'Auto --------------------
        public void rifornisci(int livelloCarburante) {
            this.livelloCarburante = livelloCarburante;
        }

        #endregion

        #region "Stampa Descrizione"
        // -------------------- Motodo che Stampa la Descrizione dell'Auto --------------------
        public void stampaDescrizione() {
            Console.WriteLine(generaDescrizione());
        }

        private string generaDescrizione() {
            string result;

            result = "Marca: " + this.marca + "\n";
            result += $"Modello: {this.modello}\n";
            result += $"Colore: {this.colore}\n";
            result += "Tipo Motore: " + this.tipoMotore;

            return result;
        }
        #endregion

        #region "Stampa Stato"
        // -------------------- Motodo che Stampa lo Stato dell'Auto --------------------
        public void stampaStato() {
            Console.WriteLine(generaStato());
        }

        private string generaStato() {
            string result;

            result = "Livello Carburante: " + this.livelloCarburante + " l\n";

            if (this.accesa == true) {
                result += "Stato Veicolo: Veicolo ACCESO";
            } else {
                result += "Stato Veicolo: Veicolo SPENTO";
            }

            return result;
        }

        // -------------------- Motodo che Stampa lo Stato dell'Auto --------------------
        public void stampaStatoNoStato()
        {
            Console.WriteLine(generaStatoNoStato());
        }

        private string generaStatoNoStato()
        {
            string result;
            result = "Livello Carburante: " + this.livelloCarburante + " l";
            return result;
        }
        #endregion

    }

}
