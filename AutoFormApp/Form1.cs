using System.Windows.Forms;

namespace AutoFormApp
{
    public partial class AutoFormApp : Form
    {
        prima_app.Auto automobile = new prima_app.Auto();
        public AutoFormApp()
        {
            InitializeComponent();
        }

        #region " Load "
        private void AutoFormApp_Load(object sender, EventArgs e)
        {
            this.speedUp.Visible = false;
            this.slowDown.Visible = false;
            this.pictureON.Visible = false;
            this.pictureOFF.Visible = false;

            this.KM.Minimum = 0;
            this.KM.Maximum = automobile.livelloMaxVelocita;
            this.kmS.Text = "0 Km/h";
            this.kmD.Text = automobile.livelloMaxVelocita + " Km/h";

            this.carburante.Minimum = 0;
            this.carburante.Maximum = automobile.livelloMaxCarburante;
            this.lS.Text = "0 l";
            this.lD.Text = automobile.livelloMaxCarburante + " l";

            this.valoreCarburante.Visible = false;
            this.valoreVelocita.Visible = false;
        }
        #endregion

        #region " Power On "
        private void powerON_Click(object sender, EventArgs e)
        {           
            automobile.accendi();

            if (automobile.isAccesa() == true)
            {
                this.pictureON.Visible = true;
                this.pictureOFF.Visible = false;

                this.powerOn.Visible = false;
                this.powerOff.Visible = true;
                this.speedUp.Visible = true;
                this.slowDown.Visible = true;
                this.status.Location = new Point(697, 12);

                this.aggiornaCarburante();
                this.aggiornaVelocita();
            }
            else
            {
                this.pictureON.Visible = false;
                this.pictureOFF.Visible = true;

                this.powerOn.Visible = true;
                this.powerOff.Visible = false;
                this.speedUp.Visible = false;
                this.slowDown.Visible = false;
                this.status.Location = new Point(351, 12);

                this.aggiornaCarburante();
                this.aggiornaVelocita();
            }           
        }
        #endregion

        #region " Carburante - Velocità "
        private void aggiornaCarburante()
        {
            this.valoreCarburante.Visible = true;
            this.carburante.Value = automobile.livelloCarburante;
            this.valoreCarburante.Text = automobile.livelloCarburante.ToString();
        }

        private void aggiornaVelocita()
        {
            this.valoreVelocita.Visible = true;
            this.KM.Value = automobile.livelloVelocita;
            this.valoreVelocita.Text = automobile.livelloVelocita.ToString();
        }
        #endregion

        #region " Power Off "
        private void powerOff_Click(object sender, EventArgs e)
        {
            automobile.spegni();

            if (automobile.isAccesa() == true)
            {
                this.powerOn.Visible = false;
                this.powerOff.Visible = true;

                this.speedUp.Visible = true;
                this.slowDown.Visible = true;
                this.status.Location = new Point(697, 12);

                this.pictureON.Visible = true;
                this.pictureOFF.Visible = false;
            }
            else
            {
                this.powerOn.Visible = true;
                this.powerOff.Visible = false;

                this.speedUp.Visible = false;
                this.slowDown.Visible = false;
                this.status.Location = new Point(351, 12);

                this.pictureON.Visible = false;
                this.pictureOFF.Visible = true;
            }
        }
        #endregion

        #region " Linea "
        private void linea_Paint(object sender, PaintEventArgs e)
        {
            // Ottieni l'oggetto Graphics del Panel
            Graphics g = e.Graphics;

            // Definisci il colore e lo spessore della linea
            Pen lineaPen = new Pen(Color.Black, 2);

            // Punto di inizio della linea
            Point puntoInizio = new Point(5, 20);

            // Punto di fine della linea
            Point puntoFine = new Point(820, 20);

            // Disegna la linea
            g.DrawLine(lineaPen, puntoInizio, puntoFine);

            // Rilascia le risorse
            lineaPen.Dispose();
        }
        #endregion

        #region " Refueling "
        private void refueling_Click(object sender, EventArgs e)
        {
            automobile.rifornisci(10);
            this.aggiornaCarburante();
        }
        #endregion

        #region " Speed Up "
        private void speedUp_Click(object sender, EventArgs e)
        {
            if (automobile.isAccesa() == true)
            {
                automobile.accelera(2);
                this.aggiornaVelocita();
                this.aggiornaCarburante();
            }
            else
            {
                //  Messaggio Errore
            }
        }
        #endregion

        #region " Slow Down "
        private void slowDown_Click(object sender, EventArgs e)
        {
            if (automobile.isAccesa() == true)
            {
                automobile.decelera(2);
                this.aggiornaVelocita();
                this.aggiornaCarburante();
            }
            else
            {
                //  Messaggio Errore
            }
        }
        #endregion

        #region " Status "
        private void status_Click(object sender, EventArgs e)
        {
            Status status = new Status(this.automobile);
            status.ShowDialog();
        }
        #endregion
    }
}