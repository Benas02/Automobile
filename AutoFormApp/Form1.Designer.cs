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
            powerOn = new Button();
            refueling = new Button();
            speedUp = new Button();
            slowDown = new Button();
            powerOff = new Button();
            status = new Button();
            linea = new Panel();
            pictureON = new PictureBox();
            pictureOFF = new PictureBox();
            pictureBox1 = new PictureBox();
            KM = new ProgressBar();
            kmS = new Label();
            kmD = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOFF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureON.Size = new Size(307, 270);
            pictureON.TabIndex = 9;
            pictureON.TabStop = false;
            // 
            // pictureOFF
            // 
            pictureOFF.BackgroundImage = Properties.Resources.OFF;
            pictureOFF.BackgroundImageLayout = ImageLayout.Zoom;
            pictureOFF.Location = new Point(21, 128);
            pictureOFF.Name = "pictureOFF";
            pictureOFF.Size = new Size(307, 270);
            pictureOFF.TabIndex = 10;
            pictureOFF.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.KM1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(371, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 236);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
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
            kmS.Location = new Point(404, 430);
            kmS.Name = "kmS";
            kmS.Size = new Size(17, 20);
            kmS.TabIndex = 13;
            kmS.Text = "└";
            // 
            // kmD
            // 
            kmD.Location = new Point(725, 429);
            kmD.Name = "kmD";
            kmD.Size = new Size(55, 20);
            kmD.TabIndex = 14;
            kmD.Text = "┘";
            kmD.TextAlign = ContentAlignment.TopRight;
            // 
            // AutoFormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 458);
            Controls.Add(kmD);
            Controls.Add(kmS);
            Controls.Add(KM);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private ProgressBar KM;
        private Label kmS;
        private Label kmD;
    }
}