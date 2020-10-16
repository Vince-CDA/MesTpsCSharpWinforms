using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
        private const string NOMPARDEFAUT = "Quel est votre nom ?";
        private const string TITREERREUR = "Erreur!";
        private const string TITREFELICITATION = "Félicitation!";
        private const string TITRESUPER = "Super!";
        private const string TITREFERMETURE = "Fermeture";
        private const string MESSAGEFERMETURE = "Souhaitez-vous vraiment fermer cette fenêtre ?";
        private const string MESSAGEFUTURE = "Votre date d'anniversaire est supérieur à la date du jour, venez-vous du futur ?";
        private const string MESSAGECHAMPSVIDE = "Le champs du nom est vide, merci d'écrire un nom.";
        private const string MESSAGETOUTJEUNE = "Ce petit enfant qui se nomme {0} est tout jeune, il est dans sa première année.";
        private const string MESSAGEMISAUMONDE = "Ce petit enfant qui se nomme {0} vient d'être mis au monde aujourd'hui, félicitation !";
        private void btCalculer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show(MESSAGECHAMPSVIDE, 
                                TITREERREUR,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            else if (dateAnniv.Value > DateTime.Now)
            {
                MessageBox.Show(MESSAGEFUTURE, 
                                TITREERREUR,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            else 
            {
                
                int ageCalcule;
                if (DateTime.Now.Year == dateAnniv.Value.Year && DateTime.Now.Month == dateAnniv.Value.Month && DateTime.Now.Day == dateAnniv.Value.Day)
                {
                MessageBox.Show(String.Format(MESSAGEMISAUMONDE, txtNom.Text),
                                TITREFELICITATION,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                }
                else if (DateTime.Now.Year == dateAnniv.Value.Year && DateTime.Now.Month == dateAnniv.Value.Month && DateTime.Now.Day > dateAnniv.Value.Day)
                {
                    MessageBox.Show(String.Format(MESSAGETOUTJEUNE, txtNom.Text),
                                    TITRESUPER,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
                else if (DateTime.Now.Month > dateAnniv.Value.Month || (DateTime.Now.Day > dateAnniv.Value.Day && DateTime.Now.Month == dateAnniv.Value.Month))
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
            DialogResult result = MessageBox.Show(MESSAGEFERMETURE,
                                                    TITREFERMETURE,
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

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                btCalculer.Enabled = false;
            }
            else
            {
                btCalculer.Enabled = true;
            }
        }

        private void FormQuelEstMonAge_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.DtNaiss = dateAnniv.Value;
            Properties.Settings.Default.Nom = txtNom.Text;
            Properties.Settings.Default.LocalisationFenetre = Location;
            Properties.Settings.Default.Save();
        }

        private void FormQuelEstMonAge_Load(object sender, EventArgs e)
        {
            txtNom.Text = NOMPARDEFAUT;
            Point loc = new Point(0, 0);
            txtNom.Text = Properties.Settings.Default.Nom;
            dateAnniv.Value = Properties.Settings.Default.DtNaiss;
            if (Properties.Settings.Default.LocalisationFenetre == loc)
            {
                this.CenterToScreen();
            }
            else
            {
            Location = Properties.Settings.Default.LocalisationFenetre;
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == NOMPARDEFAUT)
            {
                txtNom.Clear();
            }
            else
            {
                txtNom.SelectAll();
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                txtNom.Text = NOMPARDEFAUT;
            }
        }
    }
}
