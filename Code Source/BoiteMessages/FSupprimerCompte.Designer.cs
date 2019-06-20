namespace BoiteMessages
{
    partial class FSupprimerCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSupprimerCompte));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bSupp = new System.Windows.Forms.Button();
            this.bNon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Êtes-vous sûr de vouloir supprimer votre compte ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoiteMessages.Properties.Resources.gmail__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Developpé par EL AMRANI CH";
            // 
            // bSupp
            // 
            this.bSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bSupp.FlatAppearance.BorderSize = 0;
            this.bSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSupp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupp.ForeColor = System.Drawing.Color.White;
            this.bSupp.Location = new System.Drawing.Point(189, 274);
            this.bSupp.Name = "bSupp";
            this.bSupp.Size = new System.Drawing.Size(146, 42);
            this.bSupp.TabIndex = 44;
            this.bSupp.Text = "Oui je suis sûr";
            this.bSupp.UseVisualStyleBackColor = false;
            this.bSupp.Click += new System.EventHandler(this.bSupp_Click);
            // 
            // bNon
            // 
            this.bNon.BackColor = System.Drawing.Color.SlateGray;
            this.bNon.FlatAppearance.BorderSize = 0;
            this.bNon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bNon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.bNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNon.ForeColor = System.Drawing.Color.White;
            this.bNon.Location = new System.Drawing.Point(47, 274);
            this.bNon.Name = "bNon";
            this.bNon.Size = new System.Drawing.Size(108, 42);
            this.bNon.TabIndex = 45;
            this.bNon.Text = "Non";
            this.bNon.UseVisualStyleBackColor = false;
            this.bNon.Click += new System.EventHandler(this.bNon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Toutes les conversations seront supprimées";
            // 
            // FSupprimerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bNon);
            this.Controls.Add(this.bSupp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FSupprimerCompte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSupp;
        private System.Windows.Forms.Button bNon;
        private System.Windows.Forms.Label label2;
    }
}