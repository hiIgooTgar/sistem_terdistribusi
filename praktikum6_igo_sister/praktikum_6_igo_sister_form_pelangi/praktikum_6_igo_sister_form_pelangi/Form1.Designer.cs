namespace praktikum_6_igo_sister_form_pelangi
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
            this.btnProses = new System.Windows.Forms.Button();
            this.outputWarna = new System.Windows.Forms.TextBox();
            this.inputNilai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProses.Location = new System.Drawing.Point(49, 167);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(248, 29);
            this.btnProses.TabIndex = 14;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // outputWarna
            // 
            this.outputWarna.Location = new System.Drawing.Point(49, 272);
            this.outputWarna.Multiline = true;
            this.outputWarna.Name = "outputWarna";
            this.outputWarna.Size = new System.Drawing.Size(248, 26);
            this.outputWarna.TabIndex = 13;
            // 
            // inputNilai
            // 
            this.inputNilai.Location = new System.Drawing.Point(49, 122);
            this.inputNilai.Multiline = true;
            this.inputNilai.Name = "inputNilai";
            this.inputNilai.Size = new System.Drawing.Size(248, 26);
            this.inputNilai.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Warna Pelangi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nomor Urut";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 394);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.outputWarna);
            this.Controls.Add(this.inputNilai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pelangi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox outputWarna;
        private System.Windows.Forms.TextBox inputNilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

