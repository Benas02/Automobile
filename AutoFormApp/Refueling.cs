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
    public partial class Refueling : Form
    {
        public int value;
        public Refueling()
        {
            InitializeComponent();
        }

        private void rifornimento_Click(object sender, EventArgs e)
        {
            //this.value = this.labelRifornimento.Text;
            //this.Close();

            string textboxValue = this.textRifornimento.Text;
            this.value = Int32.Parse(textboxValue);
            this.Close();
        }
    }
}
