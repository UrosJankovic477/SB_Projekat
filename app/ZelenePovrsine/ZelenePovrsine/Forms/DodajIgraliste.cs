using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZelenePovrsine.Forms
{
    public partial class DodajIgraliste : Form
    {
        int parkId;
        public DodajIgraliste()
        {
            InitializeComponent();
            parkId = 0;
        }
        public DodajIgraliste(int parkId)
        {
            InitializeComponent();
            this.parkId = parkId;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(BrIgracaka.Text, out int brIgracaka))
            {
                MessageBox.Show("Broj igračaka mora biti ceo broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(GodineOd.Text, out int godineOd))
            {
                MessageBox.Show("\'Godine od\' mora biti ceo broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(GodineDo.Text, out int godineDo))
            {
                MessageBox.Show("\'Godine do\' mora biti ceo broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pesak = Pesak.Checked ? "Da" : "Ne";
            IgralisteView igralisteView = new IgralisteView()
            {
                BrIgracaka = brIgracaka,
                GodineOd = godineOd,
                GodineDo = godineDo,
                ImaPesak = pesak
            };
            DTOManager.AddIgraliste(parkId, igralisteView);
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajIgraliste_Load(object sender, EventArgs e)
        {

        }
    }
}
