using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChercheLeCheminDeMonImage
{
    public partial class ChercheMonFichierImageForm : Form
    {
        #region OPENFILEDIALOG
        private const string STR_INITIAL_DIRECTORY = "c:\\";
        private const string STR_FILTER = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
        #endregion

        #region Titres MessageBox
        private const string STR_TITRE_ERREUR = "Erreur";
        private const string STR_TITRE_SUPPRESSION = "Suppression";
        #endregion

        #region Textes MessageBox
        private const string STR_SUPPRESSION = "Souhaitez-vous vraiment supprimer cet élément ?";
        private const string STR_ITEM_EXIST = "Ce fichier existe déjà";
        private const string STR_FICHIER_INTROUVABLE = "Fichier introuvable";
        #endregion

        #region Chargement de la fenêtre et de ses composants
        public ChercheMonFichierImageForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Clique sur parcourir le disque dur
        private void btParcourir_Click(object sender, EventArgs e)
        {
            #region Initialisation du chemin d'accès à vide 
            var filePath = string.Empty;
            #endregion

            #region Using de l'OpenFileDialog au chemin initié avec le filtrage intitié
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = STR_INITIAL_DIRECTORY;
                openFileDialog.Filter = STR_FILTER;
                
                #region Si un fichier est selectionné alors le chemin est enregistré
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
                #endregion

            }
            #endregion

            #region Le texte du chemin devient le chemin enregistré
            txtChemin.Text = filePath;
            #endregion

        }
        #endregion

        #region Bouton ajouter
        private void btAjouter_Click(object sender, EventArgs e)
        {
            #region Initialisation d'un int et d'un boolean
            int compareFichier = '\0';
            bool existe = false;
            #endregion

            #region Si il n'y a pas d'item dans la liste alors j'ajoute l'item, active "vider" et vide mon chemin d'accès
            if (listFichiers.Items.Count == 0)
            {
                btVider.Enabled = true;
                listFichiers.Items.Add(txtChemin.Text);
                txtChemin.Text = null;
                return;
            }
            #endregion

            #region Doublon de chemin avec Contains en prenant en compte la casse (Non utilisé)
            //Si il y a un doublon de chemin...
            //if (listFichiers.Items.Contains(txtChemin.Text))
            //{
            //    existe = true;
            //    MessageBox.Show(STR_ITEM_EXIST, STR_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion

            #region Doublon de chemin avec foreach et Compare sans prendre en compte la casse (Non utilisé)
            //foreach pour parcourir les items
            //foreach (string item in listFichiers.Items)
            //{
            //    if (String.Compare(item, txtChemin.Text, true) == 0)
            //    {
            //        existe = true;
            //        MessageBox.Show("Cet item existe déjà");
            //    }
            //}
            #endregion

            #region Si il y a un doublon de nom de fichier + extension (utilisé)
            //Si il y a un doublon du nom du fichier et de son extension
            foreach (var item in listFichiers.Items)
            {
                compareFichier = String.Compare(Path.GetFileName(txtChemin.Text), Path.GetFileName(item.ToString()));
            }
            if (compareFichier == 0)
                //Alors j'envoie un message d'erreur et je place "existe" à true
            {
                existe = true;
                MessageBox.Show(STR_ITEM_EXIST, STR_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            #region Ajout du fichier si aucun doublon
            //Si existe est à false, j'ajoute le fichier, il n'y a pas de doublon
            if (!String.IsNullOrEmpty(txtChemin.Text) && existe == false)
            {
                listFichiers.Items.Add(txtChemin.Text);
                txtChemin.Text = null;
                return;
            }
            #endregion

        }
        #endregion

        #region Bouton vider, Clear + Enabled function à false
        private void btVider_Click(object sender, EventArgs e)
        {
            listFichiers.Items.Clear();
            enabledFalse();
        }
        #endregion

        #region Bouton supprimer
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            #region Boîte de dialogue de confirmation de suppression
            DialogResult suppression = MessageBox.Show(STR_SUPPRESSION, STR_TITRE_SUPPRESSION, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (suppression == DialogResult.Yes)
            {
                listFichiers.Items.RemoveAt(listFichiers.SelectedIndex);
                btSupprimer.Enabled = false;
            }
            else
            {
                return;
            }
            #endregion
        }
        #endregion

        #region Loading de la fenêtre
        private void ChercheMonFichierImageForm_Load(object sender, EventArgs e)
        {
            #region Si il y a des paramètres utilisateur d'enregistré alors je les charges dans un tableau et je l'ajoute aux Items de la listBox
            if (Properties.Settings.Default.listBoxImage != null)
            {
                string[] tableau = new string[Properties.Settings.Default.listBoxImage.Count];
                Properties.Settings.Default.listBoxImage.CopyTo(tableau, 0);
                listFichiers.Items.AddRange(tableau);
            }
            #endregion

            #region Fonction Enabled
            enabledFalse();
            #endregion

            #region Ajout du contrôle pictureBox au panel (pour le scrolling)
            panelPictureBox.Controls.Add(pictureBox);
            #endregion
        }
        #endregion

        #region Si la valeur selectionnée à changé dans la liste des fichiers
        private void listFichiers_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Fonction Enabled
            enabledFalse();
            #endregion

            #region Si une valeur est selectionnée dans la liste j'essaie de charger l'image dans le pictureBox, sinon j'envoie un message d'erreur
            if (listFichiers.SelectedIndex > -1)
            {
                try
                {
                pictureBox.Load(listFichiers.SelectedItem.ToString());
                pictureBox.Size = pictureBox.Image.Size;

                }
                catch (Exception)
                {
                    MessageBox.Show(STR_FICHIER_INTROUVABLE, STR_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }
        #endregion

        #region Fonction Enabled, Vider si il y a des fichiers, Supprimer si un item est selectionné, Ajouter si il y a un chemin dans la textBox
        private void enabledFalse()
        {
            btVider.Enabled = (listFichiers.Items.Count > 0);
            btSupprimer.Enabled = (listFichiers.SelectedIndex > -1);
            btAjouter.Enabled = (txtChemin.Text.Length > 0);
            
        }
        #endregion

        #region Après avoir fermé l'application
        private void ChercheMonFichierImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region Création d'une StringCollection, d'un tableau du nombre d'items présents
            StringCollection collectionListBox = new StringCollection();
            string[] tableauCollectionListBox = new string[listFichiers.Items.Count];
            #endregion

            #region  Copie du contenu de la listBox dans ce tableau puis AddRange de celui ci dans la collection 
            listFichiers.Items.CopyTo(tableauCollectionListBox, 0);
            collectionListBox.AddRange(tableauCollectionListBox);
            #endregion

            #region Les settings sont maintenant la collection dont le contenu de la liste à été copiée + sauvegarde
            Properties.Settings.Default.listBoxImage = collectionListBox;
            Properties.Settings.Default.Save();
            #endregion
        }
        #endregion

        #region Si le texte du chemin d'accès à changer, alors : function Enabled
        private void txtChemin_TextChanged(object sender, EventArgs e)
        {
            enabledFalse();
        }
        #endregion
    }
}

