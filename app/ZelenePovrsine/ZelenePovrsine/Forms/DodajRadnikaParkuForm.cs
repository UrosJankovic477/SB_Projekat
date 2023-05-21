﻿using System;
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
    public partial class DodajRadnikaParkuForm : Form
    {
        ListViewItem selectedItem;
        int parkId;
        public DodajRadnikaParkuForm()
        {
            InitializeComponent();
            selectedItem = null;
            this.parkId = 0;
        }
        public DodajRadnikaParkuForm(int parkId)
        {
            InitializeComponent();
            selectedItem = null;
            this.parkId = parkId;
        }
        private void LoadRadnici()
        {
            listView1.Items.Clear();
            var radnici = DTOManager.GetRadnici();
            foreach (var radnik in radnici)
            {
                string odrzava = "";
                foreach (string o in radnik.RadnikOdrzava)
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

        private void DodeliRadnika_Click(object sender, EventArgs e)
        {
            DTOManager.EnrollRadnik(int.Parse(selectedItem.SubItems[1].Text), parkId);
        }

        private void DodajRadnikaParkuForm_Load(object sender, EventArgs e)
        {
            LoadRadnici();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listView1.FocusedItem;
        }
    }
}
