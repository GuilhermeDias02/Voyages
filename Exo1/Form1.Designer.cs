namespace Exo1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupInfosVoyage = new System.Windows.Forms.GroupBox();
            this.labelInfosVoyage = new System.Windows.Forms.Label();
            this.listBoxVoyages = new System.Windows.Forms.ListBox();
            this.groupInfosVoyage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Choisir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupInfosVoyage
            // 
            this.groupInfosVoyage.Controls.Add(this.button1);
            this.groupInfosVoyage.Controls.Add(this.labelInfosVoyage);
            this.groupInfosVoyage.Location = new System.Drawing.Point(357, 90);
            this.groupInfosVoyage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfosVoyage.Name = "groupInfosVoyage";
            this.groupInfosVoyage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfosVoyage.Size = new System.Drawing.Size(643, 370);
            this.groupInfosVoyage.TabIndex = 10;
            this.groupInfosVoyage.TabStop = false;
            this.groupInfosVoyage.Text = "Infos Voyage";
            this.groupInfosVoyage.Visible = false;
            // 
            // labelInfosVoyage
            // 
            this.labelInfosVoyage.AutoSize = true;
            this.labelInfosVoyage.Location = new System.Drawing.Point(25, 36);
            this.labelInfosVoyage.Name = "labelInfosVoyage";
            this.labelInfosVoyage.Size = new System.Drawing.Size(0, 16);
            this.labelInfosVoyage.TabIndex = 10;
            // 
            // listBoxVoyages
            // 
            this.listBoxVoyages.FormattingEnabled = true;
            this.listBoxVoyages.ItemHeight = 16;
            this.listBoxVoyages.Location = new System.Drawing.Point(4, 90);
            this.listBoxVoyages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxVoyages.Name = "listBoxVoyages";
            this.listBoxVoyages.Size = new System.Drawing.Size(329, 372);
            this.listBoxVoyages.TabIndex = 11;
            this.listBoxVoyages.SelectedIndexChanged += new System.EventHandler(this.listBoxVoyages_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBoxVoyages);
            this.Controls.Add(this.groupInfosVoyage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "lab";
            this.groupInfosVoyage.ResumeLayout(false);
            this.groupInfosVoyage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupInfosVoyage;
        private System.Windows.Forms.ListBox listBoxVoyages;
        private System.Windows.Forms.Label labelInfosVoyage;
    }
}

