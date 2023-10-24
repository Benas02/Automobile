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
    public partial class SpeedUp : Form
    {
        public int value;
        public SpeedUp()
        {
            InitializeComponent();
        }

        private void btnSpeedUp_Click(object sender, EventArgs e)
        {
            string textboxValue = this.textSpeedUp.Text;
            this.value = Int32.Parse(textboxValue);
            this.Close();
        }
    }
}
