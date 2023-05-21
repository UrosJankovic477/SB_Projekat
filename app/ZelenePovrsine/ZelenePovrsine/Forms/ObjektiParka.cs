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
    public partial class ObjektiParka : Form
    {
        int parkId;
        ListViewItem selectedItem;
        public ObjektiParka()
        {
            InitializeComponent();
            this.parkId = 0;
            this.selectedItem = null;
        }
        public ObjektiParka(int parkId)
        {
            InitializeComponent();
            this.parkId = parkId;
            this.selectedItem = null;
        }
        private void LoadDrvece()
        {
            var drvece = DTOManager.GetDrvece(parkId);
            foreach (var drvo in drvece)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        drvo.Id.ToString(),
                        drvo.Vrsta,
                        drvo.VisinaKrosnje.ToString(),
                        drvo.PovrsinaKrosnje.ToString(),
                        drvo.ObimDebla.ToString(),
                        drvo.DatumSadjenja.ToString()
                    });
                Drvece.Items.Add(item);
            }
        }
        private void LoadIgralista()
        {
            var igralista = DTOManager.GetIgralista(parkId);
            foreach (var igraliste in igralista)
            {
                string ogranicenje = igraliste.GodineDo == null ?
                   "/" : igraliste.GodineDo.ToString();
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        igraliste.Id.ToString(),
                        igraliste.BrIgracaka.ToString(),
                        $"{igraliste.GodineOd} - {ogranicenje} godina",
                        igraliste.ImaPesak,
                    });
                Igralista.Items.Add(item);
            }
        }
        private void LoadOstalo()
        {
            var objekti = DTOManager.GetOstalo(parkId);
            foreach (var objekat in objekti)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        objekat.Id.ToString(),
                        objekat.Tip
                    });
                Ostalo.Items.Add(item);
            }
        }
        private void ObjektiParka_Load(object sender, EventArgs e)
        {
            LoadDrvece();
            LoadIgralista();
            LoadOstalo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ZasticeniObjekti(parkId);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void DodajPovrsinu_Click(object sender, EventArgs e)
        {

        }

        private void ObrisiPovrsinu_Click(object sender, EventArgs e)
        {
            selectedItem = null;
            DTOManager.DeleteObjekat(int.Parse(selectedItem.SubItems[0].Text));
        }
    }
}
