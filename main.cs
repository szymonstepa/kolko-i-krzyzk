using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolko.Properties;

namespace kolko
{
    public partial class main : Form
    {

        int countPlayer1 = 1;
        int countPlayer2 = 1;

        string picPathPlayer1;
        string picPathPlayer2;


        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            picPathPlayer1 = projectDirectory + "/Pictures/pic1.jpg";
            picPathPlayer2 = projectDirectory + "/Pictures/pic1.jpg";


        }

        private void playMusic()
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;



            SoundPlayer sp = new SoundPlayer(projectDirectory + "/Music/menu.wav");
            sp.PlayLooping();


        }


        private void buttonPoprzedni1_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            if (countPlayer1 != 1)
            {
                countPlayer1--;
                picPathPlayer1 = projectDirectory + "/Pictures/pic" + countPlayer1.ToString() + ".jpg";
                pictureBoxPlayer1.Image = Image.FromFile(picPathPlayer1);

            }

        }

        private void buttonNastepny1_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            if (countPlayer1 != 4)
            {
                countPlayer1++;
                picPathPlayer1 = projectDirectory + "/Pictures/pic" + countPlayer1.ToString() + ".jpg";
                pictureBoxPlayer1.Image = Image.FromFile(picPathPlayer1);

            }
        }

        private void buttonPoprzedni2_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            if (countPlayer2 != 1)
            {
                countPlayer2--;
                picPathPlayer2 = projectDirectory + "/Pictures/pic" + countPlayer2.ToString() + ".jpg";
                pictureBoxPlayer2.Image = Image.FromFile(picPathPlayer2);

            }
        }

        private void buttonNastepny2_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            if (countPlayer2 != 4)
            {
                countPlayer2++;
                picPathPlayer2 = projectDirectory + "/Pictures/pic" + countPlayer2.ToString() + ".jpg";
                pictureBoxPlayer2.Image = Image.FromFile(picPathPlayer2);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            game g = new game();

            g.PlayerNick1 = textBoxNick1.Text.ToString();
            g.PlayerNick2 = textBoxNick2.Text.ToString();

            g.PicPath1 = picPathPlayer1;
            g.PicPath2 = picPathPlayer2;

            if (radioButtonRunda1.Checked)
                g.Rounds = 1;
            if (radioButtonRunda3.Checked)
                g.Rounds = 3;
            if (radioButtonRunda5.Checked)
                g.Rounds = 5;
            if (radioButtonRunda7.Checked)
                g.Rounds = 7;

            if (radioButtonCzas10.Checked)
                g.Time = 10000;
            if (radioButtonCzas30.Checked)
                g.Time = 30000;
            if (radioButtonCzas60.Checked)
                g.Time = 60000;
            if (radioButtonCzasNL.Checked)
                g.Time = 0;

            g.Show();

            this.Hide();
        }

        private void main_Load_1(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            picPathPlayer1 = projectDirectory + "/Pictures/pic1.jpg";
            picPathPlayer2 = projectDirectory + "/Pictures/pic1.jpg";
            playMusic();
        }

        private void main_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                playMusic();
        }
    }
}
