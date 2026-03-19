namespace sister_prak1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFirst = new Button();
            id_customer = new TextBox();
            name_customer = new TextBox();
            address_customer = new TextBox();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            recordCount = new Label();
            btnExit = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            dlgOpen = new OpenFileDialog();
            dlgSave = new SaveFileDialog();
            panel1 = new Panel();
            btnClear = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(79, 122);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 166);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 208);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Alamat Customer";
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(212, 256);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 23);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // id_customer
            // 
            id_customer.Location = new Point(212, 119);
            id_customer.Name = "id_customer";
            id_customer.Size = new Size(260, 23);
            id_customer.TabIndex = 4;
            // 
            // name_customer
            // 
            name_customer.Location = new Point(212, 163);
            name_customer.Name = "name_customer";
            name_customer.Size = new Size(260, 23);
            name_customer.TabIndex = 5;
            // 
            // address_customer
            // 
            address_customer.Location = new Point(212, 205);
            address_customer.Name = "address_customer";
            address_customer.Size = new Size(260, 23);
            address_customer.TabIndex = 6;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(305, 256);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 7;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(397, 256);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(212, 294);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 23);
            btnLast.TabIndex = 9;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(305, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(397, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // recordCount
            // 
            recordCount.AutoSize = true;
            recordCount.Location = new Point(511, 119);
            recordCount.Name = "recordCount";
            recordCount.Size = new Size(86, 15);
            recordCount.TabIndex = 12;
            recordCount.Text = "Total Record = ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(674, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(582, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(192, 192, 0);
            btnOpen.Location = new Point(484, 384);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 33);
            btnOpen.TabIndex = 17;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // dlgOpen
            // 
            dlgOpen.FileName = "openFileDialog1";
            // 
            // dlgSave
            // 
            dlgSave.DefaultExt = "txt";
            dlgSave.FileName = "data_customer";
            dlgSave.Filter = "All files (*.*)|*.*";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(54, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 342);
            panel1.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(457, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(181, 23);
            label4.Name = "label4";
            label4.Size = new Size(362, 30);
            label4.TabIndex = 0;
            label4.Text = "Sistem Terdistribusi - Data Customer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpen);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(recordCount);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(address_customer);
            Controls.Add(name_customer);
            Controls.Add(id_customer);
            Controls.Add(btnFirst);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFirst;
        private TextBox id_customer;
        private TextBox name_customer;
        private TextBox address_customer;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Button btnAdd;
        private Button btnDelete;
        private Label recordCount;
        private Button btnExit;
        private Button btnSave;
        private Button btnOpen;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private Panel panel1;
        private Label label4;
        private Button btnClear;
    }
}
