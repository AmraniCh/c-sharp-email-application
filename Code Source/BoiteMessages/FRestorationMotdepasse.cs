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
    public partial class FRestorationMotdepasse : Form
    {
        Form1 f1;

        public FRestorationMotdepasse()
        {
            InitializeComponent();
        }

        public FRestorationMotdepasse(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void bRecuperer_Click(object sender, EventArgs e)
        {
            DateTime naiss = DateTime.Now;
            int vide = 0;
            foreach (Control c in panel1.Controls)
            {
                if(c.GetType() == typeof(ComboBox))
                    if (((ComboBox)c).Text == "")
                        vide = 1;
            }
            if (comboJour.Enabled != false && vide != 1)
                naiss = DateTime.Parse(comboJour.Text+"/"+comboMois.Text+"/"+comboAnne.Text);
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.naissance == naiss && lo.email == tEmail.Text);
            if (l != null)
            {
                bRecuperer.Visible = false;
                rectangleShape3.Visible = false;
                bVerifie.Visible = true;
                rectangleShape5.Visible = true;

                timer1.Interval = 600; // => 3s
                timer1.Start();
                timer1.Tick += (s, ee) =>
                {
                    bRecuperer.Visible = true;
                    rectangleShape3.Visible = true;
                    bVerifie.Visible = false;
                    rectangleShape5.Visible = false;

                    lPass.Text = l.mdpss.ToString();
                    bLogin.Enabled = true;

                    timer1.Stop();
                };
            }
            else
            {
                bRecuperer.Visible = false;
                rectangleShape3.Visible = false;
                bPasverifier.Visible = true;
                rectangleShape4.Visible = true;

                timer1.Interval = 600; // => 3s
                timer1.Start();
                timer1.Tick += (s, ee) =>
                {
                    bRecuperer.Visible = true;
                    rectangleShape3.Visible = true;
                    bPasverifier.Visible = false;
                    rectangleShape4.Visible = false;
                    timer1.Stop();
                };
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            log_in l = Form1.dc.log_in.ToList().SingleOrDefault(lo => lo.email == tEmail.Text);
            if (l != null)
            {
                comboJour.Enabled = true;
                comboMois.Enabled = true;
                comboAnne.Enabled = true;
                bRecuperer.Enabled = true;
                bPasverifier.Enabled = true;
                bVerifie.Enabled = true;
            }
            else
            {
                lEmail.Text = "emeil existe pas, donner une adresse valide";
                lEmail.Visible = true;
                comboJour.Enabled = false;
                comboMois.Enabled = false;
                comboAnne.Enabled = false;
            }
        }

        private void tEmail_Enter(object sender, EventArgs e)
        {
            lEmail.Visible = false;
            tEmail.LineIdleColor = Color.FromArgb(64, 64, 64);
            if (tEmail.Text == "Adresse email")
            {
                tEmail.Text = "";
                tEmail.ForeColor = Color.FromArgb(41, 44, 51);
                tEmail.Font = new Font(tEmail.Font, FontStyle.Bold);
            }
        }

        private void FRestorationMotdepasse_Load(object sender, EventArgs e)
        {
            comboJour.DropDownHeight = 200;
            for (int i = 1; i <= 31; i++)
            {
                comboJour.Items.Add(i.ToString());
            }

            comboMois.DropDownHeight = 200;
            for (int i = 1; i <= 12; i++)
            {
                comboMois.Items.Add(i.ToString());
            }

            comboAnne.DropDownHeight = 200;
            for (int i = 1995; i <= 2018; i++)
            {
                comboAnne.Items.Add(i.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = bOk.BackColor;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = this.BackColor;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            f1.tEmail.Text = tEmail.Text;
            f1.tPass.Text = lPass.Text;
            this.Close();
        }

        private void tEmail_MouseLeave(object sender, EventArgs e)
        {
            if (tEmail.Text == "" || tEmail.Text.Length < 5)
            {
                tEmail.LineIdleColor = Color.FromArgb(64, 64, 64);
                tEmail.Font = new Font(tEmail.Font, FontStyle.Regular);
                tEmail.Text = "Adresse email";
            }
        }

    }
}
