using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelikaiMalaSlova
{
    public partial class VelikaIMalaSlova : Form
    {
        public VelikaIMalaSlova()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                String Input = textBoxUnosTeksta.Text;
        }

    }
}
