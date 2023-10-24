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
    public partial class SlowDown : Form
    {
        public int value;
        public SlowDown()
        {
            InitializeComponent();
        }

        private void btnSlowDown_Click(object sender, EventArgs e)
        {
            string textboxValue = this.textSlowDown.Text;
            this.value = Int32.Parse(textboxValue);
            this.Close();
        }
    }
}
