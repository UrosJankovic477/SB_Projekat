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
    public partial class DodajPark : Form
    {
        ZelenaPovrsinaView zelenaPovrsina;
        public DodajPark()
        {
            InitializeComponent();
        }

        public DodajPark(ZelenaPovrsinaView zelenaPovrsina)
        {
            this.zelenaPovrsina = zelenaPovrsina;
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Naziv.Text == null)
                {
                    MessageBox.Show("Polje \"Naziv\" mora biti popunjeno.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!float.TryParse(Povrsina_hektari.Text, out float povrsina_hektari))
                {
                    MessageBox.Show("Površina mora biti broj.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ParkView parkView = new ParkView(zelenaPovrsina.Id,
                    zelenaPovrsina.UgrozenostOdZagadjenja,
                    zelenaPovrsina.Opstina,
                    Naziv.Text, povrsina_hektari);
                DTOManager.SavePark(parkView);
                Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
