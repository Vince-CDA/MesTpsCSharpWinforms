namespace ChercheLeCheminDeMonImage
{
    partial class ChercheMonFichierImageForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChercheMonFichierImageForm));
            this.txtChemin = new System.Windows.Forms.TextBox();
            this.listFichiers = new System.Windows.Forms.ListBox();
            this.btVider = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btParcourir = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChemin
            // 
            this.txtChemin.AllowDrop = true;
            this.txtChemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChemin.Location = new System.Drawing.Point(62, 25);
            this.txtChemin.Name = "txtChemin";
            this.txtChemin.ReadOnly = true;
            this.txtChemin.Size = new System.Drawing.Size(601, 26);
            this.txtChemin.TabIndex = 0;
            this.txtChemin.TextChanged += new System.EventHandler(this.txtChemin_TextChanged);
            // 
            // listFichiers
            // 
            this.listFichiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFichiers.FormattingEnabled = true;
            this.listFichiers.ItemHeight = 20;
            this.listFichiers.Location = new System.Drawing.Point(12, 76);
            this.listFichiers.Name = "listFichiers";
            this.listFichiers.Size = new System.Drawing.Size(650, 124);
            this.listFichiers.TabIndex = 2;
            this.listFichiers.SelectedValueChanged += new System.EventHandler(this.listFichiers_SelectedValueChanged);
            // 
            // btVider
            // 
            this.btVider.Enabled = false;
            this.btVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVider.Image = global::ChercheLeCheminDeMonImage.Properties.Resources.reset;
            this.btVider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVider.Location = new System.Drawing.Point(668, 154);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(104, 34);
            this.btVider.TabIndex = 5;
            this.btVider.Text = "Vider";
            this.btVider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.btVider_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btSupprimer.Image")));
            this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSupprimer.Location = new System.Drawing.Point(668, 115);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(104, 33);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Enabled = false;
            this.btAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouter.Image = global::ChercheLeCheminDeMonImage.Properties.Resources.add;
            this.btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjouter.Location = new System.Drawing.Point(668, 76);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(104, 33);
            this.btAjouter.TabIndex = 3;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btParcourir
            // 
            this.btParcourir.Image = global::ChercheLeCheminDeMonImage.Properties.Resources.live_search_15403;
            this.btParcourir.Location = new System.Drawing.Point(12, 17);
            this.btParcourir.Name = "btParcourir";
            this.btParcourir.Size = new System.Drawing.Size(44, 42);
            this.btParcourir.TabIndex = 1;
            this.btParcourir.UseVisualStyleBackColor = true;
            this.btParcourir.Click += new System.EventHandler(this.btParcourir_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(44, 31);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPictureBox.AutoScroll = true;
            this.panelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPictureBox.Controls.Add(this.pictureBox);
            this.panelPictureBox.Location = new System.Drawing.Point(13, 207);
            this.panelPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(759, 234);
            this.panelPictureBox.TabIndex = 7;
            // 
            // ChercheMonFichierImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.listFichiers);
            this.Controls.Add(this.btParcourir);
            this.Controls.Add(this.txtChemin);
            this.Controls.Add(this.panelPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChercheMonFichierImageForm";
            this.Text = "Cherchons l\'image";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChercheMonFichierImageForm_FormClosed);
            this.Load += new System.EventHandler(this.ChercheMonFichierImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            this.panelPictureBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChemin;
        private System.Windows.Forms.Button btParcourir;
        private System.Windows.Forms.ListBox listFichiers;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btVider;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelPictureBox;
    }
}

