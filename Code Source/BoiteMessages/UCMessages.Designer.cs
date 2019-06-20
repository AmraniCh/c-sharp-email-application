namespace BoiteMessages
{
    partial class UCMessages
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
            this.rSellectionner = new ns1.BunifuCheckbox();
            this.lDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lid = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rSellectionner
            // 
            this.rSellectionner.BackColor = System.Drawing.Color.White;
            this.rSellectionner.ChechedOffColor = System.Drawing.Color.White;
            this.rSellectionner.Checked = false;
            this.rSellectionner.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.rSellectionner.ForeColor = System.Drawing.Color.White;
            this.rSellectionner.Location = new System.Drawing.Point(10, 17);
            this.rSellectionner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rSellectionner.Name = "rSellectionner";
            this.rSellectionner.Size = new System.Drawing.Size(20, 20);
            this.rSellectionner.TabIndex = 4;
            this.rSellectionner.OnChange += new System.EventHandler(this.rSellectionner_OnChange);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(515, 17);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(38, 17);
            this.lDate.TabIndex = 9;
            this.lDate.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoiteMessages.Properties.Resources.star_3;
            this.pictureBox1.Location = new System.Drawing.Point(29, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lid.Location = new System.Drawing.Point(-2, -2);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(18, 16);
            this.lid.TabIndex = 14;
            this.lid.Text = "id";
            this.lid.Visible = false;
            // 
            // lUser
            // 
            this.lUser.AutoEllipsis = true;
            this.lUser.Location = new System.Drawing.Point(93, 18);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(88, 13);
            this.lUser.TabIndex = 15;
            this.lUser.Text = "Username";
            // 
            // lMessage
            // 
            this.lMessage.AutoEllipsis = true;
            this.lMessage.Location = new System.Drawing.Point(206, 17);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(242, 17);
            this.lMessage.TabIndex = 16;
            this.lMessage.Text = "Message";
            // 
            // UCMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.lid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.rSellectionner);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCMessages";
            this.Size = new System.Drawing.Size(584, 48);
            this.Click += new System.EventHandler(this.UCMessages_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ns1.BunifuCheckbox rSellectionner;
        public System.Windows.Forms.Label lDate;
        public System.Windows.Forms.Label lid;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lUser;
        public System.Windows.Forms.Label lMessage;

    }
}
