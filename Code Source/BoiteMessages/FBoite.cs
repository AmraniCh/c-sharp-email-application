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
    public partial class FBoite : Form
    {
        Form1 f1;
        public UCMessages ucm = new UCMessages(); // => ucMessages
        UCAlerte ucl = new UCAlerte();
        UCAfficherMessage uca = new UCAfficherMessage();
        UCNouveauMessage ucn = new UCNouveauMessage();

        public string choixActuel = "Boite de réception"; 

        public FBoite()
        {
            InitializeComponent();
        }
        public FBoite(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public FBoite(UCMessages ucm)
        {
            InitializeComponent();
            this.ucm = ucm;
        }

        public void afficherMessageUC(object sender, EventArgs e)
        {
            UCMessages ucmessage = sender as UCMessages;

            uca = new UCAfficherMessage(this);
            msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(ucmessage.lid.Text));
            
            
            uca.lTitre.Text = m.titre;
            uca.richTextBox1.Text = m.corps;
            uca.lExp.Text = m.emailExp;
            uca.lDate.Text = m.datee.ToString();

            // message lu
            m.lu = 1;
            Form1.dc.SubmitChanges();

            pMessages.Controls.Clear();
            pMessages.Controls.Add(uca);
            uca.richTextBox1.ReadOnly = true;
        }

        public void afficherNouveauMessageRepondre()
        {
            ucn = new UCNouveauMessage(this);

            ucn.tDes.Text = uca.lExp.Text;

            pMessages.Controls.Clear();
            pMessages.Controls.Add(ucn);
        }

        public void bRec_Click(object sender, EventArgs e)
        {
            choixActuel = "Boite de réception";

            pMenu.Height = bRec.Height;
            pMenu.Top = bRec.Top - pTop.Height - pCompte.Height + 2;
            pMessages.Controls.Clear();
            // ponel alerte
            pCenter.Controls.Add(pAlerte);
            chargerMsgRecus();
            masquerpTopControls();

            // design
            pLeftDesignButtons(bRec);
            bRec.Font = new Font(bRec.Font, FontStyle.Bold);
            bRec.ForeColor = Color.White;
            bRec.BackColor = Color.SlateGray;
        }

        private void bSuivis_Click(object sender, EventArgs e)
        {
            choixActuel = "Messages suivis";

            pMenu.Height = bSuivis.Height;
            pMenu.Top = bSuivis.Top - pTop.Height - pCompte.Height + 2;
            pMessages.Controls.Clear();
            // ponel alerte
            pCenter.Controls.Add(pAlerte);
            chargerMsgSuivis();
            masquerpTopControls();

            // design
            pLeftDesignButtons(bSuivis);
            bSuivis.Font = new Font(bSuivis.Font, FontStyle.Bold);
            bSuivis.ForeColor = Color.White;
            bSuivis.BackColor = Color.SlateGray;
        }

        private void bAttente_Click(object sender, EventArgs e)
        {
            choixActuel = "Messages en attente";

            pMenu.Height = bAttente.Height;
            pMenu.Top = bAttente.Top - pTop.Height - pCompte.Height + 2;
            pMessages.Controls.Clear();
            // ponel alerte
            pCenter.Controls.Add(pAlerte);
            chargerMsgEnAttente();
            masquerpTopControls();

            // design
            pLeftDesignButtons(bAttente);
            bAttente.Font = new Font(bAttente.Font, FontStyle.Bold);
            bAttente.ForeColor = Color.White;
            bAttente.BackColor = Color.SlateGray;
        }

        private void bEnvoye_Click(object sender, EventArgs e)
        {
            choixActuel = "Messages envoyés";

            pMenu.Height = bEnvoye.Height;
            pMenu.Top = bEnvoye.Top - pTop.Height - pCompte.Height + 2;
            pMessages.Controls.Clear();
            // ponel alerte
            pCenter.Controls.Add(pAlerte);
            chargerMsgEnvoye();
            masquerpTopControls();

            // design
            pLeftDesignButtons(bEnvoye);
            bEnvoye.Font = new Font(bEnvoye.Font, FontStyle.Bold);
            bEnvoye.ForeColor = Color.White;
            bEnvoye.BackColor = Color.SlateGray;
        }

        private void bCorbeille_Click(object sender, EventArgs e)
        {
            choixActuel = "Corbeille";

            pMenu.Height = bCorbeille.Height;
            pMenu.Top = bCorbeille.Top - pTop.Height - pCompte.Height + 2;
            pMessages.Controls.Clear();
            // ponel alerte
            pCenter.Controls.Add(pAlerte);
            chargerMsgSupprime();
            masquerpTopControls();

            // design
            pLeftDesignButtons(bCorbeille);
            bCorbeille.Font = new Font(bCorbeille.Font, FontStyle.Bold);
            bCorbeille.ForeColor = Color.White;
            bCorbeille.BackColor = Color.SlateGray;
        }

        public void pLeftDesignButtons(Button b)
        {
            foreach (Control control in pLeft.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if ((Button)control != b)
                    {
                        ((Button)control).Font = new Font(((Button)control).Font, FontStyle.Regular);
                        ((Button)control).ForeColor = pLeft.ForeColor;
                        ((Button)control).BackColor = pLeft.BackColor;
                    }
                } 
            }
        }

        private void FBoite_Load(object sender, EventArgs e)
        {
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == f1.tEmail.Text);
            if (l != null)
            {
                lPseudo.Text = l.username;
                lEmail.Text = l.email;
                if (l.derniereCon == null)
                    l.derniereCon = DateTime.Now;
                lDate.Text = l.derniereCon.Value.ToShortDateString();
                lDate2.Text = l.derniereCon.Value.ToShortTimeString();
                Form1.dc.SubmitChanges();
                bRec_Click(sender, e);
            }
            // pAlerte
            pCenter.Controls.Add(pAlerte);
            pAlerte.Controls.Add(ucl);
        }

        public void nonLu()
        {
            int nbrNonLU = Form1.dc.msg.ToList().FindAll(ms => ms.emailOrigin == lEmail.Text && ms.emailDes == lEmail.Text && ms.lu == 0).Count;
            // messages non lus
            bRec.Text = "Boite de reception(" + nbrNonLU + ")";
        }

        private void bDeconnexion_Click(object sender, EventArgs e)
        {
            string email = f1.tEmail.Text;

            connexion c = Form1.dc.connexion.ToList().Skip(Form1.dc.connexion.ToList().Count - 1).SingleOrDefault(co => co.email == email);
            if (c != null)
            {
                c.etat = "Deconnecté";
                DateTime df = DateTime.Now;
                c.FinSession = df;

                TimeSpan duree = df.Subtract(Form1.db);
                double secondes = duree.TotalSeconds;
                if (secondes < 59)
                    c.Dureé = duree.Seconds.ToString() + " Secondes";
                else if (secondes > 59)
                    c.Dureé = duree.Minutes.ToString() + " Minutes " + duree.Seconds.ToString() + " s";
                else
                    c.Dureé = duree.Hours.ToString() + " Heures " + duree.Minutes.ToString() + " m " + duree.Seconds.ToString() + " s";
                Form1.dc.SubmitChanges();
                this.Close();
            }

            f1.Visible = true;
        }

        public void chargerMsgEnvoye()
        {
            foreach (msg m in Form1.dc.msg.ToList())
            {
                if (m.emailOrigin == lEmail.Text) // improtant
                {
                    if (m.emailExp == lEmail.Text && m.supp != 1) // important
                    {
                        ucm = new UCMessages(this);

                        // username
                        log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == m.emailExp);
                        ucm.lUser.Text = l.username;

                        ucm.lMessage.Text = m.corps;
                        ucm.lDate.Text = m.datee.Value.ToShortTimeString();
                        ucm.lid.Text = m.id.ToString();
                        if (m.imp == 1)
                            ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_4; 
                        ucm.rSellectionner.Checked = false;

                        // pMessages design
                        ucm.Left = ucm.Left + 10;
                        ucm.Top = (ucm.Height + 5) * pMessages.Controls.Count;

                        pMessages.Controls.Add(ucm);
                    }
                }
            }
        }

        public void chargerMsgRecus()
        {
            foreach (msg m in Form1.dc.msg.ToList())
            {
                if (m.emailOrigin == lEmail.Text) // improtant
                {
                    if (m.emailDes == lEmail.Text && m.supp != 1) // improtant
                    {
                        ucm = new UCMessages(this);

                        // username
                        log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == m.emailExp);
                        ucm.lUser.Text = l.username;

                        ucm.lMessage.Text = m.corps;
                        ucm.lDate.Text = m.datee.Value.ToShortTimeString();
                        ucm.lid.Text = m.id.ToString();
                        if (m.imp == 1)
                            ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                        if (m.lu == 0)
                            changerColorNonl(ucm);

                                                    nonLu();

                        ucm.rSellectionner.Checked = false;

                        // pMessages design
                        ucm.Left = ucm.Left + 10;
                        ucm.Top = (ucm.Height + 5) * pMessages.Controls.Count;

                        pMessages.Controls.Add(ucm);
                    }
                }
            }
        }

        public void changerColorNonl(UCMessages u)
        {
            u.BackColor = Color.White;
            foreach(Control c in ucm.Controls )
            {
                c.BackColor = Color.FromArgb(255,255,255);
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).Font = new Font("Century Gothic", 10, FontStyle.Bold);
                if (c.GetType() == typeof(ns1.BunifuCheckbox))
                    ((ns1.BunifuCheckbox)c).ChechedOffColor = Color.FromArgb(239, 239, 240);
            }
        }

        public void chargerMsgSuivis()
        {
            foreach (msg m in Form1.dc.msg.ToList())
            {
                if (m.emailOrigin == lEmail.Text) // improtant
                {
                    if (m.emailDes == lEmail.Text || m.emailExp == lEmail.Text) // improtant
                    {
                        if (m.imp == 1 && m.supp != 1)
                        {
                            ucm = new UCMessages(this);

                            // username
                            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == m.emailExp);
                            ucm.lUser.Text = l.username;

                            ucm.lMessage.Text = m.corps;
                            ucm.lDate.Text = m.datee.Value.ToShortDateString();
                            ucm.lid.Text = m.id.ToString();
                            ucm.pictureBox1.Image= BoiteMessages.Properties.Resources.star_4;
                            if (m.emailExp != lEmail.Text  && m.lu !=1) // => NON LU PAS IMPORTANT 
                                changerColorNonl(ucm);
                            ucm.rSellectionner.Checked = false;

                            // pMessages design
                            ucm.Left = ucm.Left + 10;
                            ucm.Top = (ucm.Height + 5) * pMessages.Controls.Count;

                            pMessages.Controls.Add(ucm);
                        }
                    }
                }
            }
        }

        public void chargerMsgEnAttente()
        {
            foreach (msg m in Form1.dc.msg.ToList())
            {
                if (m.emailOrigin == lEmail.Text) // improtant
                {
                    if (m.emailDes == lEmail.Text && m.emailExp != lEmail.Text) // improtant
                    {
                        if (m.supp != 1 && m.lu == 0)
                        {
                            ucm = new UCMessages(this);

                            // username
                            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == m.emailExp);
                            ucm.lUser.Text = l.username;

                            ucm.lMessage.Text = m.corps;
                            ucm.lDate.Text = m.datee.Value.ToShortTimeString();
                            ucm.lid.Text = m.id.ToString();
                            if (m.imp == 1)
                                ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                            if (m.emailExp != lEmail.Text) // => NON LU PAS IMPORTANT 
                                changerColorNonl(ucm);
                            ucm.rSellectionner.Checked = false;

                            // pMessages design
                            ucm.Left = ucm.Left + 10;
                            ucm.Top = (ucm.Height + 5) * pMessages.Controls.Count;

                            pMessages.Controls.Add(ucm);
                        }
                    }
                }
            }
        }

        public void chargerMsgSupprime()
        {
            foreach (msg m in Form1.dc.msg.ToList())
            {
                if (m.emailOrigin == lEmail.Text) // improtant
                {
                    if (m.emailDes == lEmail.Text || m.emailExp == lEmail.Text)
                    {
                        if (m.supp == 1)
                        {
                            ucm = new UCMessages(this);

                            // username
                            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == m.emailExp);
                            ucm.lUser.Text = l.username;

                            ucm.lid.Text = m.id.ToString();
                            ucm.lMessage.Text = m.corps;
                            ucm.lDate.Text = m.datee.Value.ToShortTimeString();
                            if (m.imp == 1)
                                ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                            if (m.lu == 0)
                                changerColorNonl(ucm);
                            ucm.rSellectionner.Checked = false;

                            // pMessages design
                            ucm.Left = ucm.Left + 10;
                            ucm.Top = (ucm.Height + 5) * pMessages.Controls.Count;

                            // masquer favori icon
                            ucm.pictureBox1.Visible = false;
                            ucm.lUser.Left = ucm.lUser.Left - 30;
                            ucm.lMessage.Left = ucm.lMessage.Left - 30;

                            ucm.lMessage.Width = ucm.lMessage.Width + 30;
                            pMessages.Controls.Add(ucm);
                        }
                    }
                }
            }
        }

        private void bImportant_Click(object sender, EventArgs e)
        {
            int nbrImp = 0;
            int nbrNonImp = 0;
            foreach (Control control in pMessages.Controls)
            {
                if (control.GetType().Equals(typeof(UCMessages)))
                {
                    if ((((UCMessages)control).rSellectionner.Checked == true))
                    {
                        msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse((((UCMessages)control).lid.Text)));
                        if (m.imp == 1)
                        {
                            m.imp = 0;
                            Form1.dc.SubmitChanges();
                            ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_3;
                            nbrNonImp++;
                        }
                        else
                        {
                            m.imp = 1;
                            Form1.dc.SubmitChanges();
                            ucm.pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                            nbrImp++;
                        }
                    }
                }
            }
            string message = "message";
            if (nbrImp != 0 && nbrNonImp != 0)
                message = nbrImp.ToString() + " Messages markquer comme suivis | " + nbrNonImp.ToString() + " Messages marquer comme non suivis";
            else if (nbrImp != 0 && nbrNonImp == 0)
                message = nbrImp.ToString() + " Messages marquer comme suivis";
            else
                message = nbrNonImp.ToString() + " Messages marké comme non suivis";
            afficherAstuce(message);

            pTopControlsVisibility();

            actualisrMessages();
        }

        public void pTopControlsVisibility()
        {
           // ptop controls visible false
            foreach (Control c in pTop.Controls)
            {
                if (c.Text != "Nouveau message" && c.Name != "bCompte" && c.Name != "bRefresh")
                {
                    if (c.Visible == true)
                        c.Visible = false;
                }
            }
        }

        public void actualisrMessages()
        {
            pMessages.Controls.Clear();

                if (choixActuel == "Boite de réception")
                    chargerMsgRecus();
                else if (choixActuel == "Messages suivis")
                    chargerMsgSuivis();
                else if (choixActuel == "Messages envoyés")
                    chargerMsgEnvoye();
                else if (choixActuel == "Messages en attente")
                    chargerMsgEnAttente();
                else if (choixActuel == "Corbeille")
                    chargerMsgSupprime();

        }

        private void bNouvelle_Click(object sender, EventArgs e)
        {
            ucn = new UCNouveauMessage(this);
            pMessages.Controls.Clear();
            pMessages.Controls.Add(ucn);
        }

        private void bLu_Click(object sender, EventArgs e)
        {
            int nbrLu = 0;
            int nbrNonLu = 0;
            foreach (Control control in pMessages.Controls)
            {
                if (control.GetType().Equals(typeof(UCMessages)))
                {
                    if ((((UCMessages)control).rSellectionner.Checked == true))
                    {
                        msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse((((UCMessages)control).lid.Text)));
                        if (m.lu == 1)
                        {
                            m.lu = 0;
                            Form1.dc.SubmitChanges();
                            nbrLu++;
                        }
                        else
                        {
                            m.lu = 1;
                            Form1.dc.SubmitChanges();
                            nbrNonLu++;
                        }
                    }
                }
            }

            // ajouter alerte control
            string message = "message";
            if (nbrLu != 0)
                message = nbrLu.ToString() + " Messages mis en attente";
            if (nbrNonLu != 0)
                message = nbrNonLu.ToString() + " Messages marquer comme lu";
            if (nbrLu != 0 && nbrNonLu != 0)
                message = nbrLu.ToString() + " Messages mis en attente | " + nbrNonLu.ToString() + " Messages marquer comme lu";
            afficherAstuce(message);

            pTopControlsVisibility();

            actualisrMessages();
        }

        public void afficherAstuce(string message)
        {
            if (timer1.Enabled)
                timer1.Interval += 3000;

            ucl.label1.Text = message;
            pAlerte.Visible = true;
            timer1.Interval = 3000; // => 3s
            timer1.Start();
            timer1.Tick += (s, ee) =>
            {
                pAlerte.Visible = false;
                timer1.Stop();
            };
        }

        private void bSupp_Click(object sender, EventArgs e)
        {
            int nbrSupp = 0;
            if (choixActuel != "Corbeille")
            {
                foreach (Control c in pMessages.Controls)
                {
                    if (((UCMessages)c).rSellectionner.Checked == true)
                    {
                        msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(((UCMessages)c).lid.Text));
                        m.supp = 1;
                        Form1.dc.SubmitChanges();
                        nbrSupp++;
                    }
                }

                string message = "message";
                if (nbrSupp != 0)
                    message = nbrSupp.ToString() + " message placé dans la corbeille";

                afficherAstuce(message);
            }
            else
            {
                foreach (Control c in pMessages.Controls)
                {
                    if(((UCMessages)c).rSellectionner.Checked == true)
                    {
                        msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(((UCMessages)c).lid.Text));
                        Form1.dc.msg.DeleteOnSubmit(m);
                        Form1.dc.SubmitChanges();
                        nbrSupp++;
                        string message = "message";
                        if (nbrSupp != 0)
                            message = nbrSupp.ToString() + " message supprimés";

                        afficherAstuce(message);
                    }
                }
            }

            pTopControlsVisibility();

            actualisrMessages();
        }

        public void masquerpTopControls()
        {
            foreach (Control c in pTop.Controls)
            {
                if (((Control)c).Name != "bNouvelle" && ((Control)c).Name != "bRefresh" && ((Control)c).Name != "bCompte")
                    c.Visible = false;
            }
        }

        private void bRes_Click(object sender, EventArgs e)
        {
            int nbrRestore = 0;
            foreach (Control c in pMessages.Controls)
            {
                if (((UCMessages)c).rSellectionner.Checked == true)
                {
                    msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(((UCMessages)c).lid.Text));
                    m.supp = 0;
                    Form1.dc.SubmitChanges();
                    nbrRestore++;
                }
            }

            string message = "message";
            if (nbrRestore != 0)
                message = nbrRestore.ToString() + " messages sont restorés";

            afficherAstuce(message);

            pTopControlsVisibility();

            actualisrMessages();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            actualisrMessages();

            nonLu();
            string message = "message";
            message= "Actualisation terminé !";
            afficherAstuce(message);
        }

        private void bCompte_Click(object sender, EventArgs e)
        {
            FCompte fc = new FCompte(this);
            fc.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            fc.Show();
        }

        private void bRep_Click(object sender, EventArgs e)
        {
            foreach (Control c in pMessages.Controls)
            {
                if (((UCMessages)c).rSellectionner.Checked == true)
                {
                    ucn = new UCNouveauMessage(this);
                    msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(((UCMessages)c).lid.Text));
                    ucn.tDes.Text = m.emailExp;
                    pMessages.Controls.Clear();
                    pMessages.Controls.Add(ucn);
                }
            }
        }
    }
}
