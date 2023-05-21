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
    public partial class IzmeniDrvored : Form
    {
        DrvoredView drvored;
        public IzmeniDrvored()
        {
            InitializeComponent();
            this.drvored = null;
        }
        public IzmeniDrvored(DrvoredView drvored)
        {
            InitializeComponent();
            this.drvored = drvored;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(BrStabala.Text, out int brStabala))
            {
                MessageBox.Show("Površina mora biti broj. Vrednost je ostavljena nepromenjena",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                brStabala = drvored.BrStabala;
            }
            DrvoredView drvoredView = new DrvoredView()
            {
                Id = drvored.Id,
            };
            if (Ugrozenost.SelectedItem == null || Ugrozenost.SelectedItem.ToString() == "")
            {
                drvoredView.UgrozenostOdZagadjenja = drvored.UgrozenostOdZagadjenja;
            }
            else
            {
                drvoredView.UgrozenostOdZagadjenja = Ugrozenost.SelectedItem.ToString().ToLower();
            }
            if (Opstina.Text == null || Opstina.Text == "")
            {
                drvoredView.Opstina = drvored.Opstina;
            }
            else
            {
                drvoredView.Opstina = Opstina.Text;
            }
            if (Ulica.Text == null || Ulica.Text == "")
            {
                drvoredView.Ulica = drvored.Ulica;
            }
            else
            {
                drvoredView.Ulica = Ulica.Text;
            }
            if (VrstaDrveta.Text == null || VrstaDrveta.Text == "")
            {
                drvoredView.VrstaDrveta = drvored.VrstaDrveta;
            }
            else
            {
                drvoredView.VrstaDrveta = VrstaDrveta.Text;
            }
            drvoredView.BrStabala = brStabala;
            DTOManager.UpdateDrvored(drvoredView);
        }
    }
}
