namespace praktikum4_igo_sister_24sa11a159
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            inputNama = new TextBox();
            label5 = new Label();
            label3 = new Label();
            inputEmail = new TextBox();
            label4 = new Label();
            inputTelepon = new TextBox();
            label6 = new Label();
            inputPenerbit = new TextBox();
            label7 = new Label();
            inputKode = new TextBox();
            label8 = new Label();
            inputJudul = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataBuku = new DataGridView();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnSimpan = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataBuku).BeginInit();
            SuspendLayout();
            // 
            // inputID
            // 
            inputID.BorderStyle = BorderStyle.FixedSingle;
            inputID.Location = new Point(59, 96);
            inputID.Multiline = true;
            inputID.Name = "inputID";
            inputID.Size = new Size(318, 27);
            inputID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "ID Pengarang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 138);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Nama Pengarang";
            // 
            // inputNama
            // 
            inputNama.BorderStyle = BorderStyle.FixedSingle;
            inputNama.Location = new Point(59, 160);
            inputNama.Multiline = true;
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(318, 27);
            inputNama.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 253);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 9;
            label5.Text = "Detail Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 138);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "Email";
            // 
            // inputEmail
            // 
            inputEmail.BorderStyle = BorderStyle.FixedSingle;
            inputEmail.Location = new Point(408, 160);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(318, 27);
            inputEmail.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 72);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 16;
            label4.Text = "Telepon";
            // 
            // inputTelepon
            // 
            inputTelepon.BorderStyle = BorderStyle.FixedSingle;
            inputTelepon.Location = new Point(408, 96);
            inputTelepon.Multiline = true;
            inputTelepon.Name = "inputTelepon";
            inputTelepon.Size = new Size(318, 27);
            inputTelepon.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 350);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 22;
            label6.Text = "Penerbit";
            // 
            // inputPenerbit
            // 
            inputPenerbit.BorderStyle = BorderStyle.FixedSingle;
            inputPenerbit.Location = new Point(408, 372);
            inputPenerbit.Multiline = true;
            inputPenerbit.Name = "inputPenerbit";
            inputPenerbit.Size = new Size(318, 27);
            inputPenerbit.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 350);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 20;
            label7.Text = "Kode Buku";
            // 
            // inputKode
            // 
            inputKode.BorderStyle = BorderStyle.FixedSingle;
            inputKode.Location = new Point(59, 372);
            inputKode.Multiline = true;
            inputKode.Name = "inputKode";
            inputKode.Size = new Size(318, 27);
            inputKode.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 281);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "Judul Buku";
            // 
            // inputJudul
            // 
            inputJudul.BorderStyle = BorderStyle.FixedSingle;
            inputJudul.Location = new Point(59, 305);
            inputJudul.Multiline = true;
            inputJudul.Name = "inputJudul";
            inputJudul.Size = new Size(667, 27);
            inputJudul.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(59, 43);
            label9.Name = "label9";
            label9.Size = new Size(112, 17);
            label9.TabIndex = 25;
            label9.Text = "Detail Pengarang";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Location = new Point(39, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 188);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.CornflowerBlue;
            groupBox2.Location = new Point(39, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(710, 187);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // dataBuku
            // 
            dataBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBuku.Location = new Point(39, 493);
            dataBuku.Name = "dataBuku";
            dataBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataBuku.Size = new Size(710, 169);
            dataBuku.TabIndex = 28;
            dataBuku.MouseClick += dataBuku_MouseClick;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.Highlight;
            btnTambah.ForeColor = SystemColors.ControlLight;
            btnTambah.Location = new Point(39, 437);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(108, 36);
            btnTambah.TabIndex = 29;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.Yellow;
            btnUbah.Location = new Point(166, 437);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(108, 36);
            btnUbah.TabIndex = 30;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = SystemColors.ControlLight;
            btnHapus.Location = new Point(298, 437);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(108, 36);
            btnHapus.TabIndex = 31;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.ForeColor = SystemColors.ControlLight;
            btnSimpan.Location = new Point(39, 668);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(132, 36);
            btnSimpan.TabIndex = 34;
            btnSimpan.Text = "Simpan File XML";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.Green;
            btnImport.ForeColor = SystemColors.ControlLight;
            btnImport.Location = new Point(187, 668);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(132, 36);
            btnImport.TabIndex = 35;
            btnImport.Text = "Import File XML";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(btnImport);
            Controls.Add(btnSimpan);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(dataBuku);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(inputJudul);
            Controls.Add(label6);
            Controls.Add(inputPenerbit);
            Controls.Add(label7);
            Controls.Add(inputKode);
            Controls.Add(label3);
            Controls.Add(inputEmail);
            Controls.Add(label4);
            Controls.Add(inputTelepon);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(inputNama);
            Controls.Add(label1);
            Controls.Add(inputID);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Praktikum 5 - XML";
            ((System.ComponentModel.ISupportInitialize)dataBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputID;
        private Label label1;
        private Label label2;
        private TextBox inputNama;
        private Label label5;
        private Label label3;
        private TextBox inputEmail;
        private Label label4;
        private TextBox inputTelepon;
        private Label label6;
        private TextBox inputPenerbit;
        private Label label7;
        private TextBox inputKode;
        private Label label8;
        private TextBox inputJudul;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataBuku;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnSimpan;
        private Button btnImport;
    }
}
