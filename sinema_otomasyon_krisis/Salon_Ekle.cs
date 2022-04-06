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
    public partial class Salon_Ekle : Form
    {
        public Salon_Ekle()
        {
            InitializeComponent();
        }

        private void Geri_Btn_Sae_Click(object sender, EventArgs e)
        {
      
        }

        private void Geri_Btn_Sae_Click_1(object sender, EventArgs e)
        {
          AnaSayfa ekle = new AnaSayfa();
            ekle.Show();
            this.Hide();
        }

        private void Salon_Ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa ekle=new AnaSayfa();
            ekle.Show();
        }

        private void Salon_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
