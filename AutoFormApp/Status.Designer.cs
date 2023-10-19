namespace AutoFormApp
{
    partial class Status
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            marcaVeicolo = new Button();
            motoreVeicolo = new Button();
            modelloVeicolo = new Button();
            coloreVeicolo = new Button();
            carburanteVeicolo = new Button();
            velocitaVeicolo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.tesla;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(63, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 271);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // marcaVeicolo
            // 
            marcaVeicolo.BackColor = Color.Gainsboro;
            marcaVeicolo.Enabled = false;
            marcaVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            marcaVeicolo.ForeColor = SystemColors.ControlDarkDark;
            marcaVeicolo.Location = new Point(12, 12);
            marcaVeicolo.Name = "marcaVeicolo";
            marcaVeicolo.Size = new Size(244, 60);
            marcaVeicolo.TabIndex = 2;
            marcaVeicolo.Text = "Marca:";
            marcaVeicolo.UseVisualStyleBackColor = false;
            // 
            // motoreVeicolo
            // 
            motoreVeicolo.BackColor = Color.Gainsboro;
            motoreVeicolo.Enabled = false;
            motoreVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            motoreVeicolo.ForeColor = SystemColors.ControlDarkDark;
            motoreVeicolo.Location = new Point(544, 12);
            motoreVeicolo.Name = "motoreVeicolo";
            motoreVeicolo.Size = new Size(244, 60);
            motoreVeicolo.TabIndex = 3;
            motoreVeicolo.Text = "Motore:";
            motoreVeicolo.UseVisualStyleBackColor = false;
            // 
            // modelloVeicolo
            // 
            modelloVeicolo.BackColor = Color.Gainsboro;
            modelloVeicolo.Enabled = false;
            modelloVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            modelloVeicolo.ForeColor = SystemColors.ControlDarkDark;
            modelloVeicolo.Location = new Point(278, 12);
            modelloVeicolo.Name = "modelloVeicolo";
            modelloVeicolo.Size = new Size(244, 60);
            modelloVeicolo.TabIndex = 4;
            modelloVeicolo.Text = "Modello:";
            modelloVeicolo.UseVisualStyleBackColor = false;
            // 
            // coloreVeicolo
            // 
            coloreVeicolo.BackColor = Color.Gainsboro;
            coloreVeicolo.Enabled = false;
            coloreVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            coloreVeicolo.ForeColor = SystemColors.ControlDarkDark;
            coloreVeicolo.Location = new Point(12, 100);
            coloreVeicolo.Name = "coloreVeicolo";
            coloreVeicolo.Size = new Size(244, 60);
            coloreVeicolo.TabIndex = 5;
            coloreVeicolo.Text = "Colore:";
            coloreVeicolo.UseVisualStyleBackColor = false;
            // 
            // carburanteVeicolo
            // 
            carburanteVeicolo.BackColor = Color.Gainsboro;
            carburanteVeicolo.Enabled = false;
            carburanteVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            carburanteVeicolo.ForeColor = SystemColors.ControlDarkDark;
            carburanteVeicolo.Location = new Point(278, 100);
            carburanteVeicolo.Name = "carburanteVeicolo";
            carburanteVeicolo.Size = new Size(244, 60);
            carburanteVeicolo.TabIndex = 6;
            carburanteVeicolo.Text = "Lvl Carburante:";
            carburanteVeicolo.UseVisualStyleBackColor = false;
            // 
            // velocitaVeicolo
            // 
            velocitaVeicolo.BackColor = Color.Gainsboro;
            velocitaVeicolo.Enabled = false;
            velocitaVeicolo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            velocitaVeicolo.ForeColor = SystemColors.ControlDarkDark;
            velocitaVeicolo.Location = new Point(544, 100);
            velocitaVeicolo.Name = "velocitaVeicolo";
            velocitaVeicolo.Size = new Size(244, 60);
            velocitaVeicolo.TabIndex = 7;
            velocitaVeicolo.Text = "Lvl Velocità:";
            velocitaVeicolo.UseVisualStyleBackColor = false;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(velocitaVeicolo);
            Controls.Add(carburanteVeicolo);
            Controls.Add(coloreVeicolo);
            Controls.Add(modelloVeicolo);
            Controls.Add(motoreVeicolo);
            Controls.Add(marcaVeicolo);
            Controls.Add(pictureBox1);
            Name = "Status";
            Text = "Status Veicolo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button marcaVeicolo;
        private Button motoreVeicolo;
        private Button modelloVeicolo;
        private Button coloreVeicolo;
        private Button carburanteVeicolo;
        private Button velocitaVeicolo;
    }
}