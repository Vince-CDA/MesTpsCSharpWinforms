using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcoulette
{
    public partial class FormCalculette : Form
    {
        internal int invalide;
        public FormCalculette()
        {
            InitializeComponent();
        }
        #region Events
        private void FormCalculette_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Return)
            {
                btEgalitesh.PerformClick();
            }
            if (e.KeyChar == 'c')
            {
                btCE.PerformClick();
                
            }
            if (e.KeyChar == '/')
            {
                txtZneCalcoule2.Focus();
                txtZneCalcoule2.SelectAll();
            }
        }
        private void btEgalitesh_Click(object sender, EventArgs e)
        {
            int pgcd1;
            int result1;
            int result2;
            if (!Int32.TryParse(txtZneCalcoule1.Text, out int first) || txtZneCalcoule1.Text == "0")
            {
                MessageBox.Show("Votre premier nombre n'est pas valide");
                txtZneCalcoule1.Focus();
                txtZneCalcoule1.SelectAll();
            }
            else if (!Int32.TryParse(txtZneCalcoule2.Text, out int second) || txtZneCalcoule2.Text == "0")
            {
                MessageBox.Show("Votre second nombre n'est pas valide");
                txtZneCalcoule2.Focus();
                txtZneCalcoule2.SelectAll();
            }
            else
            {
                
                pgcd1 = pgcd(first, second);
                if (pgcd1 == 1)
                {
                    result1 = first;
                    result2 = second;
                }
                else
                {
                    result1 = first / pgcd1;
                    result2 = second / pgcd1;
                }
                string txtresult1 = Convert.ToString(result1);
                string txtresult2 = Convert.ToString(result2);
                txtNumera.Text = txtresult1;
                txtDenomi.Text = txtresult2;
                resetTab();
                }
            
        }
        private void btCE_Click(object sender, EventArgs e)
        {
            txtZneCalcoule1.Clear();
            txtZneCalcoule2.Clear();
            txtNumera.Clear();
            txtDenomi.Clear();
            resetTab();
        }
        private void txtZneCalcoule1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleDigital(e);
        }
        private void txtZneCalcoule2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleDigital(e);
        }
        private void txtZneCalcoule1_Enter(object sender, EventArgs e)
        {
            txtZneCalcoule1.SelectAll();
        }
        private void txtZneCalcoule2_Enter(object sender, EventArgs e)
        {
            txtZneCalcoule2.SelectAll();
        }
        #endregion
        #region Mes fonctions
        private void resetTab()
        {
            txtZneCalcoule1.Focus();
            txtZneCalcoule1.SelectAll();
        }
        private void ControleDigital(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
             !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caractère interdit");
            }
        }
        private int pgcd(int a, int b)
        {
            int r, t;
            if (b > a)
            {
                t = a;
                a = b;
                b = t;
            }
            do
            {
                r = a % b;
                a = b;
                b = r;
            } while (r != 0);
            return a;
        }
        #endregion
    }
}
