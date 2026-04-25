using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_6_igo_sister_form_pelangi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string pelangi(int angka)
        {
            if (angka == 1)
            {
                return "Merah";
            }
            else if (angka == 2)
            {
                return "Jingga";
            }
            else if (angka == 3)
            {
                return "Kuning";
            }
            else if (angka == 4)
            {
                return "Hijau";
            }
            else if (angka == 5)
            {
                return "Biru";
            }
            else if (angka == 6)
            {
                return "Nila";
            }
            else if (angka == 7)
            {
                return "Ungu";
            }
            else
            {
                return "Nomor antara 1 - 7";
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            try
            {
                int inputAngka = int.Parse(inputNilai.Text);
                string hasilWarna = pelangi(inputAngka);
                outputWarna.Text = hasilWarna;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
