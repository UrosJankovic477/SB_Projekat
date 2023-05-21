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
    public partial class ZelenePovrsine : Form
    {
        ListViewItem selectedItem;
        enum TipPovrsine
        {
            Drvored,
            Park,
            Travnjak
        }
        TipPovrsine tipPovrsine;
        public ZelenePovrsine()
        {
            InitializeComponent();
            selectedItem = null;
        }
        private bool AnythingSelected()
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Nije izabrana nijedna površina. Kliknite na stavku u tabeli da bi ste je izabrali",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LoadDrvoredi()
        {
            var drvoredi = DTOManager.GetAllZelenaPovrsina<DrvoredView>();
            Drvoredi.Items.Clear();
            foreach (var d in drvoredi)
            {
                ListViewItem item = new ListViewItem(new string[] {
                        d.Id.ToString(), d.Opstina, d.UgrozenostOdZagadjenja, d.Ulica,
                        d.VrstaDrveta, d.BrStabala.ToString()});
                Drvoredi.Items.Add(item);
            }
        }
        private void LoadParkovi()
        {
            var parkovi = DTOManager.GetAllZelenaPovrsina<ParkView>();
            Parkovi.Items.Clear();
            foreach (var p in parkovi)
            {
                ListViewItem item = new ListViewItem(new string[] {
                        p.Id.ToString(), p.Opstina, p.UgrozenostOdZagadjenja, p.Naziv,
                        p.Povrsina_hektari.ToString()});
                Parkovi.Items.Add(item);
            }
        }
        private void LoadTravnjaci()
        {
            var travnjaci = DTOManager.GetAllZelenaPovrsina<TravnjakView>();
            Travnjaci.Items.Clear();
            foreach (var t in travnjaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                        t.Id.ToString(), t.Opstina, t.UgrozenostOdZagadjenja, t.AdresaZgrade,
                        t.PovrsinaAri.ToString()});
                Travnjaci.Items.Add(item);
            }
        }
        private void LoadData()
        {
            LoadDrvoredi();
            LoadParkovi();
            LoadTravnjaci();
        }
        private void DodajPovrsinu_Click(object sender, EventArgs e)
        {
            Form form = new DodajZelenaPovrsina();
            Hide();
            form.ShowDialog();
            LoadParkovi();
            LoadDrvoredi();
            LoadTravnjaci();
            Show();
        }

        private void IzmeniPovrsinu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AnythingSelected())
                {
                    return;
                }
                ZelenaPovrsinaView zelenaPovrsina;
                var items = selectedItem.SubItems;
                if (tipPovrsine == TipPovrsine.Travnjak)
                {
                    throw new NotImplementedException();
                    // TODO:
                    // prosledi podatke o povrsini formi (koja ne postoji trenutno)
                    // sakrij trenutnu formu, pokazi novu i kada se ona ugasi ucitaj
                    // odgovarajuce povrsine
                }
                else if (tipPovrsine == TipPovrsine.Park)
                {
                    zelenaPovrsina = new ParkView(
                        int.Parse(items[0].Text), items[1].Text,
                        items[2].Text, items[3].Text, float.Parse(items[4].Text)
                        );
                    Form form = new IzmeniPark(zelenaPovrsina as ParkView);
                    Hide();
                    form.ShowDialog();
                    LoadParkovi();
                    Show();
                }
                else if (tipPovrsine == TipPovrsine.Drvored)
                {
                    zelenaPovrsina = new DrvoredView(
                        int.Parse(items[0].Text), items[1].Text,
                        items[2].Text, items[3].Text, items[4].Text, int.Parse(items[5].Text)
                        );
                    Form form = new IzmeniDrvored(zelenaPovrsina as DrvoredView);
                    Hide();
                    form.ShowDialog();
                    LoadDrvoredi();
                    Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObrisiPovrsinu_Click(object sender, EventArgs e)
        {
            selectedItem = null;
            if (!AnythingSelected())
            {
                return;
            }
            DTOManager.DeleteZelenaPovrsina(int.Parse(selectedItem.SubItems[0].Text));
            if (tipPovrsine == TipPovrsine.Travnjak)
            {
                LoadTravnjaci();
                return;
            }
            if (tipPovrsine == TipPovrsine.Park)
            {
                LoadParkovi();
                return;
            }
            if (tipPovrsine == TipPovrsine.Drvored)
            {
                LoadDrvoredi();
                return;
            }
        }
        private void PrikaziRadnike_Click(object sender, EventArgs e)
        {
            if (!AnythingSelected())
            {
                return;
            }
            if (tipPovrsine != TipPovrsine.Park)
            {
                MessageBox.Show("Morate izabrati park.",
                       "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form form = new RadniciParkForm(int.Parse(selectedItem.SubItems[0].Text));
            Hide();
            form.ShowDialog();
            Show();

        }


        private void PrikaziSefove_Click(object sender, EventArgs e)
        {
            if (!AnythingSelected())
            {
                return;
            }
            if (tipPovrsine != TipPovrsine.Park)
            {
                MessageBox.Show("Morate izabrati park.",
                       "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form form = new SefoviParkForm(int.Parse(selectedItem.SubItems[0].Text));
            Hide();
            form.ShowDialog();
            Show();
        }


        private void ZelenePovrsine_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void Drvoredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = Drvoredi.FocusedItem;
            tipPovrsine = TipPovrsine.Drvored;
        }

        private void Travnjaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = Travnjaci.FocusedItem;
            tipPovrsine = TipPovrsine.Travnjak;
        }

        private void Parkovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = Parkovi.FocusedItem;
            tipPovrsine = TipPovrsine.Park;
        }

        private void PrikaziObjekte_Click(object sender, EventArgs e)
        {
            if (!AnythingSelected())
            {
                return;
            }
            if (tipPovrsine != TipPovrsine.Park)
            {
                MessageBox.Show("Morate izabrati park.",
                       "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form form = new ObjektiParka(int.Parse(selectedItem.SubItems[0].Text));
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
