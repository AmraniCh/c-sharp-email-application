using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BoiteMessages
{
    public partial class FSignup : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Form1 f;

        public FSignup()
        {
            InitializeComponent();
        }

        public FSignup(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }


        string img = "view";

        private void label8_MouseHover(object sender, EventArgs e)
        {

            label8.BackColor = pLeft.BackColor;
            label8.ForeColor = pRight.BackColor;      
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {         
            label8.BackColor = pRight.BackColor;
            label8.ForeColor = pLeft.BackColor;   
        }

        private void tPseudo_MouseEnter(object sender, EventArgs e)
        {
            if (tPseudo.Text == "Pseudo")
            {
                tPseudo.Text = "";
                tPseudo.Font = new Font(tPseudo.Font, FontStyle.Bold);
            }
        }

        private void tEmail_MouseLeave(object sender, EventArgs e)
        {
            if (tEmail.Text == "" || tEmail.Text.Length < 5)
            {
                tEmail.LineIdleColor = Color.FromArgb(64, 64, 64);
                tEmail.Font = new Font(tEmail.Font, FontStyle.Regular);
                tEmail.Text = "someone@example.com";
            }
        }

        private void tEmail_Enter(object sender, EventArgs e)
        {
            if (tEmail.Text == "someone@example.com")
            {
                lEmail.Visible = false;
                tEmail.Font = new Font(tEmail.Font, FontStyle.Bold);
                tEmail.Text = "";
            }
        }

        private void FSignup_Load(object sender, EventArgs e)
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


        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Visible = true;
        }

        private void tPass2_MouseLeave(object sender, EventArgs e)
        {
            if (tPass2.Text == "" || tPass2.Text.Length < 5)
            {
                tPass2.LineIdleColor = Color.FromArgb(64, 64, 64);
                tPass2.Font = new Font(tPass2.Font, FontStyle.Regular);
                tPass2.Text = "Confirmer mot de passe";
            }
        }

        private void tPass2_MouseEnter(object sender, EventArgs e)
        {
            if (tPass2.Text == "Confirmer mot de passe")
            {
                lPass2.Visible = false;
                tPass2.Text = "";
                tPass2.Font = new Font(tPass2.Font, FontStyle.Bold);
            }
        }


        private void tPseudo_Enter(object sender, EventArgs e)
        {
            if (tPseudo.Text == "Pseudo")
            {
                lPseudo.Visible = false;
                tPseudo.Font = new Font(tPseudo.Font, FontStyle.Bold);
                tPseudo.Text = "";
            }
        }

        private void tPseudo_MouseLeave_1(object sender, EventArgs e)
        {
            if (tPseudo.Text == "" || tPseudo.Text.Length < 5)
            {
                tPseudo.LineIdleColor = Color.FromArgb(64, 64, 64);
                tPseudo.Font = new Font(tPseudo.Font, FontStyle.Regular);
                tPseudo.Text = "Pseudo";
            }
        }

        private void tPass_Enter(object sender, EventArgs e)
        {
            if (tPass1.Text == "Mot de passe")
            {
                lPass1.Visible = false;
                tPass1.Text = "";
                tPass1.Font = new Font(tPass2.Font, FontStyle.Bold);
            }
        }

        private void tPass1_MouseLeave(object sender, EventArgs e)
        {
            if (tPass1.Text == "" || tPass1.Text.Length < 5)
            {
                tPass1.LineIdleColor = Color.FromArgb(64, 64, 64);
                tPass1.Font = new Font(tPass1.Font, FontStyle.Regular);
                tPass1.Text = "Mot de passe";
            }
        }

        private void pRight_Paint(object sender, PaintEventArgs e)
        {
            if (tPseudo.Text == "")
            {
                tPseudo.Font = new Font(tPseudo.Font, FontStyle.Regular);
                tPseudo.Text = "Pseudo";
            }
            // changer la valeur de combobox seulement avec la liste déroulante 
            comboJour.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMois.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAnne.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (img == "view")
            {
                pictureBox2.Image = BoiteMessages.Properties.Resources.hide;
                tPass1.isPassword = true;
                tPass2.isPassword = true;
                img = "hide";
            }
            else
            {
                pictureBox2.Image = BoiteMessages.Properties.Resources.view;
                tPass1.isPassword = false;
                tPass2.isPassword = false;
                img = "view";
            }
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (tPseudo.Text == "Pseudo" || tPseudo.Text.Length < 5)
            {
                lPseudo.Text = "Pseudo rejeté et il doit etre supérieur au 5 caractères";
                lPseudo.Visible = true;
                tPseudo.LineIdleColor = Color.LightCoral;
            }
            if (tEmail.Text == "someone@example.com")
            {
                lEmail.Text = "Email rejeté veuillez entrer unu adresse valide";
                lEmail.Visible = true;
                tEmail.LineIdleColor = Color.LightCoral;
            }
            if (tPass1.Text == "Mot de passe" || tPass1.Text.Length < 5)
            {
                lPass1.Text = "Veuillez entrer une mot de passe valide (contient pas les espaces)";
                lPass1.Visible = true;
                tPass1.LineIdleColor = Color.LightCoral;
            }
            if (tPass2.Text != tPass1.Text)
            {
                lPass2.Text = "Les deux mots de passe sont pas identiques";
                lPass2.Visible = true;
                tPass2.LineIdleColor = Color.LightCoral;
            }
            if (comboJour.Text == "" || comboMois.Text == "" || comboAnne.Text == "")
            {
                lNaissance.Text = "Veuillez choisissez votre date de naissance";
                lNaissance.Visible = true;
                comboJour.BackColor = Color.LightCoral;
                comboMois.BackColor = Color.LightCoral;
                comboAnne.BackColor = Color.LightCoral;
            }
            if (rAgree.Checked == false)
            {
                label18.ForeColor = Color.LightCoral;
                rAgree.BackColor = Color.LightCoral;
            }
            if (lPseudo.Visible == false && lEmail.Visible == false && lPass1.Visible == false && lPass2.Visible==false &&
                    lNaissance.Visible == false && rAgree.Checked == true)
            {
                string username = tPseudo.Text;
                string email = tEmail.Text;
                string pass = tPass2.Text;
                DateTime d = DateTime.Parse(comboJour.Text + "/" + comboMois.Text + "/" + comboAnne.Text);
                log_in l = new log_in();
                l.email = email;
                l.username = username;
                l.mdpss = pass;
                l.naissance = d;
                l.dateCreation = DateTime.Now;

                dc.log_in.InsertOnSubmit(l);
                dc.SubmitChanges();

                this.Close();
                FCreationCompte fc = new FCreationCompte();
                fc.StartPosition = FormStartPosition.CenterScreen;
                fc.Show();
            }
            
        }

        private void rAgree_OnChange(object sender, EventArgs e)
        {
            if (rAgree.Checked == true)
            {
                label18.ForeColor = Color.FromArgb(62, 120, 138);
                rAgree.BackColor = Color.FromArgb(221, 221, 45);
            }
        }

        private void comboJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboJour.Text != "")
            {
                comboJour.BackColor = Color.WhiteSmoke;
                if (comboMois.Text != "" && comboAnne.Text != "")
                    lNaissance.Visible = false;
            }
        }

        private void comboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMois.Text != "")
            {
                comboMois.BackColor = Color.WhiteSmoke;
                if (comboJour.Text != "" && comboAnne.Text != "")
                    lNaissance.Visible = false;
            }
        }

        private void comboAnne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnne.Text != "")
            {
                comboAnne.BackColor = Color.WhiteSmoke;
                if (comboMois.Text != "" && comboJour.Text != "")
                    lNaissance.Visible = false;
            }
        }
    }
}
