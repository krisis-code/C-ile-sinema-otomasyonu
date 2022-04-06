using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyon_krisis
{
    public partial class Seans_Ekle : Form
    {
        public Seans_Ekle()
        {
            InitializeComponent();
        }

        private void Seans_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void Ekle_Btn_Se_Click(object sender, EventArgs e)
        {

        }

        private void Seans_Ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa ekle = new AnaSayfa();
            ekle.Show();
        }
    }
}
