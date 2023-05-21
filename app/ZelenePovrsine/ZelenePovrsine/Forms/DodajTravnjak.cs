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
    public partial class DodajTravnjak : Form
    {
        ZelenaPovrsinaView zelenaPovrsina;
        public DodajTravnjak()
        {
            InitializeComponent();
            this.zelenaPovrsina = null;
        }
        public DodajTravnjak(ZelenaPovrsinaView zelenaPovrsina)
        {
            InitializeComponent();
            this.zelenaPovrsina = zelenaPovrsina;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (Adresa.Text == null)
            {
                MessageBox.Show("Polje \"Adresa zgrade\" mora biti popunjeno.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(PovrsinaAri.Text, out float povrsinaAri))
            {
                MessageBox.Show("Površina mora biti broj.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TravnjakView travnjakView = new TravnjakView(zelenaPovrsina.Id,
                zelenaPovrsina.UgrozenostOdZagadjenja,
                zelenaPovrsina.Opstina,
                Adresa.Text, povrsinaAri);
            DTOManager.SaveTravnjak(travnjakView);
            Close();
        }
    }
}
