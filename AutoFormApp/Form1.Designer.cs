namespace AutoFormApp
{
    partial class AutoFormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            powerOn = new Button();
            refueling = new Button();
            speedUp = new Button();
            slowDown = new Button();
            powerOff = new Button();
            status = new Button();
            linea = new Panel();
            pictureON = new PictureBox();
            pictureOFF = new PictureBox();
            contachilometri = new PictureBox();
            KM = new ProgressBar();
            kmS = new Label();
            kmD = new Label();
            carburante = new ProgressBar();
            lS = new Label();
            lD = new Label();
            valoreCarburante = new Label();
            valoreVelocita = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOFF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contachilometri).BeginInit();
            SuspendLayout();
            // 
            // powerOn
            // 
            powerOn.BackColor = Color.Gainsboro;
            powerOn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            powerOn.ForeColor = SystemColors.ControlDarkDark;
            powerOn.Location = new Point(12, 12);
            powerOn.Name = "powerOn";
            powerOn.Size = new Size(150, 60);
            powerOn.TabIndex = 2;
            powerOn.Text = "POWER ON";
            powerOn.UseVisualStyleBackColor = false;
            powerOn.Click += powerON_Click;
            // 
            // refueling
            // 
            refueling.BackColor = Color.Gainsboro;
            refueling.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            refueling.ForeColor = SystemColors.ControlDarkDark;
            refueling.Location = new Point(178, 12);
            refueling.Name = "refueling";
            refueling.Size = new Size(150, 60);
            refueling.TabIndex = 3;
            refueling.Text = "REFUELING";
            refueling.UseVisualStyleBackColor = false;
            refueling.Click += refueling_Click;
            // 
            // speedUp
            // 
            speedUp.BackColor = Color.Gainsboro;
            speedUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            speedUp.ForeColor = SystemColors.ControlDarkDark;
            speedUp.Location = new Point(351, 12);
            speedUp.Name = "speedUp";
            speedUp.Size = new Size(150, 60);
            speedUp.TabIndex = 4;
            speedUp.Text = "SPEED UP";
            speedUp.UseVisualStyleBackColor = false;
            speedUp.Click += speedUp_Click;
            // 
            // slowDown
            // 
            slowDown.BackColor = Color.Gainsboro;
            slowDown.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            slowDown.ForeColor = SystemColors.ControlDarkDark;
            slowDown.Location = new Point(524, 12);
            slowDown.Name = "slowDown";
            slowDown.Size = new Size(150, 60);
            slowDown.TabIndex = 5;
            slowDown.Text = "SLOW DOWN";
            slowDown.UseVisualStyleBackColor = false;
            slowDown.Click += slowDown_Click;
            // 
            // powerOff
            // 
            powerOff.BackColor = Color.Gainsboro;
            powerOff.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            powerOff.ForeColor = SystemColors.ControlDarkDark;
            powerOff.Location = new Point(12, 12);
            powerOff.Name = "powerOff";
            powerOff.Size = new Size(150, 60);
            powerOff.TabIndex = 6;
            powerOff.Text = "POWER OFF";
            powerOff.UseVisualStyleBackColor = false;
            powerOff.Click += powerOff_Click;
            // 
            // status
            // 
            status.BackColor = Color.Gainsboro;
            status.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            status.ForeColor = SystemColors.ControlDarkDark;
            status.Location = new Point(351, 12);
            status.Name = "status";
            status.Size = new Size(120, 60);
            status.TabIndex = 7;
            status.Text = "STATUS";
            status.UseVisualStyleBackColor = false;
            status.Click += status_Click;
            // 
            // linea
            // 
            linea.Location = new Point(3, 78);
            linea.Name = "linea";
            linea.Size = new Size(826, 24);
            linea.TabIndex = 8;
            linea.Paint += linea_Paint;
            // 
            // pictureON
            // 
            pictureON.BackgroundImage = Properties.Resources.ON;
            pictureON.BackgroundImageLayout = ImageLayout.Zoom;
            pictureON.Location = new Point(21, 128);
            pictureON.Name = "pictureON";
            pictureON.Size = new Size(307, 236);
            pictureON.TabIndex = 9;
            pictureON.TabStop = false;
            // 
            // pictureOFF
            // 
            pictureOFF.BackgroundImage = Properties.Resources.OFF;
            pictureOFF.BackgroundImageLayout = ImageLayout.Zoom;
            pictureOFF.Location = new Point(21, 128);
            pictureOFF.Name = "pictureOFF";
            pictureOFF.Size = new Size(307, 236);
            pictureOFF.TabIndex = 10;
            pictureOFF.TabStop = false;
            // 
            // contachilometri
            // 
            contachilometri.BackColor = Color.Transparent;
            contachilometri.BackgroundImage = Properties.Resources.KM1;
            contachilometri.BackgroundImageLayout = ImageLayout.Zoom;
            contachilometri.Location = new Point(371, 128);
            contachilometri.Name = "contachilometri";
            contachilometri.Size = new Size(431, 236);
            contachilometri.TabIndex = 11;
            contachilometri.TabStop = false;
            // 
            // KM
            // 
            KM.Location = new Point(404, 388);
            KM.Name = "KM";
            KM.Size = new Size(376, 39);
            KM.TabIndex = 12;
            // 
            // kmS
            // 
            kmS.AutoSize = true;
            kmS.Location = new Point(390, 430);
            kmS.Name = "kmS";
            kmS.Size = new Size(19, 20);
            kmS.TabIndex = 13;
            kmS.Text = "A";
            // 
            // kmD
            // 
            kmD.Location = new Point(673, 430);
            kmD.Name = "kmD";
            kmD.Size = new Size(129, 20);
            kmD.TabIndex = 14;
            kmD.Text = "A";
            kmD.TextAlign = ContentAlignment.TopRight;
            // 
            // carburante
            // 
            carburante.Location = new Point(33, 388);
            carburante.Name = "carburante";
            carburante.Size = new Size(272, 39);
            carburante.TabIndex = 15;
            // 
            // lS
            // 
            lS.AutoSize = true;
            lS.Location = new Point(23, 430);
            lS.Name = "lS";
            lS.Size = new Size(17, 20);
            lS.TabIndex = 16;
            lS.Text = "0";
            // 
            // lD
            // 
            lD.AutoSize = true;
            lD.Location = new Point(274, 430);
            lD.Name = "lD";
            lD.Size = new Size(17, 20);
            lD.TabIndex = 17;
            lD.Text = "0";
            // 
            // valoreCarburante
            // 
            valoreCarburante.AutoSize = true;
            valoreCarburante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valoreCarburante.Location = new Point(148, 397);
            valoreCarburante.Name = "valoreCarburante";
            valoreCarburante.Size = new Size(36, 20);
            valoreCarburante.TabIndex = 18;
            valoreCarburante.Text = "999";
            // 
            // valoreVelocita
            // 
            valoreVelocita.AutoSize = true;
            valoreVelocita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valoreVelocita.Location = new Point(574, 397);
            valoreVelocita.Name = "valoreVelocita";
            valoreVelocita.Size = new Size(36, 20);
            valoreVelocita.TabIndex = 19;
            valoreVelocita.Text = "999";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // AutoFormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 464);
            Controls.Add(valoreVelocita);
            Controls.Add(valoreCarburante);
            Controls.Add(lD);
            Controls.Add(lS);
            Controls.Add(carburante);
            Controls.Add(kmD);
            Controls.Add(kmS);
            Controls.Add(KM);
            Controls.Add(contachilometri);
            Controls.Add(pictureOFF);
            Controls.Add(pictureON);
            Controls.Add(linea);
            Controls.Add(status);
            Controls.Add(slowDown);
            Controls.Add(speedUp);
            Controls.Add(refueling);
            Controls.Add(powerOn);
            Controls.Add(powerOff);
            Name = "AutoFormApp";
            Text = "Auto Form App";
            Load += AutoFormApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureON).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOFF).EndInit();
            ((System.ComponentModel.ISupportInitialize)contachilometri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button powerOn;
        private Button refueling;
        private Button speedUp;
        private Button slowDown;
        private Button powerOff;
        private Button status;
        private Panel linea;
        private PictureBox pictureON;
        private PictureBox pictureOFF;
        private PictureBox contachilometri;
        private ProgressBar KM;
        private Label kmS;
        private Label kmD;
        private ProgressBar carburante;
        private Label lS;
        private Label lD;
        private Label valoreCarburante;
        private Label valoreVelocita;
        private System.Windows.Forms.Timer timer1;
    }
}