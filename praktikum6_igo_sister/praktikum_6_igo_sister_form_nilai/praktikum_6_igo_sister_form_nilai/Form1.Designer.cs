namespace praktikum_6_igo_sister_form_nilai
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKonversi = new System.Windows.Forms.Button();
            this.outputPredikat = new System.Windows.Forms.TextBox();
            this.inputNilai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKonversi
            // 
            this.btnKonversi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKonversi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKonversi.Location = new System.Drawing.Point(53, 195);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(248, 29);
            this.btnKonversi.TabIndex = 9;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = false;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // outputPredikat
            // 
            this.outputPredikat.Location = new System.Drawing.Point(53, 300);
            this.outputPredikat.Multiline = true;
            this.outputPredikat.Name = "outputPredikat";
            this.outputPredikat.Size = new System.Drawing.Size(248, 26);
            this.outputPredikat.TabIndex = 8;
            // 
            // inputNilai
            // 
            this.inputNilai.Location = new System.Drawing.Point(53, 150);
            this.inputNilai.Multiline = true;
            this.inputNilai.Name = "inputNilai";
            this.inputNilai.Size = new System.Drawing.Size(248, 26);
            this.inputNilai.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predikat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nilai Angka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.outputPredikat);
            this.Controls.Add(this.inputNilai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.TextBox outputPredikat;
        private System.Windows.Forms.TextBox inputNilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

