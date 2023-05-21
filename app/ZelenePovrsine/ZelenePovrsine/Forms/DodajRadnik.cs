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
    public partial class DodajRadnik : Form
    {
        public DodajRadnik()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DTOManager.AddRadnik(new RadnikView()
            {
                Mbr = Mbr.Text,
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                ImeRoditelja = ImeRoditelja.Text,
                DatumRodjenja = DatumRodjenja.Value,
                Adresa = Adresa.Text,
                OdrzavaHigijenu = OdrzavaHigijenu.Checked ? 1 : 0,
                OdrzavaObjekte = OdrzavaObjekte.Checked ? 1 : 0,
                OdrzavaZelenila = OdrzavaZelenila.Checked ? 1 : 0,
                StrucnaSprema = StrucnaSprema.Text
            });
            Close();
        }
    }
}
