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
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();


        }

        private void timer_tick(object sender, EventArgs e)
        {
            UpdatePlayer1Score();

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
            player1scorebox.Text = player1turn.ToString();
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

            player1turn = !player1turn;
            buttonsPressed++;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            player1turn = !player1turn;
            buttonsPressed++;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {


            player1turn = !player1turn;
            buttonsPressed++;
            button9.Enabled = false;
        }

        private void Reset()
        {
            button1.BackgroundImage = null;
            button1.Enabled = true;
            button2.BackgroundImage = null;
            button2.Enabled = true;
            button3.BackgroundImage = null;
            button3.Enabled = true;
            button4.BackgroundImage = null;
            button4.Enabled = true;
            button5.BackgroundImage = null;
            button5.Enabled = true;
            button6.BackgroundImage = null;
            button6.Enabled = true;
            button7.BackgroundImage = null;
            button7.Enabled = true;
            button8.BackgroundImage = null;
            button8.Enabled = true;
            button9.BackgroundImage = null;
            button9.Enabled = true;
            buttonsPressed = 0;
        }
    }

}
