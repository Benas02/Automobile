namespace AutoFormApp
{
    partial class SpeedUp
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
            labelRifornimento = new Label();
            btnSpeedUp = new Button();
            textSpeedUp = new TextBox();
            SuspendLayout();
            // 
            // labelRifornimento
            // 
            labelRifornimento.AutoSize = true;
            labelRifornimento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRifornimento.Location = new Point(35, 9);
            labelRifornimento.Name = "labelRifornimento";
            labelRifornimento.Size = new Size(329, 25);
            labelRifornimento.TabIndex = 7;
            labelRifornimento.Text = "How much do you want to speed up ?";
            labelRifornimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSpeedUp
            // 
            btnSpeedUp.BackColor = Color.Gainsboro;
            btnSpeedUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSpeedUp.ForeColor = SystemColors.ControlDarkDark;
            btnSpeedUp.Location = new Point(119, 134);
            btnSpeedUp.Name = "btnSpeedUp";
            btnSpeedUp.Size = new Size(150, 60);
            btnSpeedUp.TabIndex = 8;
            btnSpeedUp.Text = "SPEED UP";
            btnSpeedUp.UseVisualStyleBackColor = false;
            btnSpeedUp.Click += btnSpeedUp_Click;
            // 
            // textSpeedUp
            // 
            textSpeedUp.Location = new Point(148, 72);
            textSpeedUp.Name = "textSpeedUp";
            textSpeedUp.Size = new Size(98, 27);
            textSpeedUp.TabIndex = 9;
            textSpeedUp.TextAlign = HorizontalAlignment.Center;
            // 
            // SpeedUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Strada;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(397, 218);
            Controls.Add(textSpeedUp);
            Controls.Add(btnSpeedUp);
            Controls.Add(labelRifornimento);
            Name = "SpeedUp";
            Text = "SpeedUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRifornimento;
        private Button btnSpeedUp;
        private TextBox textSpeedUp;
    }
}