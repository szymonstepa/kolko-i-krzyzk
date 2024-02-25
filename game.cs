using kolko.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko
{
    public partial class game : Form
    {

        public string PlayerNick1 { get; set; }
        public string PlayerNick2 { get; set; }

        public string PicPath1 { get; set; }
        public string PicPath2 { get; set; }
        public int Rounds { get; set; }
        public int Time { get; set; }

        char currMove = 'O';

        bool isGame = true;

        char c = 'A';

        int currNumOfRounds = 0;
        int currXWins = 0;
        int currOWins = 0;

        int seconds;
        SoundPlayer sp = new SoundPlayer();

        public game()
        {
            InitializeComponent();
        }

        Bitmap image_x = Resources.x;
        Bitmap image_o = Resources.o;

        private void game_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PlayerNick1.ToString()))
                labelNick1.Text = PlayerNick1;
            else
                PlayerNick1 = "Gracz 1";
            if (!string.IsNullOrEmpty(PlayerNick2.ToString()))
                labelNick2.Text = PlayerNick2;
            else
                PlayerNick2 = "Gracz 2";

            pictureBoxPlayer1.Image = Image.FromFile(PicPath1);
            pictureBoxPlayer2.Image = Image.FromFile(PicPath2);

            labelMove.Text = "Tura: " + PlayerNick1;

            labelBO.Text += Rounds;

            pictureBox00.Image = null;
            pictureBox01.Image = null;
            pictureBox02.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;

            seconds = Time / 1000;

            if (Time != 0)
            {
                timerUpdateLabel.Interval = 1000;
                timerTura.Interval = Time + 2000;
                timerTura.Start();
                timerUpdateLabel.Start();

            }
            else
                timerTura.Enabled = false;
            playMusic();

        }
        private void playMusic()
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            sp.SoundLocation = projectDirectory + "/Music/game.wav";
            sp.PlayLooping();

        }
        void reset()
        {
            if ((float)Rounds / 2 < currOWins)
            {
                MessageBox.Show("Wygrana O!\nGratulacje " + PlayerNick1);
                timerTura.Enabled = false;
                timerUpdateLabel.Enabled = false;
            }
            else if ((float)Rounds / 2 < currXWins)
            {
                MessageBox.Show("Wygrana X!\nGratulacje " + PlayerNick2);
                timerTura.Enabled = false;
                timerUpdateLabel.Enabled = false;
            }
            else
            {
                if (Time != 0)
                    timer_reset();
                pictureBox00.Image = null;
                pictureBox01.Image = null;
                pictureBox02.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox20.Image = null;
                pictureBox21.Image = null;
                pictureBox22.Image = null;
                isGame = true;
                c = 'A';

            }

        }

        char check_win()
        {

            //HORYZONTALNIE
            if (pictureBox00.Image == image_x && pictureBox01.Image == image_x && pictureBox02.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox10.Image == image_x && pictureBox11.Image == image_x && pictureBox12.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox20.Image == image_x && pictureBox21.Image == image_x && pictureBox22.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox00.Image == image_o && pictureBox01.Image == image_o && pictureBox02.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox10.Image == image_o && pictureBox11.Image == image_o && pictureBox12.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox20.Image == image_o && pictureBox21.Image == image_o && pictureBox22.Image == image_o)
            {
                return 'O';
            }
            //WERTYKLANIE
            else if (pictureBox00.Image == image_x && pictureBox10.Image == image_x && pictureBox20.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox01.Image == image_x && pictureBox11.Image == image_x && pictureBox21.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox02.Image == image_x && pictureBox12.Image == image_x && pictureBox22.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox00.Image == image_o && pictureBox10.Image == image_o && pictureBox20.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox01.Image == image_o && pictureBox11.Image == image_o && pictureBox21.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox02.Image == image_o && pictureBox12.Image == image_o && pictureBox22.Image == image_o)
            {
                return 'O';
            }
            //DIAGONALNIE
            else if (pictureBox00.Image == image_x && pictureBox11.Image == image_x && pictureBox22.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox02.Image == image_x && pictureBox11.Image == image_x && pictureBox20.Image == image_x)
            {
                return 'X';
            }
            else if (pictureBox00.Image == image_o && pictureBox11.Image == image_o && pictureBox22.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox02.Image == image_o && pictureBox11.Image == image_o && pictureBox20.Image == image_o)
            {
                return 'O';
            }
            else if (pictureBox00.Image != null && pictureBox01.Image != null && pictureBox02.Image != null &&
                    pictureBox10.Image != null && pictureBox11.Image != null && pictureBox12.Image != null &&
                    pictureBox20.Image != null && pictureBox21.Image != null && pictureBox22.Image != null)
            {
                return 'R';
            }

            return 'B';

        }

        void timer_reset()
        {
            timerTura.Stop();
            timerUpdateLabel.Stop();
            timerUpdateLabel.Interval = 1000;
            timerTura.Interval = Time + 2000;
            seconds = Time / 1000;
            timerTura.Start();
            timerUpdateLabel.Start();
        }

        private void pictureBox00_Click(object sender, EventArgs e)
        {
            if (Time != 0)
                timer_reset();
            if (pictureBox00.Image != image_x && pictureBox00.Image != image_o && isGame == true)
            {

                if (currMove == 'X')
                {
                    pictureBox00.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;

                }
                else if (currMove == 'O')
                {
                    pictureBox00.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }


        }

        private void pictureBox01_Click(object sender, EventArgs e)
        {
            if (pictureBox01.Image != image_x && pictureBox01.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox01.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox01.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox02_Click(object sender, EventArgs e)
        {
            if (pictureBox02.Image != image_x && pictureBox02.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox02.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox02.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();
                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image != image_x && pictureBox10.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox10.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox10.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }


            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image != image_x && pictureBox11.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox11.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox11.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != image_x && pictureBox12.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox12.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox12.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image != image_x && pictureBox20.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox20.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox20.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + " Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (pictureBox21.Image != image_x && pictureBox21.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox21.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox21.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + "  Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (pictureBox22.Image != image_x && pictureBox22.Image != image_o && isGame == true)
            {
                if (Time != 0)
                    timer_reset();
                if (currMove == 'X')
                {
                    pictureBox22.Image = image_x;
                    currMove = 'O';
                    labelMove.Text = "Tura: " + PlayerNick1;
                }
                else if (currMove == 'O')
                {
                    pictureBox22.Image = image_o;
                    currMove = 'X';
                    labelMove.Text = "Tura: " + PlayerNick2;
                }
                c = check_win();

                if (c == 'X' || c == 'O')
                {
                    if (c == 'X')
                        currXWins++;
                    if (c == 'O')
                        currOWins++;

                    labelWygraneGracz1.Text = "Wygrane: " + currOWins;
                    labelWygraneGracz2.Text = "Wygrane: " + currXWins;

                    MessageBox.Show(c.ToString() + "  Wygrał");
                    isGame = false;
                    reset();
                }
                else if (c == 'R')
                {
                    MessageBox.Show("REMIS");
                    reset();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();

            foreach (Form form in Application.OpenForms)
            {
                if (form is main) 
                {
                    form.Show();
                    break;
                }
            }

            this.Hide();

        }

        private void timerTura_Tick(object sender, EventArgs e)
        {

            timer_reset();
            if (currMove == 'X')
            {
                currMove = 'O';
                labelMove.Text = "Tura: " + PlayerNick1;
            }
            else if (currMove == 'O')
            {
                currMove = 'X';
                labelMove.Text = "Tura: " + PlayerNick2;
            }
        }

        private void timerUpdateLabel_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Czas: " + seconds--;
        }
    }
}
