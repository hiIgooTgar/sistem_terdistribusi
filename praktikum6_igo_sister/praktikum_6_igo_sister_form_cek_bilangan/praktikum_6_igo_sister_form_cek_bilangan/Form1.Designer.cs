namespace praktikum_6_igo_sister_form_cek_bilangan
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
            this.btnBilangan = new System.Windows.Forms.Button();
            this.outputBilangan = new System.Windows.Forms.TextBox();
            this.inputNilai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilangan
            // 
            this.btnBilangan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBilangan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBilangan.Location = new System.Drawing.Point(60, 167);
            this.btnBilangan.Name = "btnBilangan";
            this.btnBilangan.Size = new System.Drawing.Size(248, 29);
            this.btnBilangan.TabIndex = 19;
            this.btnBilangan.Text = "Proses";
            this.btnBilangan.UseVisualStyleBackColor = false;
            this.btnBilangan.Click += new System.EventHandler(this.btnBilangan_Click);
            // 
            // outputBilangan
            // 
            this.outputBilangan.Location = new System.Drawing.Point(60, 272);
            this.outputBilangan.Multiline = true;
            this.outputBilangan.Name = "outputBilangan";
            this.outputBilangan.Size = new System.Drawing.Size(248, 26);
            this.outputBilangan.TabIndex = 18;
            // 
            // inputNilai
            // 
            this.inputNilai.Location = new System.Drawing.Point(60, 122);
            this.inputNilai.Multiline = true;
            this.inputNilai.Name = "inputNilai";
            this.inputNilai.Size = new System.Drawing.Size(248, 26);
            this.inputNilai.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Output Bilangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nilai Angka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.btnBilangan);
            this.Controls.Add(this.outputBilangan);
            this.Controls.Add(this.inputNilai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Cek Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilangan;
        private System.Windows.Forms.TextBox outputBilangan;
        private System.Windows.Forms.TextBox inputNilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

