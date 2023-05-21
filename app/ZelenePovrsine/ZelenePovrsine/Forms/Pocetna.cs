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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void ZelenePovrsine_Click(object sender, EventArgs e)
        {
            Form form = new ZelenePovrsine();
            Hide();
            form.ShowDialog();
            Show();
            return;
        }

        private void Radnici_Click(object sender, EventArgs e)
        {
            Form form = new Radnici();
            Hide();
            form.ShowDialog();
            Show();
            return;
        }
    }
}
