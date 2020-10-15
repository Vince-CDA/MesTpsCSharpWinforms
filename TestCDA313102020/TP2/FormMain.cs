using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{

    public partial class FormMain : Form
    {
        public string futurTitre;
        public FormMain()
        {

            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox texte = (TextBox)sender;
            futurTitre = texte.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (FormFille FormSlave = new FormFille())
            { 
            FormSlave.Text = futurTitre;
            FormSlave.ShowDialog();
            if (FormSlave.DialogResult == DialogResult.OK)
            {
            this.textBox1.Text = FormSlave.textBox2.Text;
            } 
            else
            {
                textBox1.Clear();
            }
            }
        }

    }
}
