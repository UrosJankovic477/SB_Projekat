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
    public partial class DodajZelenaPovrsina : Form
    {
        public DodajZelenaPovrsina()
        {
            InitializeComponent();
        }

        private void Dalje_Click(object sender, EventArgs e)
        {
            try
            {
                Form form;
                var selectedItem = TipPovrsine.SelectedItem;
                if (selectedItem == null)
                {
                    MessageBox.Show("Nije izabran tip površine.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Opstina.Text == null)
                {
                    MessageBox.Show("Polje \"Opstina\" mora biti popunjeno.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tipPovrsine = selectedItem.ToString();
                
                if (tipPovrsine == "Drvored")
                {
                    form = new DodajDrvored(new ZelenaPovrsinaView(0, Ugrozenost.SelectedItem.ToString(), Opstina.Text));
                    Hide();
                    form.ShowDialog();
                    Show();
                    return;
                }
                if (tipPovrsine == "Park")
                {
                    form = new DodajPark(new ZelenaPovrsinaView(0, Ugrozenost.SelectedItem.ToString(), Opstina.Text));
                    Hide();
                    form.ShowDialog();
                    Show();
                    return;
                }
                if (tipPovrsine == "Travnjak")
                {
                    throw new NotImplementedException();
                }
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
