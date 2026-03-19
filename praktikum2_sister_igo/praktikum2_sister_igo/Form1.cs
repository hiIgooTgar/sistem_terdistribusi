using System.Net;
using System.Net.Sockets;
using System.IO;

namespace praktikum2_sister_igo
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader STR;
        private StreamWriter STW;
        public string receive;
        public string textSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    inputIPC.Text = address.ToString();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(inputPortS.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STW = new StreamWriter(client.GetStream());
            STR = new StreamReader(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(inputIPC.Text), int.Parse(inputPortC.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    inputChat.AppendText("Connected to Server" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (outputMessage.Text != "")
            {
                textSend = outputMessage.Text;
                backgroundWorker2.RunWorkerAsync();
                outputMessage.Text = "";
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.inputChat.Invoke(new MethodInvoker(delegate ()
                    {
                        inputChat.AppendText("Anda : " + receive + "\n");
                    }));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(textSend);
                this.inputChat.Invoke(new MethodInvoker(delegate ()
                {
                    inputChat.AppendText("Saya : " + textSend + "\n");
                }));
            } else
            {
                MessageBox.Show("Send Failed!");
            }

            backgroundWorker2.CancelAsync();
        }
    }
}
