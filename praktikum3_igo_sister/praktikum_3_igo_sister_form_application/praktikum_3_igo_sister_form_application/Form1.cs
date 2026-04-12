using System.Threading;
using System.Threading.Tasks;

namespace praktikum_3_igo_sister_form_application
{
    public partial class Form1 : Form
    {
        public bool PlayAgain = false;
        static Random rand;
        static Thread Player1Thd;
        static Thread Player2Thd;
        static Thread Player3Thd;
        public static int countPlayer1;
        public static int countPlayer2;
        public static int countPlayer3;

        public Form1()
        {
            InitializeComponent();
            countPlayer1 = 0;
            countPlayer2 = 0;
            countPlayer3 = 0;
            rand = new Random();
        }

        public static void Player1()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlayer1 > 650)
                {
                    Player1Thd.Abort();
                    break;
                }
                countPlayer1 = countPlayer1 + (1 + rand.Next(6));
            }
        }

        public static void Player2()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlayer2 > 650)
                {
                    Player2Thd.Abort();
                    break;
                }
                countPlayer2 = countPlayer2 + (1 + rand.Next(6));
            }
        }

        public static void Player3()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlayer3 > 650)
                {
                    Player2Thd.Abort();
                    break;
                }
                countPlayer3 = countPlayer3 + (1 + rand.Next(6));
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            countPlayer1 = 0;
            countPlayer2 = 0;
            countPlayer3 = 0;

            Player1Thd = new Thread(new ThreadStart(Player1));
            Player1Thd.IsBackground = true;
            Player1Thd.Start();

            Player2Thd = new Thread(new ThreadStart(Player2));
            Player2Thd.IsBackground = true;
            Player2Thd.Start();

            Player3Thd = new Thread(new ThreadStart(Player3));
            Player3Thd.IsBackground = true;
            Player3Thd.Start();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool check = false;

            if (countPlayer1 > 650)
            {
                timer1.Stop();
                countPlayer1 = 0;
                countPlayer2 = 0;
                countPlayer3 = 0;
                check = true;
                int i = Int32.Parse(ScoreP1.Text);
                i++;
                ScoreP1.Text = i.ToString();
                MessageBox.Show("Player 1 win the race");
            }
            else if (countPlayer2 > 650)
            {
                timer1.Stop();
                countPlayer1 = 0;
                countPlayer2 = 0;
                countPlayer3 = 0;
                check = true;
                int i = Int32.Parse(ScoreP2.Text);
                i++;
                ScoreP2.Text = i.ToString();
                MessageBox.Show("Player 2 win the race");
            }
            else if (countPlayer3 > 650)
            {
                timer1.Stop();
                countPlayer1 = 0;
                countPlayer2 = 0;
                countPlayer3 = 0;
                check = true;
                int i = Int32.Parse(ScoreP3.Text);
                i++;
                ScoreP3.Text = i.ToString();
                MessageBox.Show("Player 3 win the race");
            }

            if (check == false)
            {
                motor1.Left = countPlayer1;
                motor2.Left = countPlayer2;
                motor3.Left = countPlayer3;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
