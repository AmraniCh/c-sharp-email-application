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
    public partial class FSupprimerCompte : Form
    {
        FCompte fc;
        Form1 f1;

        public FSupprimerCompte()
        {
            InitializeComponent();
        }

        public FSupprimerCompte(FCompte fc)
        {
            InitializeComponent();
            this.fc = fc;
        }

        public FSupprimerCompte(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }


        private void bNon_Click(object sender, EventArgs e)
        {
            this.Close();
            fc.Visible = true;
        }

        private void bSupp_Click(object sender, EventArgs e)
        {
            // supprimer les messages de compte
            List<msg> lm =Form1.dc.msg.ToList().FindAll(ms => ms.emailOrigin == fc.lEmail.Text || ms.emailExp == fc.lEmail.Text);
            foreach (msg m in lm)
            {
                Form1.dc.msg.DeleteOnSubmit(m);
            }
            // supprimer les sessions
            List<connexion> lc = Form1.dc.connexion.ToList().FindAll(co => co.email == fc.lEmail.Text);
            foreach (connexion c in lc)
            {
                Form1.dc.connexion.DeleteOnSubmit(c);
            }
            Form1.dc.SubmitChanges();
            // supprimer compte
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == fc.lEmail.Text);
            Form1.dc.log_in.DeleteOnSubmit(l);
            Form1.dc.SubmitChanges();

            // login
            Application.Restart();
        }
    }
}
