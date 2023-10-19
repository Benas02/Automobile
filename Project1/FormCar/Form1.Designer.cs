namespace FormCar
{
    partial class FormCar
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
            Menu = new MenuStrip();
            startOption = new ToolStripMenuItem();
            stopOption = new ToolStripMenuItem();
            moveOption = new ToolStripMenuItem();
            accellerateToolStripMenuItem = new ToolStripMenuItem();
            slowDownToolStripMenuItem = new ToolStripMenuItem();
            labelSpeed = new Label();
            labelFuel = new Label();
            lvlfuel = new Button();
            lblfuel = new Label();
            TxtOutput = new RichTextBox();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { startOption, stopOption, moveOption });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(80, 2, 0, 2);
            Menu.Size = new Size(800, 54);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // startOption
            // 
            startOption.AutoSize = false;
            startOption.Name = "startOption";
            startOption.Size = new Size(180, 50);
            startOption.Text = "Start";
            startOption.Click += startOption_Click;
            // 
            // stopOption
            // 
            stopOption.AutoSize = false;
            stopOption.Name = "stopOption";
            stopOption.Size = new Size(180, 50);
            stopOption.Text = "Stop";
            stopOption.Click += stopOption_Click;
            // 
            // moveOption
            // 
            moveOption.AutoSize = false;
            moveOption.DropDownItems.AddRange(new ToolStripItem[] { accellerateToolStripMenuItem, slowDownToolStripMenuItem });
            moveOption.Name = "moveOption";
            moveOption.Size = new Size(180, 50);
            moveOption.Text = "Move";
            // 
            // accellerateToolStripMenuItem
            // 
            accellerateToolStripMenuItem.Name = "accellerateToolStripMenuItem";
            accellerateToolStripMenuItem.Size = new Size(167, 26);
            accellerateToolStripMenuItem.Text = "Accellerate";
            // 
            // slowDownToolStripMenuItem
            // 
            slowDownToolStripMenuItem.Name = "slowDownToolStripMenuItem";
            slowDownToolStripMenuItem.Size = new Size(167, 26);
            slowDownToolStripMenuItem.Text = "Slow Down";
            // 
            // labelSpeed
            // 
            labelSpeed.Location = new Point(0, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(100, 23);
            labelSpeed.TabIndex = 0;
            // 
            // labelFuel
            // 
            labelFuel.Location = new Point(0, 0);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(100, 23);
            labelFuel.TabIndex = 0;
            // 
            // lvlfuel
            // 
            lvlfuel.Location = new Point(674, 396);
            lvlfuel.Name = "lvlfuel";
            lvlfuel.Size = new Size(114, 45);
            lvlfuel.TabIndex = 3;
            lvlfuel.Text = "Refill";
            lvlfuel.UseVisualStyleBackColor = true;
            // 
            // lblfuel
            // 
            lblfuel.AutoSize = true;
            lblfuel.Location = new Point(702, 373);
            lblfuel.Name = "lblfuel";
            lblfuel.Size = new Size(0, 20);
            lblfuel.TabIndex = 6;
            lblfuel.Text = "Fuel: " + myCar.petrolLevel;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(12, 77);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(776, 65);
            TxtOutput.TabIndex = 9;
            TxtOutput.Text = "";
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(lblfuel);
            Controls.Add(lvlfuel);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "FormCar";
            Text = "Form Car";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem startOption;
        private ToolStripMenuItem stopOption;
        private ToolStripMenuItem moveOption;
        private ToolStripMenuItem accellerateToolStripMenuItem;
        private ToolStripMenuItem slowDownToolStripMenuItem;
        private Label labelSpeed;
        private Label labelFuel;
        private Button lvlfuel;
        private Label lblfuel;
        private RichTextBox TxtOutput;
    }
}