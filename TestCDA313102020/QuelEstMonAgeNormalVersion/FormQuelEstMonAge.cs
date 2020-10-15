using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuelEstMonAge
{
    public partial class FormQuelEstMonAge : Form
    {
        public FormQuelEstMonAge()
        {
            InitializeComponent();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Le champs du nom est vide, merci d'écrire un nom", "Erreur",
                                                                                            MessageBoxButtons.OK,
                                                                                            MessageBoxIcon.Error
                                                                                            );
            }
            else if (dateAnniv.Value > DateTime.Now)
            {
                MessageBox.Show("Votre date d'anniversaire est supérieur à la date du jour, venez-vous du futur ?", "Erreur",
                                                                                                                            MessageBoxButtons.OK,
                                                                                                                            MessageBoxIcon.Error
                                                                                                                            );
            }
            else 
            { 
                int ageCalcule;
                if (DateTime.Now.Year == dateAnniv.Value.Year && DateTime.Now.Month == dateAnniv.Value.Month && DateTime.Now.Day == dateAnniv.Value.Day)
                {
                MessageBox.Show("Ce petit enfant qui se nomme " + txtNom.Text + " vient d'être mis au monde aujourd'hui, félicitation !",
                                                                                                                                        "Félicitation",
                                                                                                                                        MessageBoxButtons.OK,
                                                                                                                                        MessageBoxIcon.Information
                                                                                                                                        );
                }
                else if (DateTime.Now.Year == dateAnniv.Value.Year && DateTime.Now.Month == dateAnniv.Value.Month && DateTime.Now.Day > dateAnniv.Value.Day)
                {
                    MessageBox.Show("Ce petit enfant qui se nomme " + txtNom.Text + " est tout jeune, il est dans sa première année.",
                                                                                                                                        "Super!",
                                                                                                                                        MessageBoxButtons.OK,
                                                                                                                                        MessageBoxIcon.Information
                                                                                                                                        );
                }
                else if (DateTime.Now.Day > dateAnniv.Value.Day && DateTime.Now.Month == dateAnniv.Value.Month)
                {
                    ageCalcule = (DateTime.Now.Year - dateAnniv.Value.Year);
                    ageCalcule--;
                    CalculeAge(ageCalcule);
                }
                else
                {
                    ageCalcule = DateTime.Now.Year - dateAnniv.Value.Year;
                    CalculeAge(ageCalcule);
                }
            }
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormQuelEstMonAge_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Souhaitez-vous vraiment fermer cette fenêtre ?",
            "Fermeture",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            e.Cancel = (result == DialogResult.No);

        }
        #region fonctions
        private void CalculeAge(int ageCalcule)
        {
            string result = Convert.ToString(ageCalcule);
            MessageBox.Show("Bonjour " + txtNom.Text + " vous avez " + ageCalcule + "ans!",
                                                                                            "Votre âge",
                                                                                            MessageBoxButtons.OK,
                                                                                            MessageBoxIcon.Information
                                                                                            );
        }
        #endregion
    }
}
