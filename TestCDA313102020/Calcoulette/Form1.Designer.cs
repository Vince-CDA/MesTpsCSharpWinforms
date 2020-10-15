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
            this.lblPlush = new System.Windows.Forms.Label();
            this.lblTirets = new System.Windows.Forms.Label();
            this.txtResultosh = new System.Windows.Forms.TextBox();
            this.btEgalitesh = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtZneCalcoule1
            // 
            this.txtZneCalcoule1.AcceptsTab = true;
            this.txtZneCalcoule1.Location = new System.Drawing.Point(41, 12);
            this.txtZneCalcoule1.Name = "txtZneCalcoule1";
            this.txtZneCalcoule1.Size = new System.Drawing.Size(369, 20);
            this.txtZneCalcoule1.TabIndex = 0;
            this.txtZneCalcoule1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip2.SetToolTip(this.txtZneCalcoule1, "Entrez le premier nombre pour votre addition");
            this.txtZneCalcoule1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZneCalcoule1_KeyPress);
            // 
            // txtZneCalcoule2
            // 
            this.txtZneCalcoule2.AcceptsReturn = true;
            this.txtZneCalcoule2.AcceptsTab = true;
            this.txtZneCalcoule2.Location = new System.Drawing.Point(41, 41);
            this.txtZneCalcoule2.Name = "txtZneCalcoule2";
            this.txtZneCalcoule2.Size = new System.Drawing.Size(369, 20);
            this.txtZneCalcoule2.TabIndex = 1;
            this.txtZneCalcoule2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip2.SetToolTip(this.txtZneCalcoule2, "Entrez le second nombre pour votre addition");
            this.txtZneCalcoule2.Enter += new System.EventHandler(this.txtZneCalcoule2_Enter);
            this.txtZneCalcoule2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZneCalcoule2_KeyPress);
            // 
            // lblPlush
            // 
            this.lblPlush.AutoSize = true;
            this.lblPlush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlush.Location = new System.Drawing.Point(6, 36);
            this.lblPlush.Name = "lblPlush";
            this.lblPlush.Size = new System.Drawing.Size(19, 27);
            this.lblPlush.TabIndex = 2;
            this.lblPlush.Text = "+";
            this.toolTip2.SetToolTip(this.lblPlush, "C\'est une addition");
            this.lblPlush.UseCompatibleTextRendering = true;
            // 
            // lblTirets
            // 
            this.lblTirets.AutoSize = true;
            this.lblTirets.Location = new System.Drawing.Point(3, 64);
            this.lblTirets.Name = "lblTirets";
            this.lblTirets.Size = new System.Drawing.Size(442, 13);
            this.lblTirets.TabIndex = 3;
            this.lblTirets.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------";
            // 
            // txtResultosh
            // 
            this.txtResultosh.Location = new System.Drawing.Point(41, 80);
            this.txtResultosh.Name = "txtResultosh";
            this.txtResultosh.ReadOnly = true;
            this.txtResultosh.Size = new System.Drawing.Size(369, 20);
            this.txtResultosh.TabIndex = 4;
            this.txtResultosh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip2.SetToolTip(this.txtResultosh, "Zone de résultat");
            // 
            // btEgalitesh
            // 
            this.btEgalitesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEgalitesh.Location = new System.Drawing.Point(6, 80);
            this.btEgalitesh.Name = "btEgalitesh";
            this.btEgalitesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEgalitesh.Size = new System.Drawing.Size(18, 20);
            this.btEgalitesh.TabIndex = 3;
            this.btEgalitesh.Text = "=";
            this.toolTip2.SetToolTip(this.btEgalitesh, "Faire l\'addition");
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
            this.toolTip2.SetToolTip(this.btCE, "Réinitialiser tous les champs");
            this.btCE.UseCompatibleTextRendering = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // FormCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 113);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btEgalitesh);
            this.Controls.Add(this.txtResultosh);
            this.Controls.Add(this.lblTirets);
            this.Controls.Add(this.lblPlush);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCalculette_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZneCalcoule1;
        private System.Windows.Forms.TextBox txtZneCalcoule2;
        private System.Windows.Forms.Label lblPlush;
        private System.Windows.Forms.Label lblTirets;
        private System.Windows.Forms.TextBox txtResultosh;
        private System.Windows.Forms.Button btEgalitesh;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

