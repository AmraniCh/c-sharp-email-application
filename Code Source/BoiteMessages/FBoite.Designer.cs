namespace BoiteMessages
{
    partial class FBoite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBoite));
            this.pLeft = new System.Windows.Forms.Panel();
            this.bCorbeille = new System.Windows.Forms.Button();
            this.bEnvoye = new System.Windows.Forms.Button();
            this.bAttente = new System.Windows.Forms.Button();
            this.bSuivis = new System.Windows.Forms.Button();
            this.bRec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pCompte = new System.Windows.Forms.Panel();
            this.lDate2 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lPseudo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bDeconnexion = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.bCompte = new System.Windows.Forms.Button();
            this.bRep = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bImportant = new System.Windows.Forms.Button();
            this.bLu = new System.Windows.Forms.Button();
            this.bSupp = new System.Windows.Forms.Button();
            this.bNouvelle = new System.Windows.Forms.Button();
            this.bRes = new System.Windows.Forms.Button();
            this.pCenter = new System.Windows.Forms.Panel();
            this.pAlerte = new System.Windows.Forms.Panel();
            this.pMessages = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pTop.SuspendLayout();
            this.pCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pLeft.Controls.Add(this.bCorbeille);
            this.pLeft.Controls.Add(this.bEnvoye);
            this.pLeft.Controls.Add(this.bAttente);
            this.pLeft.Controls.Add(this.bSuivis);
            this.pLeft.Controls.Add(this.bRec);
            this.pLeft.Controls.Add(this.label4);
            this.pLeft.Controls.Add(this.pictureBox1);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(153, 527);
            this.pLeft.TabIndex = 1;
            // 
            // bCorbeille
            // 
            this.bCorbeille.FlatAppearance.BorderSize = 0;
            this.bCorbeille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCorbeille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.bCorbeille.Image = global::BoiteMessages.Properties.Resources.rubbish_bin_delete_button;
            this.bCorbeille.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCorbeille.Location = new System.Drawing.Point(0, 445);
            this.bCorbeille.Name = "bCorbeille";
            this.bCorbeille.Size = new System.Drawing.Size(153, 63);
            this.bCorbeille.TabIndex = 4;
            this.bCorbeille.Text = "Corbeille";
            this.bCorbeille.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCorbeille.UseVisualStyleBackColor = true;
            this.bCorbeille.Click += new System.EventHandler(this.bCorbeille_Click);
            // 
            // bEnvoye
            // 
            this.bEnvoye.FlatAppearance.BorderSize = 0;
            this.bEnvoye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnvoye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.bEnvoye.Image = global::BoiteMessages.Properties.Resources.sent;
            this.bEnvoye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEnvoye.Location = new System.Drawing.Point(0, 366);
            this.bEnvoye.Name = "bEnvoye";
            this.bEnvoye.Size = new System.Drawing.Size(153, 63);
            this.bEnvoye.TabIndex = 3;
            this.bEnvoye.Text = "Messages envoyés";
            this.bEnvoye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bEnvoye.UseVisualStyleBackColor = true;
            this.bEnvoye.Click += new System.EventHandler(this.bEnvoye_Click);
            // 
            // bAttente
            // 
            this.bAttente.FlatAppearance.BorderSize = 0;
            this.bAttente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.bAttente.Image = global::BoiteMessages.Properties.Resources.clock_circular_outline;
            this.bAttente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAttente.Location = new System.Drawing.Point(0, 286);
            this.bAttente.Name = "bAttente";
            this.bAttente.Size = new System.Drawing.Size(153, 63);
            this.bAttente.TabIndex = 2;
            this.bAttente.Text = "En attente";
            this.bAttente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAttente.UseVisualStyleBackColor = true;
            this.bAttente.Click += new System.EventHandler(this.bAttente_Click);
            // 
            // bSuivis
            // 
            this.bSuivis.FlatAppearance.BorderSize = 0;
            this.bSuivis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSuivis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.bSuivis.Image = global::BoiteMessages.Properties.Resources.star;
            this.bSuivis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSuivis.Location = new System.Drawing.Point(-1, 207);
            this.bSuivis.Name = "bSuivis";
            this.bSuivis.Size = new System.Drawing.Size(153, 63);
            this.bSuivis.TabIndex = 1;
            this.bSuivis.Text = "Messages suivis";
            this.bSuivis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSuivis.UseVisualStyleBackColor = true;
            this.bSuivis.Click += new System.EventHandler(this.bSuivis_Click);
            // 
            // bRec
            // 
            this.bRec.FlatAppearance.BorderSize = 0;
            this.bRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRec.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.bRec.Image = global::BoiteMessages.Properties.Resources.receive;
            this.bRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bRec.Location = new System.Drawing.Point(0, 130);
            this.bRec.Name = "bRec";
            this.bRec.Size = new System.Drawing.Size(153, 63);
            this.bRec.TabIndex = 0;
            this.bRec.Text = "Boite de réception";
            this.bRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bRec.UseVisualStyleBackColor = true;
            this.bRec.Click += new System.EventHandler(this.bRec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 9);
            this.label4.TabIndex = 20;
            this.label4.Text = "Developpé par EL AMRANI CH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoiteMessages.Properties.Resources.gmail__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pCompte
            // 
            this.pCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.pCompte.Controls.Add(this.lDate2);
            this.pCompte.Controls.Add(this.lDate);
            this.pCompte.Controls.Add(this.lEmail);
            this.pCompte.Controls.Add(this.pictureBox3);
            this.pCompte.Controls.Add(this.lPseudo);
            this.pCompte.Controls.Add(this.pictureBox2);
            this.pCompte.Controls.Add(this.label3);
            this.pCompte.Controls.Add(this.bDeconnexion);
            this.pCompte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCompte.ForeColor = System.Drawing.Color.White;
            this.pCompte.Location = new System.Drawing.Point(153, 0);
            this.pCompte.Name = "pCompte";
            this.pCompte.Size = new System.Drawing.Size(637, 52);
            this.pCompte.TabIndex = 3;
            // 
            // lDate2
            // 
            this.lDate2.AutoSize = true;
            this.lDate2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate2.Location = new System.Drawing.Point(438, 27);
            this.lDate2.Name = "lDate2";
            this.lDate2.Size = new System.Drawing.Size(56, 17);
            this.lDate2.TabIndex = 9;
            this.lDate2.Text = "12:00:00";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(429, 10);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(74, 17);
            this.lDate.TabIndex = 8;
            this.lDate.Text = "01/01/2018";
            // 
            // lEmail
            // 
            this.lEmail.AutoEllipsis = true;
            this.lEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(173, 20);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(140, 17);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::BoiteMessages.Properties.Resources.close_envelope;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(141, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lPseudo
            // 
            this.lPseudo.AutoSize = true;
            this.lPseudo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPseudo.Location = new System.Drawing.Point(52, 20);
            this.lPseudo.Name = "lPseudo";
            this.lPseudo.Size = new System.Drawing.Size(51, 17);
            this.lPseudo.TabIndex = 5;
            this.lPseudo.Text = "Pseudo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::BoiteMessages.Properties.Resources.user_2;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dernière session :";
            // 
            // bDeconnexion
            // 
            this.bDeconnexion.BackColor = System.Drawing.Color.SlateGray;
            this.bDeconnexion.Dock = System.Windows.Forms.DockStyle.Right;
            this.bDeconnexion.FlatAppearance.BorderSize = 0;
            this.bDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeconnexion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeconnexion.Location = new System.Drawing.Point(520, 0);
            this.bDeconnexion.Name = "bDeconnexion";
            this.bDeconnexion.Size = new System.Drawing.Size(117, 52);
            this.bDeconnexion.TabIndex = 0;
            this.bDeconnexion.Text = "Déconnexion";
            this.bDeconnexion.UseVisualStyleBackColor = false;
            this.bDeconnexion.Click += new System.EventHandler(this.bDeconnexion_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pTop.Controls.Add(this.bCompte);
            this.pTop.Controls.Add(this.bRep);
            this.pTop.Controls.Add(this.bRefresh);
            this.pTop.Controls.Add(this.bImportant);
            this.pTop.Controls.Add(this.bLu);
            this.pTop.Controls.Add(this.bSupp);
            this.pTop.Controls.Add(this.bNouvelle);
            this.pTop.Controls.Add(this.bRes);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.pTop.Location = new System.Drawing.Point(153, 52);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(637, 52);
            this.pTop.TabIndex = 4;
            // 
            // bCompte
            // 
            this.bCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bCompte.Dock = System.Windows.Forms.DockStyle.Right;
            this.bCompte.FlatAppearance.BorderSize = 0;
            this.bCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCompte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCompte.ForeColor = System.Drawing.Color.White;
            this.bCompte.Image = global::BoiteMessages.Properties.Resources.settings;
            this.bCompte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCompte.Location = new System.Drawing.Point(520, 0);
            this.bCompte.Name = "bCompte";
            this.bCompte.Size = new System.Drawing.Size(117, 52);
            this.bCompte.TabIndex = 9;
            this.bCompte.Text = "Mon compte";
            this.bCompte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCompte.UseVisualStyleBackColor = false;
            this.bCompte.Click += new System.EventHandler(this.bCompte_Click);
            // 
            // bRep
            // 
            this.bRep.FlatAppearance.BorderSize = 0;
            this.bRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRep.Image = global::BoiteMessages.Properties.Resources.replay_arrow;
            this.bRep.Location = new System.Drawing.Point(328, 0);
            this.bRep.Name = "bRep";
            this.bRep.Size = new System.Drawing.Size(50, 52);
            this.bRep.TabIndex = 8;
            this.bRep.UseVisualStyleBackColor = true;
            this.bRep.Visible = false;
            this.bRep.Click += new System.EventHandler(this.bRep_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.FlatAppearance.BorderSize = 0;
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefresh.Image = global::BoiteMessages.Properties.Resources.refresh_button;
            this.bRefresh.Location = new System.Drawing.Point(151, 0);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(50, 52);
            this.bRefresh.TabIndex = 7;
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bImportant
            // 
            this.bImportant.FlatAppearance.BorderSize = 0;
            this.bImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImportant.Image = global::BoiteMessages.Properties.Resources.star_2;
            this.bImportant.Location = new System.Drawing.Point(210, 0);
            this.bImportant.Name = "bImportant";
            this.bImportant.Size = new System.Drawing.Size(50, 52);
            this.bImportant.TabIndex = 6;
            this.bImportant.UseVisualStyleBackColor = true;
            this.bImportant.Visible = false;
            this.bImportant.Click += new System.EventHandler(this.bImportant_Click);
            // 
            // bLu
            // 
            this.bLu.FlatAppearance.BorderSize = 0;
            this.bLu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLu.Image = global::BoiteMessages.Properties.Resources.envelope;
            this.bLu.Location = new System.Drawing.Point(269, 0);
            this.bLu.Name = "bLu";
            this.bLu.Size = new System.Drawing.Size(50, 52);
            this.bLu.TabIndex = 5;
            this.bLu.UseVisualStyleBackColor = true;
            this.bLu.Visible = false;
            this.bLu.Click += new System.EventHandler(this.bLu_Click);
            // 
            // bSupp
            // 
            this.bSupp.FlatAppearance.BorderSize = 0;
            this.bSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSupp.Image = global::BoiteMessages.Properties.Resources.rubbish_bin_delete_button_2;
            this.bSupp.Location = new System.Drawing.Point(387, 0);
            this.bSupp.Name = "bSupp";
            this.bSupp.Size = new System.Drawing.Size(50, 52);
            this.bSupp.TabIndex = 4;
            this.bSupp.UseVisualStyleBackColor = true;
            this.bSupp.Visible = false;
            this.bSupp.Click += new System.EventHandler(this.bSupp_Click);
            // 
            // bNouvelle
            // 
            this.bNouvelle.BackColor = System.Drawing.Color.SlateGray;
            this.bNouvelle.FlatAppearance.BorderSize = 0;
            this.bNouvelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNouvelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNouvelle.ForeColor = System.Drawing.Color.White;
            this.bNouvelle.Location = new System.Drawing.Point(-2, 0);
            this.bNouvelle.Name = "bNouvelle";
            this.bNouvelle.Size = new System.Drawing.Size(144, 52);
            this.bNouvelle.TabIndex = 3;
            this.bNouvelle.Text = "Nouveau message";
            this.bNouvelle.UseVisualStyleBackColor = false;
            this.bNouvelle.Click += new System.EventHandler(this.bNouvelle_Click);
            // 
            // bRes
            // 
            this.bRes.FlatAppearance.BorderSize = 0;
            this.bRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRes.Image = global::BoiteMessages.Properties.Resources.restore;
            this.bRes.Location = new System.Drawing.Point(446, 0);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(50, 52);
            this.bRes.TabIndex = 2;
            this.bRes.UseVisualStyleBackColor = true;
            this.bRes.Visible = false;
            this.bRes.Click += new System.EventHandler(this.bRes_Click);
            // 
            // pCenter
            // 
            this.pCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.pCenter.Controls.Add(this.pAlerte);
            this.pCenter.Controls.Add(this.pMessages);
            this.pCenter.Controls.Add(this.pMenu);
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(153, 104);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(637, 423);
            this.pCenter.TabIndex = 6;
            // 
            // pAlerte
            // 
            this.pAlerte.BackColor = System.Drawing.Color.SlateGray;
            this.pAlerte.Location = new System.Drawing.Point(11, 374);
            this.pAlerte.Name = "pAlerte";
            this.pAlerte.Size = new System.Drawing.Size(612, 40);
            this.pAlerte.TabIndex = 8;
            this.pAlerte.Visible = false;
            // 
            // pMessages
            // 
            this.pMessages.AutoScroll = true;
            this.pMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pMessages.Location = new System.Drawing.Point(11, 16);
            this.pMessages.Name = "pMessages";
            this.pMessages.Size = new System.Drawing.Size(612, 352);
            this.pMessages.TabIndex = 7;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.pMenu.Location = new System.Drawing.Point(0, 26);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(5, 63);
            this.pMenu.TabIndex = 6;
            // 
            // FBoite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(790, 527);
            this.Controls.Add(this.pCenter);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pCompte);
            this.Controls.Add(this.pLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBoite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boite messagerie";
            this.Load += new System.EventHandler(this.FBoite_Load);
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pCompte.ResumeLayout(false);
            this.pCompte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bRec;
        private System.Windows.Forms.Button bSuivis;
        private System.Windows.Forms.Button bAttente;
        private System.Windows.Forms.Button bCorbeille;
        private System.Windows.Forms.Button bEnvoye;
        private System.Windows.Forms.Panel pCompte;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lPseudo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDeconnexion;
        private System.Windows.Forms.Button bNouvelle;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Label lDate2;
        public System.Windows.Forms.Button bImportant;
        public System.Windows.Forms.Button bLu;
        public System.Windows.Forms.Button bSupp;
        public System.Windows.Forms.Button bRes;
        public System.Windows.Forms.Panel pTop;
        public System.Windows.Forms.Label lEmail;
        public System.Windows.Forms.Panel pMessages;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel pAlerte;
        public System.Windows.Forms.Button bRefresh;
        public System.Windows.Forms.Button bRep;
        private System.Windows.Forms.Button bCompte;

    }
}