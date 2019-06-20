using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoiteMessages
{
    public partial class FCompte : Form
    {
        FBoite fb;

        public FCompte()
        {
            InitializeComponent();
        }

        public FCompte(FBoite fb)
        {
            InitializeComponent();
            this.fb = fb;
        }

        private void FCompte_Load(object sender, EventArgs e)
        {
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == fb.lEmail.Text);

            lPseudo.Text = l.username;
            lEmail.Text = l.email;
            lPass.Text = l.mdpss;
            lSession.Text = l.derniereCon.ToString();
            lNaissance.Text = l.naissance.Value.ToShortDateString();
            lCreation.Text = l.dateCreation.ToString();

            int nbrEnvoye = Form1.dc.msg.ToList().FindAll(ms => ms.emailOrigin == l.email && ms.emailExp == l.email).Count;
            lEnvoye.Text = nbrEnvoye.ToString();

            int nbrRecus = Form1.dc.msg.ToList().FindAll(ms => ms.emailOrigin == l.email && ms.emailDes == l.email).Count;
            lRecus.Text = nbrRecus.ToString();

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
            fb.Visible = true;
        }

        private void lSupp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSupprimerCompte fs = new FSupprimerCompte(this);
            fs.StartPosition = FormStartPosition.CenterScreen;
            fs.Show();
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FHistorique fs = new FHistorique(this);
            fs.StartPosition = FormStartPosition.CenterScreen;
            fs.Show();
        }
    }
}
