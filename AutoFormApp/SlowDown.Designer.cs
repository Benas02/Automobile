namespace AutoFormApp
{
    partial class SlowDown
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
            textSlowDown = new TextBox();
            btnSlowDown = new Button();
            SuspendLayout();
            // 
            // labelRifornimento
            // 
            labelRifornimento.AutoSize = true;
            labelRifornimento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRifornimento.Location = new Point(35, 9);
            labelRifornimento.Name = "labelRifornimento";
            labelRifornimento.Size = new Size(346, 25);
            labelRifornimento.TabIndex = 8;
            labelRifornimento.Text = "How much do you want to Slow Down ?";
            labelRifornimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSlowDown
            // 
            textSlowDown.Location = new Point(148, 72);
            textSlowDown.Name = "textSlowDown";
            textSlowDown.Size = new Size(98, 27);
            textSlowDown.TabIndex = 10;
            textSlowDown.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSlowDown
            // 
            btnSlowDown.BackColor = Color.Gainsboro;
            btnSlowDown.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSlowDown.ForeColor = SystemColors.ControlDarkDark;
            btnSlowDown.Location = new Point(119, 134);
            btnSlowDown.Name = "btnSlowDown";
            btnSlowDown.Size = new Size(150, 60);
            btnSlowDown.TabIndex = 11;
            btnSlowDown.Text = "SLOW DOWN";
            btnSlowDown.UseVisualStyleBackColor = false;
            btnSlowDown.Click += btnSlowDown_Click;
            // 
            // SlowDown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Strada;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(397, 218);
            Controls.Add(btnSlowDown);
            Controls.Add(textSlowDown);
            Controls.Add(labelRifornimento);
            Name = "SlowDown";
            Text = "SlowDown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRifornimento;
        private TextBox textSlowDown;
        private Button btnSlowDown;
    }
}