namespace BoiteMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lPass = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tPass = new ns1.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSign = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tEmail = new ns1.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(523, 527);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.CornerRadius = 10;
            this.rectangleShape3.Location = new System.Drawing.Point(98, 448);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(134, 51);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.CornerRadius = 10;
            this.rectangleShape2.Location = new System.Drawing.Point(180, 325);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(281, 39);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(180, 255);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(281, 39);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass.ForeColor = System.Drawing.Color.LightCoral;
            this.lPass.Location = new System.Drawing.Point(193, 366);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(149, 17);
            this.lPass.TabIndex = 20;
            this.lPass.Text = "Mot de passe incorrect ";
            this.lPass.Visible = false;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.LightCoral;
            this.lEmail.Location = new System.Drawing.Point(193, 299);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(156, 17);
            this.lEmail.TabIndex = 19;
            this.lEmail.Text = "Adresse email pas existe ";
            this.lEmail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Developpé par EL AMRANI CH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // tPass
            // 
            this.tPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPass.HintForeColor = System.Drawing.Color.Empty;
            this.tPass.HintText = "";
            this.tPass.isPassword = true;
            this.tPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.tPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.tPass.LineThickness = 3;
            this.tPass.Location = new System.Drawing.Point(195, 328);
            this.tPass.Margin = new System.Windows.Forms.Padding(4);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(254, 36);
            this.tPass.TabIndex = 16;
            this.tPass.Text = "Mot de passe";
            this.tPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tPass.Enter += new System.EventHandler(this.tPass_Enter);
            this.tPass.MouseLeave += new System.EventHandler(this.tPass_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoiteMessages.Properties.Resources.gmail__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(115, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(33, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de passe oubliée ?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mot de passe :";
            // 
            // bSign
            // 
            this.bSign.FlatAppearance.BorderSize = 0;
            this.bSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSign.ForeColor = System.Drawing.Color.White;
            this.bSign.Image = global::BoiteMessages.Properties.Resources.login;
            this.bSign.Location = new System.Drawing.Point(295, 452);
            this.bSign.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bSign.Name = "bSign";
            this.bSign.Size = new System.Drawing.Size(115, 43);
            this.bSign.TabIndex = 2;
            this.bSign.Text = "Register";
            this.bSign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSign.UseVisualStyleBackColor = true;
            this.bSign.Click += new System.EventHandler(this.bSign_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Image = global::BoiteMessages.Properties.Resources.login_button;
            this.bLogin.Location = new System.Drawing.Point(108, 454);
            this.bLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(116, 39);
            this.bLogin.TabIndex = 1;
            this.bLogin.Text = " Login ";
            this.bLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tEmail
            // 
            this.tEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tEmail.HintText = "";
            this.tEmail.isPassword = false;
            this.tEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.tEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.tEmail.LineThickness = 3;
            this.tEmail.Location = new System.Drawing.Point(195, 258);
            this.tEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(254, 36);
            this.tEmail.TabIndex = 15;
            this.tEmail.Text = "Adresse email";
            this.tEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tEmail.Enter += new System.EventHandler(this.tEmail_Enter);
            this.tEmail.MouseLeave += new System.EventHandler(this.tEmail_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(523, 527);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSign);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSign;
        private System.Windows.Forms.Button bLogin;
        public ns1.BunifuMaterialTextbox tEmail;
        public ns1.BunifuMaterialTextbox tPass;

    }
}

