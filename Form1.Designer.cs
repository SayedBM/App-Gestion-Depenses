namespace Depenses
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
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.btnMAJ = new System.Windows.Forms.Button();
            this.Iden = new System.Windows.Forms.Label();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.BackColor = System.Drawing.Color.Lavender;
            this.btnUtilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnUtilisateur.Location = new System.Drawing.Point(519, 165);
            this.btnUtilisateur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(179, 30);
            this.btnUtilisateur.TabIndex = 0;
            this.btnUtilisateur.Text = "Liste des Utilisateurs";
            this.btnUtilisateur.UseVisualStyleBackColor = false;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // btnMAJ
            // 
            this.btnMAJ.BackColor = System.Drawing.Color.Lavender;
            this.btnMAJ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnMAJ.Location = new System.Drawing.Point(518, 242);
            this.btnMAJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMAJ.Name = "btnMAJ";
            this.btnMAJ.Size = new System.Drawing.Size(180, 30);
            this.btnMAJ.TabIndex = 1;
            this.btnMAJ.Text = "Mise à jour Utilisateur";
            this.btnMAJ.UseVisualStyleBackColor = false;
            this.btnMAJ.Click += new System.EventHandler(this.btnMAJ_Click);
            // 
            // Iden
            // 
            this.Iden.AutoSize = true;
            this.Iden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Iden.Location = new System.Drawing.Point(94, 173);
            this.Iden.Name = "Iden";
            this.Iden.Size = new System.Drawing.Size(104, 20);
            this.Iden.TabIndex = 3;
            this.Iden.Text = "Utilisateurs";
            // 
            // comboId
            // 
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(234, 173);
            this.comboId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(121, 24);
            this.comboId.TabIndex = 4;
            this.comboId.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.Lavender;
            this.btnSupp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnSupp.ForeColor = System.Drawing.Color.Crimson;
            this.btnSupp.Location = new System.Drawing.Point(518, 281);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(180, 30);
            this.btnSupp.TabIndex = 5;
            this.btnSupp.Text = "Supprimer Utilisateur";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.Lavender;
            this.btnAjout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnAjout.Location = new System.Drawing.Point(518, 204);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(180, 30);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajouter Utilisateur";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(234, 207);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 22);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(234, 242);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 22);
            this.txtNom.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 278);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(94, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(94, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom et Pérnom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.Location = new System.Drawing.Point(94, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(498, 44);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gérer les Utilisateurs";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.menu1,
            this.categorieToolStripMenuItem,
            this.depenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.principalToolStripMenuItem.Text = "Principal";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(90, 24);
            this.menu1.Text = "Utilisateur";
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click_1);
            // 
            // depenseToolStripMenuItem
            // 
            this.depenseToolStripMenuItem.Name = "depenseToolStripMenuItem";
            this.depenseToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.depenseToolStripMenuItem.Text = "Depense";
            this.depenseToolStripMenuItem.Click += new System.EventHandler(this.depenseToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.comboId);
            this.Controls.Add(this.Iden);
            this.Controls.Add(this.btnMAJ);
            this.Controls.Add(this.btnUtilisateur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnMAJ;
        private System.Windows.Forms.Label Iden;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depenseToolStripMenuItem;
    }
}

