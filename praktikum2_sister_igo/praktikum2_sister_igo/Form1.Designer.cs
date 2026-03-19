namespace praktikum2_sister_igo
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
            groupBox1 = new GroupBox();
            inputIPS = new TextBox();
            inputPortS = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            inputPortC = new TextBox();
            label3 = new Label();
            inputIPC = new TextBox();
            label4 = new Label();
            btnStart = new Button();
            btnConnect = new Button();
            outputMessage = new TextBox();
            inputChat = new TextBox();
            btnSend = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(inputIPS);
            groupBox1.Controls.Add(inputPortS);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server";
            // 
            // inputIPS
            // 
            inputIPS.BackColor = SystemColors.InactiveBorder;
            inputIPS.BorderStyle = BorderStyle.FixedSingle;
            inputIPS.Location = new Point(11, 49);
            inputIPS.Name = "inputIPS";
            inputIPS.Size = new Size(249, 23);
            inputIPS.TabIndex = 5;
            // 
            // inputPortS
            // 
            inputPortS.BackColor = SystemColors.InactiveBorder;
            inputPortS.BorderStyle = BorderStyle.FixedSingle;
            inputPortS.Location = new Point(11, 103);
            inputPortS.Name = "inputPortS";
            inputPortS.Size = new Size(249, 23);
            inputPortS.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 84);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "IP Address";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(inputPortC);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(inputIPC);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(33, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 148);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client";
            // 
            // inputPortC
            // 
            inputPortC.BackColor = SystemColors.InactiveBorder;
            inputPortC.BorderStyle = BorderStyle.FixedSingle;
            inputPortC.Location = new Point(11, 103);
            inputPortC.Name = "inputPortC";
            inputPortC.Size = new Size(249, 23);
            inputPortC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Port";
            // 
            // inputIPC
            // 
            inputIPC.BackColor = SystemColors.InactiveBorder;
            inputIPC.BorderStyle = BorderStyle.FixedSingle;
            inputIPC.Location = new Point(12, 48);
            inputIPC.Name = "inputIPC";
            inputIPC.Size = new Size(249, 23);
            inputIPC.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 29);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "IP Address";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(189, 189);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(119, 30);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start Server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(189, 399);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(119, 30);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // outputMessage
            // 
            outputMessage.Location = new Point(346, 29);
            outputMessage.Multiline = true;
            outputMessage.Name = "outputMessage";
            outputMessage.Size = new Size(414, 310);
            outputMessage.TabIndex = 9;
            // 
            // inputChat
            // 
            inputChat.Location = new Point(346, 356);
            inputChat.Multiline = true;
            inputChat.Name = "inputChat";
            inputChat.Size = new Size(348, 32);
            inputChat.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Green;
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(703, 356);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(57, 32);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(outputMessage);
            Controls.Add(inputChat);
            Controls.Add(btnConnect);
            Controls.Add(btnStart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox inputPortS;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox inputPortC;
        private Label label3;
        private TextBox inputIPC;
        private Label label4;
        private Button btnStart;
        private Button btnConnect;
        private TextBox outputMessage;
        private TextBox inputChat;
        private Button btnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox inputIPS;
    }
}
