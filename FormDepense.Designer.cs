namespace Depenses
{
    partial class FormDepense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnAjoutD = new System.Windows.Forms.Button();
            this.btnSuppD = new System.Windows.Forms.Button();
            this.comboIdDe = new System.Windows.Forms.ComboBox();
            this.Iden = new System.Windows.Forms.Label();
            this.btnMajD = new System.Windows.Forms.Button();
            this.comboCatD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeCat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListD
            // 
            this.btnListD.BackColor = System.Drawing.Color.Lavender;
            this.btnListD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListD.FlatAppearance.BorderSize = 5;
            this.btnListD.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnListD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnListD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListD.Location = new System.Drawing.Point(557, 164);
            this.btnListD.Name = "btnListD";
            this.btnListD.Size = new System.Drawing.Size(204, 47);
            this.btnListD.TabIndex = 0;
            this.btnListD.Text = "Toutes les Dépenses";
            this.btnListD.UseVisualStyleBackColor = false;
            this.btnListD.Click += new System.EventHandler(this.btnListD_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(69, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(69, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Commentaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(69, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Montant";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.ForeColor = System.Drawing.Color.Navy;
            this.txtCommentaire.Location = new System.Drawing.Point(213, 354);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(242, 22);
            this.txtCommentaire.TabIndex = 20;
            // 
            // txtMontant
            // 
            this.txtMontant.ForeColor = System.Drawing.Color.Navy;
            this.txtMontant.Location = new System.Drawing.Point(213, 287);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(163, 22);
            this.txtMontant.TabIndex = 19;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // btnAjoutD
            // 
            this.btnAjoutD.BackColor = System.Drawing.Color.Lavender;
            this.btnAjoutD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjoutD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjoutD.FlatAppearance.BorderSize = 5;
            this.btnAjoutD.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAjoutD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnAjoutD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjoutD.Location = new System.Drawing.Point(557, 234);
            this.btnAjoutD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutD.Name = "btnAjoutD";
            this.btnAjoutD.Size = new System.Drawing.Size(204, 42);
            this.btnAjoutD.TabIndex = 18;
            this.btnAjoutD.Text = "Ajouter ";
            this.btnAjoutD.UseVisualStyleBackColor = false;
            this.btnAjoutD.Click += new System.EventHandler(this.btnAjoutD_Click);
            // 
            // btnSuppD
            // 
            this.btnSuppD.BackColor = System.Drawing.Color.Lavender;
            this.btnSuppD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuppD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSuppD.FlatAppearance.BorderSize = 5;
            this.btnSuppD.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSuppD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppD.ForeColor = System.Drawing.Color.Brown;
            this.btnSuppD.Location = new System.Drawing.Point(557, 359);
            this.btnSuppD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppD.Name = "btnSuppD";
            this.btnSuppD.Size = new System.Drawing.Size(204, 42);
            this.btnSuppD.TabIndex = 17;
            this.btnSuppD.Text = "Supprimer Depense";
            this.btnSuppD.UseVisualStyleBackColor = false;
            this.btnSuppD.Click += new System.EventHandler(this.btnSuppD_Click);
            // 
            // comboIdDe
            // 
            this.comboIdDe.ForeColor = System.Drawing.Color.Navy;
            this.comboIdDe.FormattingEnabled = true;
            this.comboIdDe.Location = new System.Drawing.Point(213, 177);
            this.comboIdDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboIdDe.Name = "comboIdDe";
            this.comboIdDe.Size = new System.Drawing.Size(163, 24);
            this.comboIdDe.TabIndex = 16;
            this.comboIdDe.SelectedIndexChanged += new System.EventHandler(this.comboIdDe_SelectedIndexChanged);
            // 
            // Iden
            // 
            this.Iden.AutoSize = true;
            this.Iden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Iden.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Iden.Location = new System.Drawing.Point(69, 174);
            this.Iden.Name = "Iden";
            this.Iden.Size = new System.Drawing.Size(95, 20);
            this.Iden.TabIndex = 15;
            this.Iden.Text = "Utilisateur";
            // 
            // btnMajD
            // 
            this.btnMajD.BackColor = System.Drawing.Color.Lavender;
            this.btnMajD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMajD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMajD.FlatAppearance.BorderSize = 5;
            this.btnMajD.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMajD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnMajD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMajD.Location = new System.Drawing.Point(557, 297);
            this.btnMajD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMajD.Name = "btnMajD";
            this.btnMajD.Size = new System.Drawing.Size(204, 42);
            this.btnMajD.TabIndex = 18;
            this.btnMajD.Text = "Mettre à jour ";
            this.btnMajD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMajD.UseVisualStyleBackColor = false;
            this.btnMajD.Click += new System.EventHandler(this.btnMajD_Click);
            // 
            // comboCatD
            // 
            this.comboCatD.ForeColor = System.Drawing.Color.Navy;
            this.comboCatD.FormattingEnabled = true;
            this.comboCatD.Location = new System.Drawing.Point(213, 216);
            this.comboCatD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCatD.Name = "comboCatD";
            this.comboCatD.Size = new System.Drawing.Size(163, 24);
            this.comboCatD.TabIndex = 26;
            this.comboCatD.SelectedIndexChanged += new System.EventHandler(this.comboCatD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(69, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Catégorie";
            // 
            // dateTimeCat
            // 
            this.dateTimeCat.CalendarForeColor = System.Drawing.Color.Navy;
            this.dateTimeCat.Location = new System.Drawing.Point(213, 321);
            this.dateTimeCat.Name = "dateTimeCat";
            this.dateTimeCat.Size = new System.Drawing.Size(242, 22);
            this.dateTimeCat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(69, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Identifiant ";
            // 
            // txtIdDe
            // 
            this.txtIdDe.ForeColor = System.Drawing.Color.Navy;
            this.txtIdDe.Location = new System.Drawing.Point(213, 256);
            this.txtIdDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDe.Name = "txtIdDe";
            this.txtIdDe.Size = new System.Drawing.Size(163, 22);
            this.txtIdDe.TabIndex = 28;
            this.txtIdDe.TextChanged += new System.EventHandler(this.txtIdDe_TextChanged);
            this.txtIdDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdDe_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 44);
            this.label6.TabIndex = 31;
            this.label6.Text = "Gérer les Dépenses";
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
            this.menuStrip1.Size = new System.Drawing.Size(908, 30);
            this.menuStrip1.TabIndex = 32;
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
            // FormDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(908, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdDe);
            this.Controls.Add(this.dateTimeCat);
            this.Controls.Add(this.comboCatD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.btnAjoutD);
            this.Controls.Add(this.btnSuppD);
            this.Controls.Add(this.comboIdDe);
            this.Controls.Add(this.Iden);
            this.Controls.Add(this.btnMajD);
            this.Controls.Add(this.btnListD);
            this.Name = "FormDepense";
            this.Text = "FormDepense";
            this.Load += new System.EventHandler(this.FormDepense_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnAjoutD;
        private System.Windows.Forms.Button btnSuppD;
        private System.Windows.Forms.ComboBox comboIdDe;
        private System.Windows.Forms.Label Iden;
        private System.Windows.Forms.Button btnMajD;
        private System.Windows.Forms.ComboBox comboCatD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depenseToolStripMenuItem;
    }
}