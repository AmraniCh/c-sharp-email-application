using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoiteMessages
{
    public partial class UCNouveauMessage : UserControl
    {

        FBoite fb;
        UCAlerte uca;

        public UCNouveauMessage()
        {
            InitializeComponent();
        }

        public UCNouveauMessage(FBoite fb)
        {
            InitializeComponent();
            this.fb = fb;
        }

        public UCNouveauMessage(UCAlerte uca)
        {
            InitializeComponent();
            this.uca = uca;
        }

        private void tDes_Enter(object sender, EventArgs e)
        {
            if (tDes.Text == "...")
                tDes.Text = "";
            if (tDes.ForeColor == Color.LightCoral)
                tDes.ForeColor = Color.White;
        }

        private void tDes_Leave(object sender, EventArgs e)
        {
            if (tDes.Text == "")
                tDes.Text = "...";
        }

        private void tObjet_Enter(object sender, EventArgs e)
        {
            if (tObjet.Text == "Object")
                tObjet.Text = "";
            if (tObjet.ForeColor == Color.LightCoral)
                tObjet.ForeColor = Color.White;
        }

        private void tObjet_Leave(object sender, EventArgs e)
        {
            if (tObjet.Text == "")
                tObjet.Text = "Object";
        }

        private void bEnvoyer_Click(object sender, EventArgs e)
        {
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == tDes.Text);
            if (l != null)
            {
                if (tDes.Text != "..." && tObjet.Text != "Objet" && richTextBox1.Text != "")
                {
                    msg m = new msg();

                    m.titre = tObjet.Text;
                    m.corps = richTextBox1.Text;
                    m.datee = DateTime.Now;
                    m.imp = 0;
                    m.supp = 0;
                    m.lu = 1;
                    m.emailOrigin = fb.lEmail.Text;
                    m.emailExp = fb.lEmail.Text;
                    m.emailDes = tDes.Text;
                    Form1.dc.msg.InsertOnSubmit(m);

                    Form1.dc.SubmitChanges();

                    uca = new UCAlerte();
                    fb.afficherAstuce("Votre message est bien envoyé !");

                    timer1.Interval = 100;
                    timer1.Start();
                    timer1.Tick += (s, ee) =>
                    {
                        bEnvoyer.Visible = false;
                        bRecu.Visible = true;
                        timer1.Stop();

                        timer2.Interval = 1000;
                        timer2.Start();
                        timer2.Tick += (ss, eee) =>
                        {
                            bEnvoyer.Visible = true;
                            bRecu.Visible = false;
                            timer2.Stop();
                        };
                    };
                }
                else
                {
                    if (tObjet.Text == "Objet")
                        tObjet.ForeColor = Color.LightCoral;
                    if (richTextBox1.Text == "")
                        richTextBox1.BackColor = Color.LightCoral;
                }
            }
            else
            {
                // design
                tDes.ForeColor = Color.LightCoral;

                timer3.Interval = 100;
                timer3.Start();
                timer3.Tick += (s, ee) =>
                {
                    bEnvoyer.Visible = false;
                    recEnvoye.BackColor = Color.FromArgb(220, 64, 64);
                    bRessayez.Visible = true;
                    timer3.Stop();

                    timer2.Interval = 1000;
                    timer2.Start();
                    timer2.Tick += (ss, eee) =>
                    {
                        bEnvoyer.Visible = true;
                        recEnvoye.BackColor = Color.FromArgb(192, 192, 45);
                        bRessayez.Visible = false;
                        timer2.Stop();
                    };
                };
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            fb.pMessages.Controls.Clear();
            fb.bRec_Click(sender, e);
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.BackColor == Color.LightCoral)
                richTextBox1.BackColor = Color.White;
        }
    }
}
