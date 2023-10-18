using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    public class Auto {
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

        private int livelloMaxCarburante;
        public int livelloCarburante;
        private bool accesa;

        private int livelloMaxVelocita;
        public int livelloVelocita;
        #endregion

        #region "Costruttore"
        // -------------------- Costruttore Vuoto --------------------
        public Auto() {
            this.marca = "Tesla";
            this.modello = "X";
            this.tipoMotore = Auto.Motore.Elettrico;
            this.colore = "Bianco";
            this.livelloCarburante = 10;
            this.livelloMaxCarburante = 100;
            this.livelloVelocita = 0;
            this.livelloMaxVelocita = 250;
        }

        // -------------------- Costruttore Con Parametri --------------------
        public Auto(string? marca, string? modello, Motore tipoMotore, string? colore) {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.tipoMotore = tipoMotore;
        }

        public Auto(string? marca, string? modello, Motore tipoMotore, string? colore, int livelloMaxCarburante, int livelloCarburante) : this(marca, modello, tipoMotore, colore) {
            this.livelloMaxCarburante = livelloMaxCarburante;
            this.livelloCarburante = livelloCarburante;
        }

        public Auto(string? marca, string? modello, Motore tipoMotore, string? colore, int livelloMaxCarburante, int livelloCarburante, int livelloVelocita, int livelloMaxVelocita) : this(marca, modello, tipoMotore, colore, livelloMaxCarburante, livelloCarburante) {

            this.livelloMaxVelocita = livelloMaxVelocita;
            this.livelloVelocita = livelloVelocita;
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
        public void rifornisci(int carburante) {
            if (carburante > 0) {
                this.livelloCarburante += carburante;  

                if(this.livelloCarburante > this.livelloMaxCarburante) {
                    this.livelloCarburante = this.livelloMaxCarburante;
                }
            }
            
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

        public string generaStato() {
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
