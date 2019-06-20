namespace BoiteMessages
{
    partial class UCNouveauMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNouveauMessage));
            this.tObjet = new System.Windows.Forms.TextBox();
            this.pTop = new System.Windows.Forms.Panel();
            this.pA = new System.Windows.Forms.Panel();
            this.tDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bRecu = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bEnvoyer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bRessayez = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.recEnvoye = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recAnnuler = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pTop.SuspendLayout();
            this.pA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tObjet
            // 
            this.tObjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tObjet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tObjet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tObjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tObjet.Location = new System.Drawing.Point(20, 14);
            this.tObjet.Name = "tObjet";
            this.tObjet.Size = new System.Drawing.Size(505, 19);
            this.tObjet.TabIndex = 0;
            this.tObjet.Text = "Objet";
            this.tObjet.Enter += new System.EventHandler(this.tObjet_Enter);
            this.tObjet.Leave += new System.EventHandler(this.tObjet_Leave);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pTop.Controls.Add(this.tObjet);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 84);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(612, 46);
            this.pTop.TabIndex = 13;
            // 
            // pA
            // 
            this.pA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pA.Controls.Add(this.tDes);
            this.pA.Controls.Add(this.label2);
            this.pA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.pA.Location = new System.Drawing.Point(0, 37);
            this.pA.Name = "pA";
            this.pA.Size = new System.Drawing.Size(612, 47);
            this.pA.TabIndex = 14;
            // 
            // tDes
            // 
            this.tDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tDes.Location = new System.Drawing.Point(48, 15);
            this.tDes.Name = "tDes";
            this.tDes.Size = new System.Drawing.Size(391, 19);
            this.tDes.TabIndex = 1;
            this.tDes.Text = "...";
            this.tDes.Enter += new System.EventHandler(this.tDes_Enter);
            this.tDes.Leave += new System.EventHandler(this.tDes_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "à :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 157);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau message";
            // 
            // bRecu
            // 
            this.bRecu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRecu.FlatAppearance.BorderSize = 0;
            this.bRecu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRecu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bRecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRecu.ForeColor = System.Drawing.Color.White;
            this.bRecu.Image = ((System.Drawing.Image)(resources.GetObject("bRecu.Image")));
            this.bRecu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRecu.Location = new System.Drawing.Point(476, 307);
            this.bRecu.Name = "bRecu";
            this.bRecu.Size = new System.Drawing.Size(107, 32);
            this.bRecu.TabIndex = 19;
            this.bRecu.Text = "Envoyé !";
            this.bRecu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRecu.UseVisualStyleBackColor = false;
            this.bRecu.Visible = false;
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.SlateGray;
            this.bAnnuler.FlatAppearance.BorderSize = 0;
            this.bAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.bAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.bAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnnuler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(291, 308);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(144, 32);
            this.bAnnuler.TabIndex = 18;
            this.bAnnuler.Text = "Boite de reception";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bEnvoyer
            // 
            this.bEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bEnvoyer.FlatAppearance.BorderSize = 0;
            this.bEnvoyer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bEnvoyer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnvoyer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnvoyer.ForeColor = System.Drawing.Color.White;
            this.bEnvoyer.Location = new System.Drawing.Point(470, 307);
            this.bEnvoyer.Name = "bEnvoyer";
            this.bEnvoyer.Size = new System.Drawing.Size(119, 32);
            this.bEnvoyer.TabIndex = 17;
            this.bEnvoyer.Text = "Envoyer";
            this.bEnvoyer.UseVisualStyleBackColor = false;
            this.bEnvoyer.Click += new System.EventHandler(this.bEnvoyer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 37);
            this.panel1.TabIndex = 15;
            // 
            // bRessayez
            // 
            this.bRessayez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bRessayez.FlatAppearance.BorderSize = 0;
            this.bRessayez.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bRessayez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bRessayez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRessayez.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRessayez.ForeColor = System.Drawing.Color.White;
            this.bRessayez.Image = ((System.Drawing.Image)(resources.GetObject("bRessayez.Image")));
            this.bRessayez.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRessayez.Location = new System.Drawing.Point(472, 307);
            this.bRessayez.Name = "bRessayez";
            this.bRessayez.Size = new System.Drawing.Size(115, 32);
            this.bRessayez.TabIndex = 20;
            this.bRessayez.Text = "Réssayez !";
            this.bRessayez.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRessayez.UseVisualStyleBackColor = false;
            this.bRessayez.Visible = false;
            // 
            // recEnvoye
            // 
            this.recEnvoye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.recEnvoye.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recEnvoye.CornerRadius = 10;
            this.recEnvoye.Location = new System.Drawing.Point(464, 304);
            this.recEnvoye.Name = "recEnvoye";
            this.recEnvoye.Size = new System.Drawing.Size(131, 38);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recAnnuler,
            this.recEnvoye});
            this.shapeContainer1.Size = new System.Drawing.Size(612, 352);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // recAnnuler
            // 
            this.recAnnuler.BackColor = System.Drawing.Color.SlateGray;
            this.recAnnuler.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recAnnuler.CornerRadius = 10;
            this.recAnnuler.Location = new System.Drawing.Point(282, 304);
            this.recAnnuler.Name = "recAnnuler";
            this.recAnnuler.Size = new System.Drawing.Size(158, 38);
            // 
            // UCNouveauMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bRecu);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bEnvoyer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRessayez);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UCNouveauMessage";
            this.Size = new System.Drawing.Size(612, 352);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.pA.ResumeLayout(false);
            this.pA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRecu;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bEnvoyer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bRessayez;
        private System.Windows.Forms.Timer timer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recEnvoye;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recAnnuler;
        public System.Windows.Forms.TextBox tObjet;
        public System.Windows.Forms.TextBox tDes;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}
