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
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                btCE.PerformClick();
                
            }
            if (e.KeyChar == '+')
            {
                txtZneCalcoule2.Focus();
                txtZneCalcoule2.SelectAll();
            }
        }
        private void btEgalitesh_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtZneCalcoule1.Text, out double first))
            {
                MessageBox.Show("Votre premier nombre n'est pas valide");
                txtZneCalcoule1.Clear();
                txtZneCalcoule1.Focus();
            }
            else if (!double.TryParse(txtZneCalcoule2.Text, out double second))
            {
                MessageBox.Show("Votre second nombre n'est pas valide");
                txtZneCalcoule2.Clear();
                txtZneCalcoule2.Focus();
            }
            else
            {
                double resultat = first + second;
                string txtresultat = Convert.ToString(resultat);
                txtResultosh.Text = txtresultat;
                resetTab();
            }
        }
        private void btCE_Click(object sender, EventArgs e)
        {
            txtZneCalcoule1.Clear();
            txtZneCalcoule2.Clear();
            txtResultosh.Clear();
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
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == '+')
            {
                e.KeyChar = '\0';
            }
            else if (!char.IsDigit(e.KeyChar) &&
             e.KeyChar != (char)Keys.Back &&
             !e.KeyChar.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Caractère interdit");
            }
        }
        #endregion
    }
}
