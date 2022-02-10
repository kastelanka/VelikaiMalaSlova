using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelikaiMalaSlova
{
    public partial class UređivanjeTekstaForma : Form
    {
        //definiranje moj dogadaja za slanje poruke
        public delegate void SaveFileEventHandler(object sender, SaveFileEventArgs sf);

        public event SaveFileEventHandler ClickSave;

        public String Input;

        public UređivanjeTekstaForma()
        {
            InitializeComponent();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{ 
        //    Input = richTextBox1.Text;
        //}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);

            }
        }
    }

}
