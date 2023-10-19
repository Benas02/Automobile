namespace AutoFormApp
{
    public partial class AutoFormApp : Form
    {
        prima_app.Auto automobile = new prima_app.Auto();
        public AutoFormApp()
        {
            InitializeComponent();
        }

        private void AutoFormApp_Load(object sender, EventArgs e)
        {
            this.speedUp.Visible = false;
            this.slowDown.Visible = false;
            this.pictureON.Visible = false;
            this.pictureOFF.Visible = false;

            this.KM.Minimum = 0;
            this.KM.Maximum = automobile.livelloMaxVelocita;
            this.kmS.Text += " 0 KM/H";
            this.kmD.Text = automobile.livelloMaxVelocita + " KM/H " + this.kmD.Text;
        }

        private void powerON_Click(object sender, EventArgs e)
        {
            this.powerOn.Visible = false;
            this.powerOff.Visible = true;
            this.speedUp.Visible = true;
            this.slowDown.Visible = true;
            this.status.Location = new Point(697, 12);

            automobile.accendi();

            if (automobile.isAccesa() == true)
            {
                this.pictureON.Visible = true;
                this.pictureOFF.Visible = false;
            }
            else
            {
                this.pictureON.Visible = false;
                this.pictureOFF.Visible = true;
            }
        }

        private void powerOff_Click(object sender, EventArgs e)
        {
            this.powerOn.Visible = true;
            this.powerOff.Visible = false;
            this.speedUp.Visible = false;
            this.slowDown.Visible = false;
            this.status.Location = new Point(351, 12);

            automobile.spegni();

            if (automobile.isAccesa() == true)
            {
                this.pictureON.Visible = true;
                this.pictureOFF.Visible = false;
            }
            else
            {
                this.pictureON.Visible = false;
                this.pictureOFF.Visible = true;
            }
        }

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
    }
}