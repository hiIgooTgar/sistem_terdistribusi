using System.Data;

namespace praktikum4_igo_sister_24sa11a159
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (dataBuku.Columns.Count == 0)
            {
                dataBuku.Columns.Add("kode", "Kode");
                dataBuku.Columns.Add("judul", "Judul");
                dataBuku.Columns.Add("penerbit", "Penerbit");
            }

            dataBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataBuku.MultiSelect = false;
        }

        void bersihDataBuku()
        {
            inputKode.Clear();
            inputJudul.Clear();
            inputPenerbit.Clear();
            inputJudul.Focus();
        }

        void bersihDataPengarang()
        {
            inputID.Clear();
            inputNama.Clear();
            inputTelepon.Clear();
            inputEmail.Clear();
            dataBuku.Rows.Clear();
            bersihDataBuku();
            inputID.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int n = dataBuku.Rows.Add();
            dataBuku.Rows[n].Cells[0].Value = inputKode.Text;
            dataBuku.Rows[n].Cells[1].Value = inputJudul.Text;
            dataBuku.Rows[n].Cells[2].Value = inputPenerbit.Text;
            bersihDataBuku();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            dataBuku.SelectedRows[0].Cells[0].Value = inputKode.Text;
            dataBuku.SelectedRows[0].Cells[1].Value = inputJudul.Text;
            dataBuku.SelectedRows[0].Cells[2].Value = inputPenerbit.Text;
            bersihDataBuku();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dataBuku.Rows.RemoveAt(dataBuku.SelectedRows[0].Index);
        }

        private void dataBuku_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataBuku.SelectedRows.Count > 0)
            {
                inputKode.Text = dataBuku.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                inputJudul.Text = dataBuku.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                inputPenerbit.Text = dataBuku.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.TableName = "pengarang";
            dt.Columns.Add("ID");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Telepon");
            dt.Columns.Add("Email");
            ds.Tables.Add(dt);

            DataTable dt1 = new DataTable();
            dt1.TableName = "buku";
            dt1.Columns.Add("Kode");
            dt1.Columns.Add("Judul");
            dt1.Columns.Add("Penerbit");
            ds.Tables.Add(dt1);

            DataRow row = ds.Tables["pengarang"].NewRow();
            row["ID"] = inputID.Text;
            row["Nama"] = inputNama.Text;
            row["Telepon"] = inputTelepon.Text;
            row["Email"] = inputEmail.Text;
            ds.Tables["pengarang"].Rows.Add(row);

            foreach (DataGridViewRow item in dataBuku.Rows)
            {
                if (!item.IsNewRow)
                {
                    DataRow row1 = ds.Tables["buku"].NewRow();
                    row1["Kode"] = item.Cells[0].Value;
                    row1["Judul"] = item.Cells[1].Value;
                    row1["Penerbit"] = item.Cells[2].Value;
                    ds.Tables["buku"].Rows.Add(row1);
                }
            }

            ds.WriteXml("D:\\data_katalog.xml");
            MessageBox.Show("Data Tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersihDataPengarang();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml("D:\\data_katalog.xml");
            inputID.Text = ds.Tables["pengarang"].Rows[0][0].ToString();
            inputNama.Text = ds.Tables["pengarang"].Rows[0][1].ToString();
            inputTelepon.Text = ds.Tables["pengarang"].Rows[0][2].ToString();
            inputEmail.Text = ds.Tables["pengarang"].Rows[0][3].ToString();

            foreach (DataRow item in ds.Tables["buku"].Rows)
            {
                int n = dataBuku.Rows.Add();
                dataBuku.Rows[n].Cells[0].Value = item["Kode"].ToString();
                dataBuku.Rows[n].Cells[1].Value = item["Judul"].ToString();
                dataBuku.Rows[n].Cells[2].Value = item["Penerbit"].ToString();
            }
        }
    }
}
