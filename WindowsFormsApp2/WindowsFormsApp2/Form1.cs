using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == "muz" ||
                listBox1.Items[i].ToString() == "çilek" ||
                listBox1.Items[i].ToString() == "elma") 
                {
                 listBox2.Items.Add(listBox1.Items[i]);
                }
                else
                {
                 listBox3.Items.Add(listBox1.Items[i]);
                }
            }

            
        }


    }
}
