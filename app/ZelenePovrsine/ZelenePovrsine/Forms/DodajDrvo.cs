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
    public partial class DodajDrvo : Form
    {
        int parkId;
        public DodajDrvo()
        {
            InitializeComponent();
            parkId = 0;
        }
        public DodajDrvo(int parkId)
        {
            InitializeComponent();
            this.parkId = parkId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(Visina.Text, out float visina))
            {
                MessageBox.Show("Visina mora biti broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(Obim.Text, out float obim))
            {
                MessageBox.Show("Obim mora biti broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(Povrsina.Text, out float povrsina))
            {
                MessageBox.Show("Povrsina mora biti broj",
                   "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DrvoView drvoView = new DrvoView()
            {
                DatumSadjenja = DatSadjenja.Value,
                ObimDebla = obim,
                PovrsinaKrosnje = povrsina,
                VisinaKrosnje = visina,
                Vrsta = Vrsta.Text
            };
            if (Zastita.Checked)
            {
                Hide();
                Form form = new ZasticeniObjekatForm(drvoView, parkId);
                form.ShowDialog();
                Show();
            }
            else
            {
                DTOManager.AddDrvo(parkId, drvoView, null);
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
