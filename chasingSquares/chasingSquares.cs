using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace chasingSquares
{
    public partial class Form1 : Form
    {

        Rectangle player1 = new Rectangle(50, 50, 30, 30);
        Rectangle player2 = new Rectangle(420, 420, 30, 30);
        Rectangle point = new Rectangle(240, 300, 10, 10);
        Rectangle speed = new Rectangle(240, 200, 10, 10);
        Rectangle timeSlow = new Rectangle(240, 250, 10, 10);

        double player1Score = 0;
        double player2Score = 0;

        int player1Speed = 5;
        int player2Speed = 5;

        int p1Counter;
        int p2Counter;

        int timeSlowP1 = 0;
        int timeSlowP2 = 0;
        int timeSlowCount = 0;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool eDown = false;
        bool lDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush purplBrush = new SolidBrush(Color.Purple);

        SoundPlayer woosh = new SoundPlayer(Properties.Resources.woosh);
        SoundPlayer ding = new SoundPlayer(Properties.Resources.ding);
        SoundPlayer timeSlowUse = new SoundPlayer(Properties.Resources.timeSlowUse);
        SoundPlayer collect = new SoundPlayer(Properties.Resources.pointCollection);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.E:
                    eDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.L:
                    lDown = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.E:
                    eDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.L:
                    lDown = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, point);
            e.Graphics.FillRectangle(yellowBrush, speed);
            e.Graphics.FillRectangle(purplBrush, timeSlow);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeSlowCount++;
            if(timeSlowCount == 500)
            {
                Random rand = new Random();

                timeSlow.X = rand.Next(30, 470);
                timeSlow.Y = rand.Next(30, 470);
                timeSlowCount = 0;
            }
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
                
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            if (eDown == true && timeSlowP1 >= 0)
            {
                player2Speed = 0;

                timeSlowP1 = 0;
                tSLabel1.Text = $"Time Slow Count P1 = {timeSlowP1}";
                timeSlowUse.Play();

            }

            if (player2Speed == 0)
            {
               
                p2Counter++;
                if(p2Counter == 100)
                {
                    player2Speed = 5;
                    p2Counter = 0;
                }
            }


            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
                
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
                
            }

            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
               
            }

            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
                
            }
            if (lDown == true && timeSlowP2 >= 0)
            {
                player1Speed = 0;

                timeSlowP2 = 0;
                tSLabel2.Text = $"Time Slow Count P2 = {timeSlowP2}";
                timeSlowUse.Play();
            }
            
            if (player1Speed == 0)
            {
                

                p1Counter++;
                if (p1Counter == 100)
                {
                    player1Speed = 5;
                    p1Counter = 0;
                }
            }

            if (player1.IntersectsWith(point))
            {
                player1Score++;
                p1ScoreLabel.Text = $"Player 1 Score = {player1Score}";
                
                
                Random rand = new Random();
               
                point.X = rand.Next(30, 470);
                point.Y = rand.Next(30, 470);
                collect.Play();

            }
            else if (player2.IntersectsWith(point))
            {
                player2Score++;
                p2ScoreLabel.Text = $"Player 2 Score = {player2Score}";
                Random rand = new Random();

                point.X = rand.Next(30, 470);
                point.Y = rand.Next(30, 470);
                collect.Play();
            }
            if (player1.IntersectsWith(speed))
            {
                player1Speed++;
                player1Score--;
                p1ScoreLabel.Text = $"Player 1 Score = {player1Score}";
                woosh.Play();


                Random rand = new Random();

                speed.X = rand.Next(30, 470);
                speed.Y = rand.Next(30, 470);

            }
            else if (player2.IntersectsWith(speed))
            {
                player2Speed++;
                player2Score--;
                p2ScoreLabel.Text = $"Player 2 Score = {player2Score}";
                woosh.Play();

                Random rand = new Random();

                speed.X = rand.Next(30, 470);
                speed.Y = rand.Next(30, 470);
            }
            if (player1.IntersectsWith(timeSlow))
            {
                timeSlowP1++;
                tSLabel1.Text = $"Time Slow Count P1 = {timeSlowP1}";

                timeSlow.X = -10;
                timeSlow.Y = -10;
                collect.Play();
            }
            else if (player2.IntersectsWith(timeSlow))
            {
                timeSlowP2++;
                tSLabel2.Text = $"Time Slow Count P2 = {timeSlowP2}";

                timeSlow.X = -10;
                timeSlow.Y = -10;
                collect.Play();
            }
        

            if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1  Wins!!";
            }
            else if (player1Score == -10)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
            }
            else if (player2Score == 5)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2  Wins!!";
            }
            else if (player2Score == -10)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1  Wins!!";
            }
            else if (player1Speed == 20)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "You're Too Fast. \n Player 2  Wins!!";
            }
            else if (player2Speed == 20)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "You're Too Fast. \n Player 1  Wins!!";
            }
            Refresh();


        }

        private void timeslowTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
