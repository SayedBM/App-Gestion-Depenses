namespace Depenses
{
    partial class categoei
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
            this.btnListCat = new System.Windows.Forms.Button();
            this.btnMajCat = new System.Windows.Forms.Button();
            this.btnAjoutCat = new System.Windows.Forms.Button();
            this.btnSuppCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlibCat = new System.Windows.Forms.TextBox();
            this.txtIdCat = new System.Windows.Forms.TextBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.Iden = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListCat
            // 
            this.btnListCat.BackColor = System.Drawing.Color.Lavender;
            this.btnListCat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnListCat.Location = new System.Drawing.Point(513, 159);
            this.btnListCat.Name = "btnListCat";
            this.btnListCat.Size = new System.Drawing.Size(233, 34);
            this.btnListCat.TabIndex = 0;
            this.btnListCat.Text = "Afficher les Catégories";
            this.btnListCat.UseVisualStyleBackColor = false;
            this.btnListCat.Click += new System.EventHandler(this.btnListCat_Click);
            // 
            // btnMajCat
            // 
            this.btnMajCat.BackColor = System.Drawing.Color.Lavender;
            this.btnMajCat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnMajCat.Location = new System.Drawing.Point(513, 244);
            this.btnMajCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMajCat.Name = "btnMajCat";
            this.btnMajCat.Size = new System.Drawing.Size(233, 31);
            this.btnMajCat.TabIndex = 8;
            this.btnMajCat.Text = "Mettre à jour catégorie";
            this.btnMajCat.UseVisualStyleBackColor = false;
            this.btnMajCat.Click += new System.EventHandler(this.btnMajCat_Click);
            // 
            // btnAjoutCat
            // 
            this.btnAjoutCat.BackColor = System.Drawing.Color.Lavender;
            this.btnAjoutCat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnAjoutCat.Location = new System.Drawing.Point(513, 204);
            this.btnAjoutCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutCat.Name = "btnAjoutCat";
            this.btnAjoutCat.Size = new System.Drawing.Size(233, 31);
            this.btnAjoutCat.TabIndex = 10;
            this.btnAjoutCat.Text = "Ajouter Catégorie";
            this.btnAjoutCat.UseVisualStyleBackColor = false;
            this.btnAjoutCat.Click += new System.EventHandler(this.btnAjoutCat_Click);
            // 
            // btnSuppCat
            // 
            this.btnSuppCat.BackColor = System.Drawing.Color.Lavender;
            this.btnSuppCat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnSuppCat.ForeColor = System.Drawing.Color.Red;
            this.btnSuppCat.Location = new System.Drawing.Point(513, 283);
            this.btnSuppCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppCat.Name = "btnSuppCat";
            this.btnSuppCat.Size = new System.Drawing.Size(233, 31);
            this.btnSuppCat.TabIndex = 9;
            this.btnSuppCat.Text = "Supprimer catégorie";
            this.btnSuppCat.UseVisualStyleBackColor = false;
            this.btnSuppCat.Click += new System.EventHandler(this.btnSuppCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(72, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(72, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Identifiant";
            // 
            // txtlibCat
            // 
            this.txtlibCat.Location = new System.Drawing.Point(177, 217);
            this.txtlibCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlibCat.Name = "txtlibCat";
            this.txtlibCat.Size = new System.Drawing.Size(121, 22);
            this.txtlibCat.TabIndex = 16;
            // 
            // txtIdCat
            // 
            this.txtIdCat.Location = new System.Drawing.Point(177, 186);
            this.txtIdCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.Size = new System.Drawing.Size(121, 22);
            this.txtIdCat.TabIndex = 15;
            this.txtIdCat.TextChanged += new System.EventHandler(this.txtIdCat_TextChanged);
            this.txtIdCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCat_KeyPress);
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(177, 156);
            this.comboCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(121, 24);
            this.comboCat.TabIndex = 14;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // Iden
            // 
            this.Iden.AutoSize = true;
            this.Iden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Iden.Location = new System.Drawing.Point(72, 159);
            this.Iden.Name = "Iden";
            this.Iden.Size = new System.Drawing.Size(100, 20);
            this.Iden.TabIndex = 13;
            this.Iden.Text = "Categories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 44);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gérer les Catégories";
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
            // categoei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlibCat);
            this.Controls.Add(this.txtIdCat);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.Iden);
            this.Controls.Add(this.btnAjoutCat);
            this.Controls.Add(this.btnSuppCat);
            this.Controls.Add(this.btnMajCat);
            this.Controls.Add(this.btnListCat);
            this.Name = "categoei";
            this.Text = "categoei";
            this.Load += new System.EventHandler(this.categoei_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListCat;
        private System.Windows.Forms.Button btnMajCat;
        private System.Windows.Forms.Button btnAjoutCat;
        private System.Windows.Forms.Button btnSuppCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlibCat;
        private System.Windows.Forms.TextBox txtIdCat;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label Iden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depenseToolStripMenuItem;
    }
}