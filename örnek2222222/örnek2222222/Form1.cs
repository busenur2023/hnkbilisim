using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek2222222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam=0, sayi1 ,sayi2;
            sayi1=Convert.ToInt32(txtsSayı1.Text);
            sayi2=Convert.ToInt32(txtSayı2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;
            }
            label3.Text=toplam.ToString();

            
        }   
    }
}
