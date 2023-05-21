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
    public partial class ZasticeniObjekti : Form
    {
        int parkId;
        ListViewItem selectedItem;
        public ZasticeniObjekti()
        {
            InitializeComponent();
            parkId = 0;
            selectedItem = null;
        }
        public ZasticeniObjekti(int parkId)
        {
            InitializeComponent();
            this.parkId = parkId;
            selectedItem = null;
        }
        private void LoadDrvece()
        {
            var drvece = DTOManager.GetZasticenoDrvece();
            foreach (var drvo in drvece)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    drvo.Id.ToString(),
                    drvo.Vrsta,
                    drvo.VisinaKrosnje.ToString(),
                    drvo.PovrsinaKrosnje.ToString(),
                    drvo.ObimDebla.ToString(),
                    drvo.objekat.Opis,
                    drvo.objekat.Institucija,
                    drvo.objekat.StavljenPodZastitu.ToString(),
                    drvo.objekat.GodTroskovi.ToString(),
                });
                Drvece.Items.Add(item);
            }
        }
        private void LoadOstalo()
        {
            var ostalo = DTOManager.GetSkulptureSpomenike(parkId);
            foreach (var objekat in ostalo)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    objekat.Id.ToString(),
                    objekat.Tip,
                    objekat.objekat.Opis.ToString(),
                    objekat.objekat.Institucija.ToString(),
                    objekat.objekat.StavljenPodZastitu.ToString(),
                    objekat.objekat.GodTroskovi.ToString(),
                });
                Ostalo.Items.Add(item);
            }
        }
        private void ZasticeniObjekti_Load(object sender, EventArgs e)
        {
            LoadDrvece();
            LoadOstalo();
        }

        private void ObrisiPovrsinu_Click(object sender, EventArgs e)
        {
            selectedItem = null;
            DTOManager.DeleteObjekat(int.Parse(selectedItem.SubItems[0].Text));
        }

        private void outerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
