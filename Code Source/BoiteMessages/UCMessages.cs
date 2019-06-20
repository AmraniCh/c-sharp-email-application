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
    public partial class UCMessages : UserControl
    {
        FBoite fb;
        string img = "star_3";
        public UCMessages()
        {
            InitializeComponent();
        }

        public UCMessages(FBoite f)
        {
            InitializeComponent();
            this.fb = f;
        }

        private void rSellectionner_OnChange(object sender, EventArgs e)
        {
            // pTop controls visible
            int nbr = 0;
            if (rSellectionner.Checked == true)
            {
                foreach (Control c in fb.pTop.Controls)
                {
                    if (c.Visible == false && ((Button)c).Name != "bRes")
                        c.Visible = true;
                    if(fb.choixActuel == "Corbeille")
                        if (((Button)c).Name == "bRes")
                            c.Visible = true;
                    if (fb.choixActuel == "Messages envoyés")
                        if (((Button)c).Name == "bRep" || ((Button)c).Name == "bLu")
                            c.Visible = false;
                }
                // icon repondre afficher si un message est sellecionné
                iconRepondreVisibility();
            }
            else
            {
                foreach (Control control in fb.pMessages.Controls)
                {
                    if (control.GetType() == (typeof(UCMessages)))
                    {
                        if ((((UCMessages)control).rSellectionner.Checked != true))
                        {
                            nbr++;
                        }
                    }
                }
                // icon repondre afficher si un message est sellecionné
                iconRepondreVisibility();
            }
            // si aucun message sellectionné
            if (nbr == fb.pMessages.Controls.Count)
            {
                foreach (Control c in fb.pTop.Controls)
                {
                    if (c.Text != "Nouveau message" && c.Name != "bRefresh" && c.Name != "bCompte")
                        if (c.Visible == true)
                            c.Visible = false;
                }
            }
            // message icon 
            bool pasLu = false;
            foreach (Control c in fb.pMessages.Controls)
            {
                if (c.GetType() == typeof(UCMessages))
                {
                    if (((UCMessages)c).rSellectionner.Checked == true)
                    {
                        msg m = Form1.dc.msg.ToList().SingleOrDefault(me => me.id == int.Parse(((UCMessages)c).lid.Text));
                        if (m.lu == 0)
                            pasLu = true;
                    }
                }
            }
            // changer icon en attente
            if (pasLu == true)
            {
                foreach (Control c in fb.pTop.Controls)
                {
                    if (((Button)c).Name == "bLu")
                    {
                        ((Button)c).Image = BoiteMessages.Properties.Resources.envelope;
                    }
                }
            }
            else
            {
                foreach (Control c in fb.pTop.Controls)
                {
                    if (((Button)c).Name == "bLu")
                    {
                        ((Button)c).Image = BoiteMessages.Properties.Resources.close_envelope;
                    }
                }
            }
            // masquer les buttons pTop (Corbeille)
            if (fb.choixActuel == "Corbeille")
            {
                foreach (Control c in fb.pTop.Controls)
                {
                    if (c.Text != "Nouveau message" && c.Name != "bSupp" && c.Name != "bRes" && c.Name != "bRefresh"  && c.Name != "bCompte")
                    {
                        if (c.Visible == true)
                            c.Visible = false;
                    }
                }
            }

     
        }

        public void iconRepondreVisibility()
        {
            if (fb.choixActuel != "Messages envoyés") // => icon repondre affiche pas 
            {
                // icon repondre afficher si un message est sellecionné
                int nbrSell = 0;
                foreach (Control cc in fb.pMessages.Controls)
                {
                    if (((UCMessages)cc).rSellectionner.Checked == true)
                        nbrSell++;
                }
                if (nbrSell == 1)
                    fb.bRep.Visible = true;
                else
                    fb.bRep.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         // if(pictureBox1.Image== BoiteMessages.Properties.Resources.star_3)
           // if (pictureBox1.ImageLocation == "\\star-3.png")
            if (img == "star_3")
            {
                msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(lid.Text));
                m.imp = 1;
                Form1.dc.SubmitChanges();
                //  pictureBox1.ImageLocation = "\\star-4.png";
                pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                img = "star_4";
            }
            else
            {
                msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(lid.Text));
                m.imp = 0;
                Form1.dc.SubmitChanges();
                //  pictureBox1.ImageLocation = "\\star-3.png";
                pictureBox1.Image = BoiteMessages.Properties.Resources.star_3;
                img = "star_3";
            }
            if (fb.choixActuel == "Messages suivis")
            {
                if (img == "star_3")
                {
                    msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(lid.Text));
                    m.imp = 1;
                    Form1.dc.SubmitChanges();
                    //  pictureBox1.ImageLocation = "\\star-4.png";
                    pictureBox1.Image = BoiteMessages.Properties.Resources.star_4;
                    img = "star_4";
                }
                else
                {
                    msg m = Form1.dc.msg.ToList().SingleOrDefault(ms => ms.id == int.Parse(lid.Text));
                    m.imp = 0;
                    Form1.dc.SubmitChanges();
                    //  pictureBox1.ImageLocation = "\\star-3.png";
                    pictureBox1.Image = BoiteMessages.Properties.Resources.star_3;
                    img = "star_3";
                }
                fb.pMessages.Controls.Clear();
                fb.chargerMsgSuivis();
            }
        }

        private void UCMessages_Click(object sender, EventArgs e)
        {
            fb.afficherMessageUC(sender, e);
            fb.nonLu();
        }
       

    }
}
