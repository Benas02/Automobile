using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public int livelloMaxCarburante { get; private set; }
        public int livelloCarburante { get; private set; }
        private bool accesa;
        
        public int livelloVelocita { get; private set; }
        public int livelloMaxVelocita { get; private set; }
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

        // -------------------- Get Accesa --------------------
        public bool isAccesa()
        {
            return this.accesa; 
        }
        #endregion

        #region "Accendi - Spegni - Rifornimento"
        // -------------------- Motodo che Accende l'Auto --------------------
        public void accendi() {
            if (this.livelloCarburante > 2) {
                this.accesa = true;
                this.livelloCarburante -= 1;
            } else {
                this.accesa = false;
            }
        }

        // -------------------- Motodo che Spegne l'Auto --------------------
        public void spegni() {
            if (this.livelloVelocita == 0)  {
                this.accesa = false;
            } else {
                this.accesa = true;
                Console.WriteLine("Per SPEGNERE il Veicolo RALLENTARE Molto Completamente");
            }            
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

        #region "Accelera - Decelera"
        // -------------------- Motodo che Accelera l'Auto --------------------
        public void accelera(int value) {
            if (value > 0) {
                if(this.livelloCarburante <= value){
                    Console.WriteLine("Bisogna fare RIFORNIMENTO");
                } else {
                    this.livelloVelocita += value;
                    this.livelloCarburante -= value;

                    if (this.livelloVelocita > this.livelloMaxVelocita)
                    {
                        this.livelloVelocita = this.livelloMaxVelocita;
                    }
                }                
            }           
        }

        public void decelera(int value) {
            if (value > 0) {
                if (this.accesa == true) {
                    Console.WriteLine("Accendere la macchina");

                    if (this.livelloVelocita > 0) {
                        this.livelloVelocita -= value;

                        if (this.livelloVelocita < 0) {
                            this.livelloVelocita = 0;
                        }
                    } 
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
            result += "Tipo Motore: " + this.tipoMotore + "\n";
            result += "Livello Carburante: " + this.livelloCarburante;

            return result;
        }
        #endregion

        #region "Stampa Stato Carburante"
        // -------------------- Motodo che Stampa lo Stato dell'Auto --------------------
        public void stampaStato() {
            Console.WriteLine(generaStato());
        }

        public string generaStato() {
            string result;

            result = "Livello Carburante: " + this.livelloCarburante + " l\n" +
                     "Velocità: " + this.livelloVelocita + " km/h\n";

            if (this.accesa == true) {
                result += "Stato Veicolo: ACCESO";
            } else {
                result += "Stato Veicolo: SPENTO";
            }

            return result;
        }

        // -------------------- Motodo che Stampa lo Stato dell'Auto --------------------
        public void stampaStatoNoStato()
        {
            Console.WriteLine(generaStatoNoStato());
        }

        public string generaStatoNoStato()
        {
            string result;
            result = "Livello Carburante: " + this.livelloCarburante + " l\n" +
                     "Velocità: " + this.livelloVelocita + " km/h";
            return result;
        }
        #endregion

        #region "Stampa Stato Velocità"
        // -------------------- Motodo che Stampa lo Stato dell'Auto --------------------
        public void stampaStatoVel()
        {
            Console.WriteLine(generaStatoVel());
        }

        public string generaStatoVel()
        {
            string result;

            result = "Velocità: " + this.livelloVelocita + " km/h";

            return result;
        }
        #endregion

        #region "Stampa Stato Automobile"
        // -------------------- Motodo che Stampa la Descrizione dell'Auto --------------------
        public void stampaStatoAutomobile()
        {
            Console.WriteLine(generaStatoAutomobile());
        }

        private string generaStatoAutomobile()
        {
            string result;

            result = "\nMarca: " + this.marca + "\n";
            result += $"Modello: {this.modello}\n";
            result += $"Colore: {this.colore}\n";
            result += "Tipo Motore: " + this.tipoMotore + "\n";
            result += "Livello Carburante: " + this.livelloCarburante + " l\n";
            result += "Velocità: " + this.livelloVelocita + " km/h\n";

            if (this.accesa == true)
            {
                result += "Stato Veicolo: ACCESO";
            }
            else
            {
                result += "Stato Veicolo: SPENTO";
            }

            return result;
        }
        #endregion
    }

}
