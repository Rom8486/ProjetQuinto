namespace ProjetQuinto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondDecran1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondDecran2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondDecran3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.règlesDuJeuToolStripMenuItem,
            this.topScoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle Partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thèmeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // thèmeToolStripMenuItem
            // 
            this.thèmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondDecran1ToolStripMenuItem,
            this.fondDecran2ToolStripMenuItem,
            this.fondDecran3ToolStripMenuItem});
            this.thèmeToolStripMenuItem.Name = "thèmeToolStripMenuItem";
            this.thèmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thèmeToolStripMenuItem.Text = "Thème";
            // 
            // fondDecran1ToolStripMenuItem
            // 
            this.fondDecran1ToolStripMenuItem.Name = "fondDecran1ToolStripMenuItem";
            this.fondDecran1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fondDecran1ToolStripMenuItem.Text = "Fond d\'ecran 1";
            // 
            // fondDecran2ToolStripMenuItem
            // 
            this.fondDecran2ToolStripMenuItem.Name = "fondDecran2ToolStripMenuItem";
            this.fondDecran2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fondDecran2ToolStripMenuItem.Text = "Fond d\'ecran 2";
            // 
            // fondDecran3ToolStripMenuItem
            // 
            this.fondDecran3ToolStripMenuItem.Name = "fondDecran3ToolStripMenuItem";
            this.fondDecran3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fondDecran3ToolStripMenuItem.Text = "Fond d\'ecran 3";
            // 
            // règlesDuJeuToolStripMenuItem
            // 
            this.règlesDuJeuToolStripMenuItem.Name = "règlesDuJeuToolStripMenuItem";
            this.règlesDuJeuToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.règlesDuJeuToolStripMenuItem.Text = "Règles du jeu";
            // 
            // topScoresToolStripMenuItem
            // 
            this.topScoresToolStripMenuItem.Name = "topScoresToolStripMenuItem";
            this.topScoresToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.topScoresToolStripMenuItem.Text = "Top Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondDecran1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondDecran2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondDecran3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topScoresToolStripMenuItem;
    }
}

