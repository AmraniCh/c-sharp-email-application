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
    public partial class FHistorique : Form
    {
        FCompte fc;

        public FHistorique()
        {
            InitializeComponent();
        }

        public FHistorique(FCompte fc)
        {
            InitializeComponent();
            this.fc = fc;
        }

        private void FHistorique_Load(object sender, EventArgs e)
        {
            List<connexion> lc = Form1.dc.connexion.ToList().FindAll(co => co.email == fc.lEmail.Text);
            dataGridView1.DataSource = lc;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
            fc.Visible = true;
        }
    }
}
