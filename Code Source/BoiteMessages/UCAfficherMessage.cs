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
    public partial class UCAfficherMessage : UserControl
    {
        FBoite fb;
        UCNouveauMessage ucn;

        public UCAfficherMessage()
        {
            InitializeComponent();
        }

        public UCAfficherMessage(FBoite fb)
        {
            InitializeComponent();
            this.fb = fb;
        }

        public UCAfficherMessage(UCNouveauMessage ucn)
        {
            InitializeComponent();
            this.ucn = ucn;
        }


        private void bBoite_Click(object sender, EventArgs e)
        {
            fb.pMessages.Controls.Clear();
            fb.bRec_Click(sender, e);
        }

        private void bRepondre_Click(object sender, EventArgs e)
        {
            fb.afficherNouveauMessageRepondre();
        }
    }
}
