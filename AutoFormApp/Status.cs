using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFormApp
{
    public partial class Status : Form
    {
        private prima_app.Auto automobile;
        public Status(prima_app.Auto automobile)
        {
            InitializeComponent();

            this.automobile = automobile;

            this.marcaVeicolo.Text = "Marca: " + automobile.marca;
            this.modelloVeicolo.Text = "Modello: " + automobile.modello;
            this.motoreVeicolo.Text = "Motore: " + automobile.tipoMotore;
            this.coloreVeicolo.Text = "Colore: " + automobile.colore;
            this.carburanteVeicolo.Text = "Lvl Carburante: " + automobile.livelloCarburante + " l";
            this.velocitaVeicolo.Text = "Lvl Velocità: " + automobile.livelloVelocita + " Km/h";
        }

    }
}
