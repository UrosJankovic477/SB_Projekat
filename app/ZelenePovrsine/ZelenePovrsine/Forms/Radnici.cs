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
    public partial class Radnici : Form
    {
        private ListViewItem selectedItem;
        public Radnici()
        {
            InitializeComponent();
            selectedItem = null;
        }

        private void LoadRadnici()
        {
            listView1.Items.Clear();
            var radnici = DTOManager.GetRadnici();
            foreach (var radnik in radnici)
            {
                string odrzava = "";
                foreach(string o in radnik.RadnikOdrzava)
                {
                    odrzava += o + ", ";
                }
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        radnik.Mbr.ToString(),
                        radnik.BrRK.ToString(),
                        radnik.PunoIme,
                        radnik.Adresa,
                        radnik.DatumRodjenja.ToString(),
                        odrzava,
                    }
                    );
                listView1.Items.Add(item);
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listView1.FocusedItem;
        }

        private void Radnici_Load(object sender, EventArgs e)
        {
            LoadRadnici();
        }

        private void DodajRadnika_Click(object sender, EventArgs e)
        {
            Form form = new DodajRadnik();
            Hide();
            form.ShowDialog();
            LoadRadnici();
            Show();
        }
    }
}
