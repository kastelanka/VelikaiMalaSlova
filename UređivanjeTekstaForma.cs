using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelikaiMalaSlova
{
    public partial class UređivanjeTekstaForma : Form
    {
        public String Input;

        public UređivanjeTekstaForma()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void allCapitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != null)
            {
                var svaVelika = richTextBox1.SelectedText.ToUpper();
                richTextBox1.SelectedText = svaVelika;
            }
        }

        private void spellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox textSpelling = new RichTextBox();
            var selectedTextLower = richTextBox1.SelectedText.ToLower();
            String[] textArraySplit = Regex.Split(selectedTextLower, @"(?<=[\.!\?])\s+");
            
            foreach (var sentence in textArraySplit)
            {
                textSpelling.AppendText(UppercaseFirst(sentence));
            }

            richTextBox1.SelectedText = textSpelling.Text;
        }


        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
