namespace QuelEstMonAge
{
    partial class FormQuelEstMonAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuelEstMonAge));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dateAnniv = new System.Windows.Forms.DateTimePicker();
            this.btCalculer = new System.Windows.Forms.Button();
            this.btFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(36, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.Location = new System.Drawing.Point(36, 55);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(150, 20);
            this.lblDateNaissance.TabIndex = 1;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(208, 9);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 26);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // dateAnniv
            // 
            this.dateAnniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAnniv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAnniv.Location = new System.Drawing.Point(208, 55);
            this.dateAnniv.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateAnniv.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateAnniv.Name = "dateAnniv";
            this.dateAnniv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateAnniv.ShowUpDown = true;
            this.dateAnniv.Size = new System.Drawing.Size(167, 24);
            this.dateAnniv.TabIndex = 6;
            // 
            // btCalculer
            // 
            this.btCalculer.Enabled = false;
            this.btCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculer.Image = ((System.Drawing.Image)(resources.GetObject("btCalculer.Image")));
            this.btCalculer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalculer.Location = new System.Drawing.Point(233, 101);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(142, 74);
            this.btCalculer.TabIndex = 5;
            this.btCalculer.Text = "&Calculer";
            this.btCalculer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // btFermer
            // 
            this.btFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFermer.Image = ((System.Drawing.Image)(resources.GetObject("btFermer.Image")));
            this.btFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFermer.Location = new System.Drawing.Point(40, 101);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(146, 74);
            this.btFermer.TabIndex = 0;
            this.btFermer.Text = "&Fermer";
            this.btFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // FormQuelEstMonAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 187);
            this.Controls.Add(this.dateAnniv);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQuelEstMonAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quel est mon âge ?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuelEstMonAge_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuelEstMonAge_FormClosed);
            this.Load += new System.EventHandler(this.FormQuelEstMonAge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.DateTimePicker dateAnniv;
    }
}

