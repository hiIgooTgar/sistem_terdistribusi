using System.IO;

namespace sister_prak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            aktikanTextbox(true);
            totalRecord();
        }

        const int kapasistasAwal = 50;
        string[] arrCustomer = new string[kapasistasAwal];
        int jmlMax = kapasistasAwal;
        int idx = -1;
        int jmlCustomer = 0;
        char pemisah = ',';

        private void pisahDataCustomer(string customer)
        {
            char[] pisah = { pemisah };
            string[] dataCustomer = customer.Split(pisah);
            id_customer.Text = dataCustomer[0];
            name_customer.Text = dataCustomer[1];
            address_customer.Text = dataCustomer[2];
        }

        private void aktikanTextbox(bool sifatKeaktifan)
        {
            id_customer.Enabled = sifatKeaktifan;
            name_customer.Enabled = sifatKeaktifan;
            address_customer.Enabled = sifatKeaktifan;
        }

        private void bersih()
        {
            id_customer.Clear();
            name_customer.Clear();
            address_customer.Clear();
        }

        private void totalRecord()
        {
            recordCount.Text = "Total Record = " + jmlCustomer.ToString();
        }

        private void updateDataArray()
        {
            if (jmlCustomer > 0)
            {
                string customer = "";
                customer = customer + id_customer.Text + pemisah;
                customer = customer + name_customer.Text + pemisah;
                customer = customer + address_customer.Text;

                arrCustomer[idx] = customer;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult pilih = dlgOpen.ShowDialog();
            if (pilih == DialogResult.OK)
            {
                arrCustomer = File.ReadAllLines(dlgOpen.FileName);
                jmlCustomer = arrCustomer.Length;
                idx = 0;

                jmlMax = jmlCustomer * 2;
                Array.Resize(ref arrCustomer, jmlMax);

                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                aktikanTextbox(true);
                totalRecord();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateDataArray();
            DialogResult pilih = dlgSave.ShowDialog();
            if (pilih == DialogResult.OK)
            {
                string[] arrBantuan = new string[jmlCustomer];
                Array.Copy(arrCustomer, arrBantuan, jmlCustomer);
                File.WriteAllLines(dlgSave.FileName, arrBantuan);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx = 0;
                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx = jmlCustomer - 1;
                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx--;
                if (idx < 0)
                {
                    idx = 0;
                }

                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx++;
                if (idx >= jmlCustomer)
                {
                    idx = jmlCustomer - 1;
                }

                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            aktikanTextbox(true);
            updateDataArray();
            if (jmlCustomer == jmlMax)
            {
                jmlMax *= 2;
                Array.Resize(ref arrCustomer, jmlMax);
            }

            bersih();
            id_customer.Focus();
            idx = jmlCustomer;
            jmlCustomer++;
            totalRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                if (idx == jmlCustomer - 1)
                {
                    idx--;
                }
                else
                {
                    for (int i = idx; i < jmlCustomer; i++)
                    {
                        arrCustomer[i] = arrCustomer[i + 1];
                    }
                }
                jmlCustomer--;

                if (jmlCustomer > 0)
                {
                    string customer = arrCustomer[idx];
                    pisahDataCustomer(customer);
                }
                else
                {
                    bersih();
                    aktikanTextbox(false);
                }
                totalRecord();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id_customer.Text = "";
            name_customer.Text = "";
            address_customer.Text = "";
        }
    }
}
