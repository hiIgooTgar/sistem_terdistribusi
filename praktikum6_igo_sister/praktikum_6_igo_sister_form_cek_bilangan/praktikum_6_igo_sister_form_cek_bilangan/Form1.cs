using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_6_igo_sister_form_cek_bilangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string cekBilangan(int bilangan)
        {
            if (bilangan % 2 == 0)
            {
                return "Bilangan Genap";
            }
            else
            {
                return "Bilangan Ganjil";
            }
        }

        private void btnBilangan_Click(object sender, EventArgs e)
        {

            try
            {
                int inputAngka = int.Parse(inputNilai.Text);
                string hasilCekBilangan = cekBilangan(inputAngka);
                outputBilangan.Text = hasilCekBilangan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
