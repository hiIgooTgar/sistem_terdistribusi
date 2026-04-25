using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_6_igo_sister_form_nilai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string nilai(int angka)
        {
            if (angka >= 80 && angka <= 100)
            {
                return "Excelent";
            }
            else if (angka >= 70)
            {
                return "Good Job";
            }
            else if (angka >= 60)
            {
                return "Not Bad";
            }
            else
            {
                return "Remidial";
            }
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                int inputAngka = int.Parse(inputNilai.Text);
                string hasilPredikat = nilai(inputAngka);
                outputPredikat.Text = hasilPredikat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
