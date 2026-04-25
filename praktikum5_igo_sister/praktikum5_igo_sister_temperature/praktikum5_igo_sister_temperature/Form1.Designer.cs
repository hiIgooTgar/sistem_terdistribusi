namespace praktikum5_igo_sister_temperature
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
            inputCelcius = new TextBox();
            label2 = new Label();
            inputReamur = new TextBox();
            label3 = new Label();
            inputFahrenreit = new TextBox();
            label4 = new Label();
            inputKelvin = new TextBox();
            label5 = new Label();
            btnKonversi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(50, 74);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "Suhu Celcius";
            // 
            // inputCelcius
            // 
            inputCelcius.BorderStyle = BorderStyle.FixedSingle;
            inputCelcius.Location = new Point(50, 99);
            inputCelcius.Multiline = true;
            inputCelcius.Name = "inputCelcius";
            inputCelcius.Size = new Size(379, 33);
            inputCelcius.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 27);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Konversi Suhu";
            // 
            // inputReamur
            // 
            inputReamur.BorderStyle = BorderStyle.FixedSingle;
            inputReamur.Location = new Point(50, 249);
            inputReamur.Multiline = true;
            inputReamur.Name = "inputReamur";
            inputReamur.Size = new Size(379, 33);
            inputReamur.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(50, 224);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 3;
            label3.Text = "Suhu Reamur";
            // 
            // inputFahrenreit
            // 
            inputFahrenreit.BorderStyle = BorderStyle.FixedSingle;
            inputFahrenreit.Location = new Point(50, 321);
            inputFahrenreit.Multiline = true;
            inputFahrenreit.Name = "inputFahrenreit";
            inputFahrenreit.Size = new Size(379, 33);
            inputFahrenreit.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(50, 296);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 5;
            label4.Text = "Suhu Fahrenreit";
            // 
            // inputKelvin
            // 
            inputKelvin.BorderStyle = BorderStyle.FixedSingle;
            inputKelvin.Location = new Point(50, 394);
            inputKelvin.Multiline = true;
            inputKelvin.Name = "inputKelvin";
            inputKelvin.Size = new Size(379, 33);
            inputKelvin.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(50, 369);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 7;
            label5.Text = "Suhu Kelvin";
            // 
            // btnKonversi
            // 
            btnKonversi.BackColor = SystemColors.Highlight;
            btnKonversi.FlatAppearance.BorderSize = 0;
            btnKonversi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonversi.ForeColor = SystemColors.Control;
            btnKonversi.Location = new Point(50, 147);
            btnKonversi.Name = "btnKonversi";
            btnKonversi.Size = new Size(379, 38);
            btnKonversi.TabIndex = 9;
            btnKonversi.Text = "Konversi ";
            btnKonversi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 472);
            Controls.Add(btnKonversi);
            Controls.Add(inputKelvin);
            Controls.Add(label5);
            Controls.Add(inputFahrenreit);
            Controls.Add(label4);
            Controls.Add(inputReamur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputCelcius);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Konversi Suhu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputCelcius;
        private Label label2;
        private TextBox inputReamur;
        private Label label3;
        private TextBox inputFahrenreit;
        private Label label4;
        private TextBox inputKelvin;
        private Label label5;
        private Button btnKonversi;
    }
}
