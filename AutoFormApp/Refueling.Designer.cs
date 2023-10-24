namespace AutoFormApp
{
    partial class Refueling
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
            rifornimento = new Button();
            textRifornimento = new TextBox();
            labelRifornimento = new Label();
            SuspendLayout();
            // 
            // rifornimento
            // 
            rifornimento.BackColor = Color.Gainsboro;
            rifornimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rifornimento.ForeColor = SystemColors.ControlDarkDark;
            rifornimento.Location = new Point(119, 134);
            rifornimento.Name = "rifornimento";
            rifornimento.Size = new Size(150, 60);
            rifornimento.TabIndex = 4;
            rifornimento.Text = "REFUELING";
            rifornimento.UseVisualStyleBackColor = false;
            rifornimento.Click += rifornimento_Click;
            // 
            // textRifornimento
            // 
            textRifornimento.Location = new Point(148, 72);
            textRifornimento.Name = "textRifornimento";
            textRifornimento.Size = new Size(98, 27);
            textRifornimento.TabIndex = 5;
            textRifornimento.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRifornimento
            // 
            labelRifornimento.AutoSize = true;
            labelRifornimento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRifornimento.Location = new Point(35, 9);
            labelRifornimento.Name = "labelRifornimento";
            labelRifornimento.Size = new Size(326, 25);
            labelRifornimento.TabIndex = 6;
            labelRifornimento.Text = "How much Petrol you want to Insert ?";
            labelRifornimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Refueling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GAS;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(397, 218);
            Controls.Add(labelRifornimento);
            Controls.Add(textRifornimento);
            Controls.Add(rifornimento);
            DoubleBuffered = true;
            Name = "Refueling";
            Text = "Refuiling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rifornimento;
        private TextBox textRifornimento;
        private Label labelRifornimento;
    }
}