using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace sinema_otomasyon_krisis
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");

        int sayac = 0;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    btn.Image = Image.FromFile("C:/Users/katii/Desktop/sinema_otomasyon_krisis/sinema_otomasyon_krisis/Resources/pngwing.com.png");
                    if (j == 6)
                    {
                        continue;
                    }
                    if (j == 2)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                }
            }

        }

        private void Seans_Ekle_Btn_Click(object sender, EventArgs e)
        {
            Salon_Ekle ekle = new Salon_Ekle();
            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Seans_Ekle ekle = new Seans_Ekle();
            ekle.Show();
            this.Hide();

        }

        private void Bilet_Satis_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
