using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue kuyruk = new Queue();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            kuyruk.Enqueue(Convert.ToInt32(sayi.Text));
            listView.Items.Add(kuyruk.elemanlariYazdir());
        }

        private void brn_sil_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            listView.Items.Add(kuyruk.elemanlariYazdir());
        }
    }
}
