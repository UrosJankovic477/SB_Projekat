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
    public partial class IzmeniPark : Form
    {
        ParkView park;
        public IzmeniPark()
        {
            InitializeComponent();
        }
        public IzmeniPark(ParkView park)
        {
            this.park = park;
            InitializeComponent();
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!float.TryParse(Povrsina_hektari.Text, out float povrsina_hektari))
                {
                    MessageBox.Show("Površina mora biti broj. Vrednost je ostavljena nepromenjena",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    povrsina_hektari = park.Povrsina_hektari;
                }
                ParkView parkView = new ParkView()
                {
                    Id = park.Id,
                };
                if (Ugrozenost.SelectedItem == null || Ugrozenost.SelectedItem.ToString() == "")
                {
                    parkView.UgrozenostOdZagadjenja = park.UgrozenostOdZagadjenja;
                }
                else
                {
                    parkView.UgrozenostOdZagadjenja = Ugrozenost.SelectedItem.ToString().ToLower();
                }
                if (Opstina.Text ==  null || Opstina.Text == "")
                {
                    parkView.Opstina = park.Opstina;
                }
                else
                {
                    parkView.Opstina = Opstina.Text;
                }
                if (Naziv.Text == null || Naziv.Text == "")
                {
                    parkView.Naziv = park.Naziv;
                }
                else
                {
                    parkView.Naziv = Naziv.Text;
                }
                parkView.Povrsina_hektari = povrsina_hektari;
                DTOManager.UpdatePark(parkView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Exception innerEx = ex.InnerException;
                if (innerEx != null)
                {
                    MessageBox.Show(innerEx.Message);
                }
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
