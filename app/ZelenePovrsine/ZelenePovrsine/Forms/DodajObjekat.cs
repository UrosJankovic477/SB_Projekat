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
    public partial class DodajObjekat : Form
    {
        int parkId;
        public DodajObjekat()
        {
            InitializeComponent();
            parkId = 0;
        }
        public DodajObjekat(int parkId)
        {
            InitializeComponent();
            this.parkId = parkId;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Hide();
                        Form form = new DodajDrvo(parkId);
                        form.ShowDialog();
                        Show();
                        break;
                    }
                case 1:
                    {
                        Hide();
                        Form form = new DodajIgraliste(parkId);
                        form.ShowDialog();
                        Show();
                        break;
                    }
                case 2:
                    {
                        Hide();
                        Form form = new ZasticeniObjekatForm(ZasticeniObjekatForm.Tip.Spomenik, parkId);
                        form.ShowDialog();
                        Show();
                        break;
                    }
                case 3:
                    {
                        Hide();
                        Form form = new ZasticeniObjekatForm(ZasticeniObjekatForm.Tip.Skulptura, parkId);
                        form.ShowDialog();
                        Show();
                        break;
                    }
                case 4:
                    {
                        DTOManager.AddKlupa(parkId);
                        Close();
                        break;
                    }
                case 5:
                    {
                        DTOManager.AddSvetiljka(parkId);
                        Close();
                        break;
                    }
                case 6:
                    {
                        DTOManager.AddFontana(parkId);
                        Close();
                        break;
                    }
                default:
                    {
                        MessageBox.Show(
                        "Izabrana neispravna opcija",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        break;
                    }
                    return;
            }
        }
    }
}
