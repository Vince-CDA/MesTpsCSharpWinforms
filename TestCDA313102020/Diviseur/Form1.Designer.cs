namespace Calcoulette
{
    partial class FormCalculette
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculette));
            this.txtZneCalcoule1 = new System.Windows.Forms.TextBox();
            this.txtZneCalcoule2 = new System.Windows.Forms.TextBox();
            this.lblTirets = new System.Windows.Forms.Label();
            this.btEgalitesh = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumera = new System.Windows.Forms.TextBox();
            this.txtDenomi = new System.Windows.Forms.TextBox();
            this.lblNumera = new System.Windows.Forms.Label();
            this.lblDenomi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtZneCalcoule1
            // 
            this.txtZneCalcoule1.AcceptsTab = true;
            this.txtZneCalcoule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZneCalcoule1.Location = new System.Drawing.Point(303, 42);
            this.txtZneCalcoule1.Name = "txtZneCalcoule1";
            this.txtZneCalcoule1.Size = new System.Drawing.Size(107, 26);
            this.txtZneCalcoule1.TabIndex = 0;
            this.txtZneCalcoule1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtZneCalcoule1, "Numérateur attendu (entier)");
            this.txtZneCalcoule1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZneCalcoule1_KeyPress);
            // 
            // txtZneCalcoule2
            // 
            this.txtZneCalcoule2.AcceptsReturn = true;
            this.txtZneCalcoule2.AcceptsTab = true;
            this.txtZneCalcoule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZneCalcoule2.Location = new System.Drawing.Point(303, 87);
            this.txtZneCalcoule2.Name = "txtZneCalcoule2";
            this.txtZneCalcoule2.Size = new System.Drawing.Size(107, 26);
            this.txtZneCalcoule2.TabIndex = 1;
            this.txtZneCalcoule2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtZneCalcoule2, "Dénominateur attendu (entier)");
            this.txtZneCalcoule2.Enter += new System.EventHandler(this.txtZneCalcoule2_Enter);
            this.txtZneCalcoule2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZneCalcoule2_KeyPress);
            // 
            // lblTirets
            // 
            this.lblTirets.AutoSize = true;
            this.lblTirets.Location = new System.Drawing.Point(300, 71);
            this.lblTirets.Name = "lblTirets";
            this.lblTirets.Size = new System.Drawing.Size(112, 13);
            this.lblTirets.TabIndex = 3;
            this.lblTirets.Text = "-----------------------------------";
            // 
            // btEgalitesh
            // 
            this.btEgalitesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEgalitesh.Location = new System.Drawing.Point(169, 128);
            this.btEgalitesh.Name = "btEgalitesh";
            this.btEgalitesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEgalitesh.Size = new System.Drawing.Size(100, 26);
            this.btEgalitesh.TabIndex = 3;
            this.btEgalitesh.Text = "Calculer";
            this.toolTip1.SetToolTip(this.btEgalitesh, "Cliquez-ici pour calculer");
            this.btEgalitesh.UseCompatibleTextRendering = true;
            this.btEgalitesh.Click += new System.EventHandler(this.btEgalitesh_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(416, 12);
            this.btCE.Name = "btCE";
            this.btCE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btCE.Size = new System.Drawing.Size(28, 20);
            this.btCE.TabIndex = 6;
            this.btCE.Text = "CE";
            this.toolTip1.SetToolTip(this.btCE, "Réinitialiser les champs");
            this.btCE.UseCompatibleTextRendering = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "------------------------------------";
            // 
            // txtNumera
            // 
            this.txtNumera.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumera.Location = new System.Drawing.Point(216, 232);
            this.txtNumera.Name = "txtNumera";
            this.txtNumera.Size = new System.Drawing.Size(73, 19);
            this.txtNumera.TabIndex = 9;
            this.txtNumera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNumera, "Fraction simplifiée");
            // 
            // txtDenomi
            // 
            this.txtDenomi.BackColor = System.Drawing.SystemColors.Control;
            this.txtDenomi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDenomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomi.Location = new System.Drawing.Point(216, 270);
            this.txtDenomi.Name = "txtDenomi";
            this.txtDenomi.Size = new System.Drawing.Size(73, 19);
            this.txtDenomi.TabIndex = 10;
            this.txtDenomi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtDenomi, "Fraction simplifiée");
            // 
            // lblNumera
            // 
            this.lblNumera.AutoSize = true;
            this.lblNumera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumera.Location = new System.Drawing.Point(12, 224);
            this.lblNumera.Name = "lblNumera";
            this.lblNumera.Size = new System.Drawing.Size(120, 24);
            this.lblNumera.TabIndex = 11;
            this.lblNumera.Text = "Numérateur :";
            // 
            // lblDenomi
            // 
            this.lblDenomi.AutoSize = true;
            this.lblDenomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenomi.Location = new System.Drawing.Point(12, 270);
            this.lblDenomi.Name = "lblDenomi";
            this.lblDenomi.Size = new System.Drawing.Size(139, 24);
            this.lblDenomi.TabIndex = 12;
            this.lblDenomi.Text = "Dénominateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Veuillez saisir le dénominateur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Veuillez saisir le numérateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Résultat après simplifications :";
            // 
            // FormCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDenomi);
            this.Controls.Add(this.lblNumera);
            this.Controls.Add(this.txtDenomi);
            this.Controls.Add(this.txtNumera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btEgalitesh);
            this.Controls.Add(this.lblTirets);
            this.Controls.Add(this.txtZneCalcoule2);
            this.Controls.Add(this.txtZneCalcoule1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCalculette";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcoulette";
            this.toolTip1.SetToolTip(this, "Fenêtre de simplification de fraction");
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCalculette_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZneCalcoule1;
        private System.Windows.Forms.TextBox txtZneCalcoule2;
        private System.Windows.Forms.Label lblTirets;
        private System.Windows.Forms.Button btEgalitesh;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumera;
        private System.Windows.Forms.TextBox txtDenomi;
        private System.Windows.Forms.Label lblNumera;
        private System.Windows.Forms.Label lblDenomi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

