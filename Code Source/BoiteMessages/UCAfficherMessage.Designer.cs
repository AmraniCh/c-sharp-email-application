namespace BoiteMessages
{
    partial class UCAfficherMessage
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTitre = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lExp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lTitre = new System.Windows.Forms.Label();
            this.pObjet = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bRepondre = new System.Windows.Forms.Button();
            this.bBoite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pTitre.SuspendLayout();
            this.pObjet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitre
            // 
            this.pTitre.Controls.Add(this.label3);
            this.pTitre.Controls.Add(this.lDate);
            this.pTitre.Controls.Add(this.lExp);
            this.pTitre.Controls.Add(this.label1);
            this.pTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitre.Location = new System.Drawing.Point(0, 0);
            this.pTitre.Name = "pTitre";
            this.pTitre.Size = new System.Drawing.Size(612, 45);
            this.pTitre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "à : ";
            // 
            // lDate
            // 
            this.lDate.AutoEllipsis = true;
            this.lDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.Color.White;
            this.lDate.Location = new System.Drawing.Point(453, 14);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(145, 20);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Date";
            // 
            // lExp
            // 
            this.lExp.AutoEllipsis = true;
            this.lExp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExp.ForeColor = System.Drawing.Color.White;
            this.lExp.Location = new System.Drawing.Point(65, 12);
            this.lExp.Name = "lExp";
            this.lExp.Size = new System.Drawing.Size(308, 20);
            this.lExp.TabIndex = 2;
            this.lExp.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "De : ";
            // 
            // lTitre
            // 
            this.lTitre.AutoEllipsis = true;
            this.lTitre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.ForeColor = System.Drawing.Color.White;
            this.lTitre.Location = new System.Drawing.Point(65, 13);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(521, 20);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "...";
            // 
            // pObjet
            // 
            this.pObjet.Controls.Add(this.label2);
            this.pObjet.Controls.Add(this.lTitre);
            this.pObjet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pObjet.Location = new System.Drawing.Point(0, 45);
            this.pObjet.Name = "pObjet";
            this.pObjet.Size = new System.Drawing.Size(612, 45);
            this.pObjet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Objet";
            // 
            // bRepondre
            // 
            this.bRepondre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRepondre.FlatAppearance.BorderSize = 0;
            this.bRepondre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRepondre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRepondre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRepondre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRepondre.ForeColor = System.Drawing.Color.White;
            this.bRepondre.Location = new System.Drawing.Point(470, 304);
            this.bRepondre.Name = "bRepondre";
            this.bRepondre.Size = new System.Drawing.Size(128, 39);
            this.bRepondre.TabIndex = 2;
            this.bRepondre.Text = "Répondre";
            this.bRepondre.UseVisualStyleBackColor = false;
            this.bRepondre.Click += new System.EventHandler(this.bRepondre_Click);
            // 
            // bBoite
            // 
            this.bBoite.BackColor = System.Drawing.Color.SlateGray;
            this.bBoite.FlatAppearance.BorderSize = 0;
            this.bBoite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bBoite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bBoite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBoite.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBoite.ForeColor = System.Drawing.Color.White;
            this.bBoite.Location = new System.Drawing.Point(292, 304);
            this.bBoite.Name = "bBoite";
            this.bBoite.Size = new System.Drawing.Size(164, 39);
            this.bBoite.TabIndex = 3;
            this.bBoite.Text = "Boite de réception ";
            this.bBoite.UseVisualStyleBackColor = false;
            this.bBoite.Click += new System.EventHandler(this.bBoite_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 191);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 191);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Message";
            // 
            // UCAfficherMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bBoite);
            this.Controls.Add(this.bRepondre);
            this.Controls.Add(this.pObjet);
            this.Controls.Add(this.pTitre);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "UCAfficherMessage";
            this.Size = new System.Drawing.Size(612, 352);
            this.pTitre.ResumeLayout(false);
            this.pTitre.PerformLayout();
            this.pObjet.ResumeLayout(false);
            this.pObjet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitre;
        private System.Windows.Forms.Button bRepondre;
        private System.Windows.Forms.Button bBoite;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pObjet;
        public System.Windows.Forms.Label lTitre;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label lExp;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lDate;
        public System.Windows.Forms.Label label3;
    }
}
