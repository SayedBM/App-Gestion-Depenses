namespace Depenses
{
    partial class FormIndex
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAjoutD = new System.Windows.Forms.Button();
            this.btnListD = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accueil";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.categorieToolStripMenuItem,
            this.depenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(90, 24);
            this.menu1.Text = "Utilisateur";
            this.menu1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // depenseToolStripMenuItem
            // 
            this.depenseToolStripMenuItem.Name = "depenseToolStripMenuItem";
            this.depenseToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.depenseToolStripMenuItem.Text = "Depense";
            this.depenseToolStripMenuItem.Click += new System.EventHandler(this.depenseToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
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
            this.btnAjoutD.Location = new System.Drawing.Point(529, 173);
            this.btnAjoutD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutD.Name = "btnAjoutD";
            this.btnAjoutD.Size = new System.Drawing.Size(204, 42);
            this.btnAjoutD.TabIndex = 21;
            this.btnAjoutD.Text = "Ajouter ";
            this.btnAjoutD.UseVisualStyleBackColor = false;
            this.btnAjoutD.Click += new System.EventHandler(this.btnAjoutD_Click);
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
            this.btnListD.Location = new System.Drawing.Point(529, 121);
            this.btnListD.Name = "btnListD";
            this.btnListD.Size = new System.Drawing.Size(204, 47);
            this.btnListD.TabIndex = 19;
            this.btnListD.Text = "Toutes les Dépenses";
            this.btnListD.UseVisualStyleBackColor = false;
            this.btnListD.Click += new System.EventHandler(this.btnListD_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(131, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 372);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(907, 576);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAjoutD);
            this.Controls.Add(this.btnListD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormIndex";
            this.Text = "FormIndex";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depenseToolStripMenuItem;
        private System.Windows.Forms.Button btnAjoutD;
        private System.Windows.Forms.Button btnListD;
        private System.Windows.Forms.ListBox listBox1;
    }
}