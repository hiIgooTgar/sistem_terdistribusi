namespace praktikum_3_igo_sister_form_application
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            ScoreP1 = new Label();
            ScoreP3 = new Label();
            label4 = new Label();
            ScoreP2 = new Label();
            btnPlay = new Button();
            groupBox1 = new GroupBox();
            motor3 = new Button();
            motor2 = new Button();
            motor1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(210, 413);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Player 1:";
            // 
            // ScoreP1
            // 
            ScoreP1.AutoSize = true;
            ScoreP1.ForeColor = SystemColors.ControlLightLight;
            ScoreP1.Location = new Point(260, 413);
            ScoreP1.Name = "ScoreP1";
            ScoreP1.Size = new Size(13, 15);
            ScoreP1.TabIndex = 8;
            ScoreP1.Text = "0";
            // 
            // ScoreP3
            // 
            ScoreP3.AutoSize = true;
            ScoreP3.ForeColor = SystemColors.ControlLightLight;
            ScoreP3.Location = new Point(652, 413);
            ScoreP3.Name = "ScoreP3";
            ScoreP3.Size = new Size(13, 15);
            ScoreP3.TabIndex = 10;
            ScoreP3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(602, 413);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Player 3:";
            // 
            // ScoreP2
            // 
            ScoreP2.AutoSize = true;
            ScoreP2.ForeColor = SystemColors.ControlLightLight;
            ScoreP2.Location = new Point(463, 413);
            ScoreP2.Name = "ScoreP2";
            ScoreP2.Size = new Size(13, 15);
            ScoreP2.TabIndex = 12;
            ScoreP2.Text = "0";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(44, 409);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(99, 23);
            btnPlay.TabIndex = 13;
            btnPlay.Text = "Play Game";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(motor3);
            groupBox1.Controls.Add(motor2);
            groupBox1.Controls.Add(motor1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(44, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 359);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // motor3
            // 
            motor3.Image = (Image)resources.GetObject("motor3.Image");
            motor3.Location = new Point(15, 263);
            motor3.Name = "motor3";
            motor3.Size = new Size(75, 73);
            motor3.TabIndex = 3;
            motor3.UseVisualStyleBackColor = true;
            // 
            // motor2
            // 
            motor2.Image = (Image)resources.GetObject("motor2.Image");
            motor2.Location = new Point(15, 138);
            motor2.Name = "motor2";
            motor2.Size = new Size(75, 73);
            motor2.TabIndex = 2;
            motor2.UseVisualStyleBackColor = true;
            // 
            // motor1
            // 
            motor1.Image = (Image)resources.GetObject("motor1.Image");
            motor1.Location = new Point(15, 22);
            motor1.Name = "motor1";
            motor1.Size = new Size(75, 73);
            motor1.TabIndex = 0;
            motor1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(416, 413);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 15;
            label2.Text = "Player 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnPlay);
            Controls.Add(ScoreP2);
            Controls.Add(ScoreP3);
            Controls.Add(label4);
            Controls.Add(ScoreP1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Racing With Thread";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ScoreP1;
        private Label ScoreP3;
        private Label label4;
        private Label ScoreP2;
        private Button btnPlay;
        private GroupBox groupBox1;
        private Button motor1;
        private Button motor2;
        private System.Windows.Forms.Timer timer1;
        private Button motor3;
        private Label label2;
    }
}
