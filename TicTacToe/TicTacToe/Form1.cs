using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int player1Score = 0;
        public int player2Score = 0;
        public int buttonsPressed = 0;
        public Boolean player1turn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();


        }

        private void timer_tick(object sender, EventArgs e)
        {

            if (player1turn)
            {
                playersturnlabel.Text = "Player1";
            }
            else
            {
                playersturnlabel.Text = "Player2";
            }

            if(buttonsPressed == 9)
            {
                Reset();
            }

        }

        private void UpdatePlayer1Score()
        {
            player1Score++;
            player1scorebox.Text = player1Score.ToString();
        }

        private void UpdatePlayer2Score()
        {
            player2Score++;
            player1scorebox.Text = player2Score.ToString();
        }

        private void WinCheck()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Draw(button1);

            player1turn = !player1turn;
            buttonsPressed++;
            button1.Click -= this.button1_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw(button2);

            player1turn = !player1turn;
            buttonsPressed++;
            button2.Click -= this.button2_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Draw(button3);

            player1turn = !player1turn;
            buttonsPressed++;
            button3.Click -= this.button3_Click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Draw(button4);

            player1turn = !player1turn;
            buttonsPressed++;
            button4.Click -= this.button4_Click;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Draw(button5);

            player1turn = !player1turn;
            buttonsPressed++;
            button5.Click -= this.button5_Click;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Draw(button6);

            player1turn = !player1turn;
            buttonsPressed++;
            button6.Click -= this.button6_Click;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Draw(button7);

            player1turn = !player1turn;
            buttonsPressed++;
            button7.Click -= this.button7_Click;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Draw(button8);

            player1turn = !player1turn;
            buttonsPressed++;
            button8.Click -= this.button8_Click;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Draw(button9);

            player1turn = !player1turn;
            buttonsPressed++;
            button9.Click -= this.button9_Click;
        }

        private void Reset()
        {
            button1.Image = null;
            button1.Click += this.button1_Click;
            button2.Image = null;
            button2.Click += this.button2_Click;
            button3.Image = null;
            button3.Click += this.button3_Click;
            button4.Image = null;
            button4.Click += this.button4_Click;
            button5.Image = null;
            button5.Click += this.button5_Click;
            button6.Image = null;
            button6.Click += this.button6_Click;
            button7.Image = null;
            button7.Click += this.button7_Click;
            button8.Image = null;
            button8.Click += this.button8_Click;
            button9.Image = null;
            button9.Click += this.button9_Click;
            buttonsPressed = 0;
        }

        private void Draw(Button btn)
        {
            if (player1turn)
            {
                btn.Image = Image.FromFile("C:/Users/Owner/Desktop/C#Practice/TicTacToe (Visual Studio Windows Forms)/TicTacToe/Ximage.png");
            }
            else
            {
                btn.Image = Image.FromFile("C:/Users/Owner/Desktop/C#Practice/TicTacToe (Visual Studio Windows Forms)/TicTacToe/Oimage.png");
            }
        }
    }

}
