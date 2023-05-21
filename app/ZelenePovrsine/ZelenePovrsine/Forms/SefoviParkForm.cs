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
    public partial class SefoviParkForm : Form
    {
        private int parkId;
        private ListViewItem selectedItem;
        public SefoviParkForm()
        {
            InitializeComponent();
            parkId = 0;
            selectedItem = null;
        }
        public SefoviParkForm(int ParkId)
        {
            InitializeComponent();
            parkId = ParkId;
            selectedItem = null;
        }
        private void LoadRadnici()
        {
            IList<RadnikView> radnici = DTOManager.GetSefoviParka(parkId);
            Radnici.Items.Clear();
            foreach (var radnik in radnici)
            {
                string napustioGrupu;
                if (radnik.DatumDo == null)
                {
                    napustioGrupu = "Ne";
                }
                else
                {
                    napustioGrupu = radnik.DatumDo.ToString();
                }
                string odrzava = "";
                foreach (string s in radnik.RadnikOdrzava)
                {
                    odrzava += s + ", ";
                }
                if (odrzava == "")
                {
                    odrzava = "Ništa";
                }
                else
                {
                    odrzava.Remove(odrzava.Length - 3, 2);
                }
                ListViewItem item = new ListViewItem(new string[] {radnik.Mbr.ToString(), radnik.BrRK.ToString(),
                    radnik.PunoIme, radnik.Adresa, radnik.DatumRodjenja.ToString(), odrzava,
                    radnik.DatumOd.ToString(), napustioGrupu});
                Radnici.Items.Add(item);
            }
        }
        private bool AnythingSelected()
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Nije izabran nijedn radnik. Kliknite na stavku u tabeli da bi ste je izabrali",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void IzbaciRadnika_Click(object sender, EventArgs e)
        {
            if (!AnythingSelected())
            {
                return;
            }
            DTOManager.UnenrollSef(
                int.Parse(Radnici.FocusedItem.SubItems[1].Text),
                parkId);
            LoadRadnici();
        }

        private void Radnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = Radnici.FocusedItem;
        }

        private void DodajRadnika_Click(object sender, EventArgs e)
        {

        }

        private void SefoviParkForm_Load(object sender, EventArgs e)
        {
            LoadRadnici();
        }
    }
}

