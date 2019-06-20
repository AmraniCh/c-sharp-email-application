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
    public partial class Form1 : Form
    {
        public static DataClasses1DataContext dc = new DataClasses1DataContext();
        public static DateTime db = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }
      

        private void bLogin_Click(object sender, EventArgs e)
        {
            log_in l = dc.log_in.ToList().SingleOrDefault(lo => lo.email == tEmail.Text);
            if (l != null)
            {
                if (l.mdpss == tPass.Text)
                {
                    db = DateTime.Now;

                    connexion c = new connexion();
                    c.etat = "Connecté";
                    c.email = tEmail.Text;
                    c.DebutSession = db;
                    dc.connexion.InsertOnSubmit(c);
                    dc.SubmitChanges();

                    l.derniereCon = db;

                    // hide 
                    this.Visible = false;

                    FBoite b = new FBoite(this);
                    b.Show();
                }
                else
                {
                    tPass.LineIdleColor = Color.FromArgb(228, 103, 103);
                    lPass.Visible = true;
                }
            }
            else
            {
                tEmail.LineIdleColor = Color.FromArgb(228, 103, 103);
                tPass.LineIdleColor = Color.FromArgb(228, 103, 103);
                lEmail.Visible = true;
                lPass.Visible = true;
            }
        }

        private void bSign_Click(object sender, EventArgs e)
        {
            FSignup s = new FSignup(this);
            this.Visible = false;
            s.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            tEmail.LineIdleColor = Color.FromArgb(236, 240, 241);
            tPass.LineIdleColor = Color.FromArgb(236, 240, 241);
        }

        private void tPass_Enter(object sender, EventArgs e)
        {
            lPass.Visible = false;
            tEmail.LineIdleColor = Color.FromArgb(64, 64, 64);
            if (tPass.Text == "Mot de passe")
            {
                tPass.Text = "";
                tPass.ForeColor = Color.FromArgb(41, 44, 51);
                tPass.Font = new Font(tEmail.Font, FontStyle.Bold);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(192, 192, 45);
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(41, 44, 51);
            label1.ForeColor = Color.White;
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

        private void tPass_MouseLeave(object sender, EventArgs e)
        {
            if (tPass.Text == "" || tPass.Text.Length < 5)
            {
                tPass.LineIdleColor = Color.FromArgb(64, 64, 64);
                tPass.Font = new Font(tPass.Font, FontStyle.Regular);
                tPass.Text = "Mot de passe";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRestorationMotdepasse fr = new FRestorationMotdepasse(this);
            fr.Show();
        }


    }
}
