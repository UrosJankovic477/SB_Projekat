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
    public partial class ZasticeniObjekatForm : Form
    {
        DrvoView? drvo;
        int parkId;
        public enum Tip
        {
            Drvo,
            Spomenik,
            Skulptura
        }
        Tip tip;
        public ZasticeniObjekatForm()
        {
            InitializeComponent();
            drvo = null;
        }
        public ZasticeniObjekatForm(Tip tip, int parkId)
        {
            InitializeComponent();
            this.drvo = null;
            this.tip = tip;
            this.parkId = parkId;
        }
        public ZasticeniObjekatForm(DrvoView drvo, int parkId)
        {
            InitializeComponent();
            this.drvo = drvo;
            this.tip = Tip.Drvo;
            this.parkId = parkId;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(GodTroskovi.Text, out int troskovi))
            {
                MessageBox.Show("Godišnji troškovi moraju biti ceo broj.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ZasticeniObjekatView zasticeniObjekat = new ZasticeniObjekatView()
            {
                Opis = Opis.Text,
                GodTroskovi = troskovi,
                Institucija = Institucija.Text,
                StavljenPodZastitu = DatPodZastitu.Value
            };
            if (tip == Tip.Drvo)
            {
                DTOManager.AddDrvo(parkId, drvo, zasticeniObjekat);
            }
            else if (tip == Tip.Spomenik)
            {
                DTOManager.AddSpomenik(parkId, zasticeniObjekat);
            }
            else if (tip == Tip.Skulptura)
            {
                DTOManager.AddSkulptura(parkId, zasticeniObjekat);
            }
            Close();
        }
    }
}
