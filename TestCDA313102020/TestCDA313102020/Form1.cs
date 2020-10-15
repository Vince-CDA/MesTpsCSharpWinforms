using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCDA313102020
{
        /// <summary>
        ///Initialisation de la fenêtre et de ses composants (contrôles)
        /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Les constantes sont initialisés, elles ne peuvent être modifiées par la suite, elles sont en majuscule pour souligner ceci
        /// </summary>
        const string TITRE = "Fermeture";
        const string MESSAGE = "Voulez-vous fermer ce programme ?";
        const string PUB = "A bientôt, n'hésitez pas à visiter mon site : www.cda27.2isa.org";
        public Form1()
        {
            InitializeComponent();
        }
        
        
        #region Mes events


        private void button1_Click(object sender, EventArgs e)
        {
            //Je ferme la fenêtre
            this.Close();
        }

        /// <summary>
        /// Quand la fenêtre se ferme, je peux écrire du code qui sera executé juste avant, l'action ne peut pas être annulée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(PUB);
        }
        /// <summary>
        /// Quand je souhaite fermer la fenêtre (au Close() ou à la croix en haut à droite)
        /// </summary>
        /// <param name="sender">L'object (la Form)</param>
        /// <param name="e">Les paramêtres de l'evenement (Un e.Cancel pour annuler l'event)</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            //J'ouvre une modal avec message/titre/boutons/icone/bouton par défaut
            DialogResult result = MessageBox.Show(  
                                                    MESSAGE,
                                                    TITRE,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button2
                                                  );
            //Si le bouton "No" est cliqué, alors j'annule l'action de fermeture
            e.Cancel = (result == DialogResult.No);
        }

        #endregion
    }
}
