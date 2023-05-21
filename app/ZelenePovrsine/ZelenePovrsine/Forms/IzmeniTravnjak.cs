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
    public partial class IzmeniTravnjak : Form
    {
        TravnjakView travnjak;
        public IzmeniTravnjak()
        {
            InitializeComponent();
            this.travnjak = null;
        }
        public IzmeniTravnjak(TravnjakView travnjak)
        {
            InitializeComponent();
            this.travnjak = travnjak;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(PovrsinaAri.Text, out float povrsinaAri))
            {
                MessageBox.Show("Površina mora biti broj. Vrednost je ostavljena nepromenjena",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                povrsinaAri = travnjak.PovrsinaAri;
            }
            TravnjakView travnjakView = new TravnjakView()
            {
                Id = travnjak.Id,
            };
            if (Ugrozenost.SelectedItem == null || Ugrozenost.SelectedItem.ToString() == "")
            {
                travnjakView.UgrozenostOdZagadjenja = travnjak.UgrozenostOdZagadjenja;
            }
            else
            {
                travnjakView.UgrozenostOdZagadjenja = Ugrozenost.SelectedItem.ToString().ToLower();
            }
            if (Opstina.Text == null || Opstina.Text == "")
            {
                travnjakView.Opstina = travnjak.Opstina;
            }
            else
            {
                travnjakView.Opstina = Opstina.Text;
            }
            if (Adresa.Text == null || Adresa.Text == "")
            {
                travnjakView.AdresaZgrade = travnjak.AdresaZgrade;
            }
            else
            {
                travnjakView.AdresaZgrade = Adresa.Text;
            }
            travnjakView.PovrsinaAri = povrsinaAri;
            DTOManager.UpdateTravnjak(travnjakView);
        }
    }
}
