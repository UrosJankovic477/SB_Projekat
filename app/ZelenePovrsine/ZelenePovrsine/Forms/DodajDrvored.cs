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
    public partial class DodajDrvored : Form
    {
        ZelenaPovrsinaView zelenaPovrsina;
        public DodajDrvored()
        {
            InitializeComponent();
            zelenaPovrsina = null;
        }
        public DodajDrvored(ZelenaPovrsinaView zelenaPovrsina)
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
            if (Ulica.Text == null)
            {
                MessageBox.Show("Polje \"Ulica\" mora biti popunjeno.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (VrstaDrveta.Text == null)
            {
                MessageBox.Show("Polje \"Vrsta drveta\" mora biti popunjeno.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(BrStabala.Text, out int brStabala))
            {
                MessageBox.Show("Površina mora biti ceo broj.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DrvoredView drvoredView = new DrvoredView(zelenaPovrsina.Id,
                zelenaPovrsina.UgrozenostOdZagadjenja,
                zelenaPovrsina.Opstina,
                Ulica.Text, VrstaDrveta.Text, brStabala);
            DTOManager.SaveDrvored(drvoredView);
            Close();
        }

        
    }
}
