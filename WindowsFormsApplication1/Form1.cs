using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dorucak_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Rucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Dodali ste:" + Environment.NewLine);
          
            if(Dorucak.Checked) {
                textBox1.AppendText("Dorucak" + Environment.NewLine);
            }
            if (Rucak.Checked)
            {
                textBox1.AppendText("Rucak" + Environment.NewLine);
            }
            if (Vecera.Checked)
            {
                textBox1.AppendText("Vecera" + Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
