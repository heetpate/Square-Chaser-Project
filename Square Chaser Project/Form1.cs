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
using System.Runtime.InteropServices;

// May 08, 2024
//Heet Patel
//Square Chaser

namespace Square_Chaser_Project
{
    public partial class Form1 : Form
    {
        int player1Speed = 2;
        int player2Speed = 2;
        int maxSpeed = 7;

        int pause = 175;

        //players score
        int player1Score = 0;
        int player2Score = 0;

        //dangerous object that decrease the point
        int dangerObjectXSpeed = -5;
        int dangerObjectYSpeed = -5;

        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool upPressed = false;
        bool downPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;

        Random randGen = new Random();

        //Players Rectangle
        Rectangle player1 = new Rectangle(75, 130, 15, 15);
        Rectangle player2 = new Rectangle(250, 130, 15, 15);
        Rectangle whiteSquare = new Rectangle(250, 250, 7, 7); // white and yellow 
        Rectangle yellowCircle = new Rectangle(250, 50, 7, 7);
        Rectangle dangerObject = new Rectangle(150, 50, 15, 15); // extra object, if touched then lossing of point
        Rectangle boundry = new Rectangle(20, 20, 310, 250); //boundry for the players

        //Colors for Players, boost and score point
        SolidBrush limeBrush = new SolidBrush(Color.Lime);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //yellow color for boost
        SolidBrush whiteBrush = new SolidBrush(Color.White); //white color for points
        SolidBrush orangeRedBrush = new SolidBrush(Color.OrangeRed);

        SoundPlayer yellowBoost = new SoundPlayer(Properties.Resources.boost);
        SoundPlayer collectPoint = new SoundPlayer(Properties.Resources.collectPoint);
        SoundPlayer cheer = new SoundPlayer(Properties.Resources.cheering);
        SoundPlayer losingPoint = new SoundPlayer(Properties.Resources.losingPoint);

        Image backImage = Properties.Resources.spaceImage;

        Pen yellowPen = new Pen(Color.Yellow, 6); //purple color for boundry

        public Form1()
        {
            InitializeComponent();

            SpeedRandomizer();
            PointRandomizer();
            DangerRandomizer();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Coloring the Rectangle
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(limeBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, whiteSquare);
            e.Graphics.FillEllipse(yellowBrush, yellowCircle);
            e.Graphics.FillRectangle(orangeRedBrush, dangerObject);

            //Drawing the boundry of the 
            e.Graphics.DrawRectangle(yellowPen, boundry);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //keys for first and second player to click to enable it
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;

                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // unable when the keys are not pressed
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;

                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
          
            ObjectMovement();
            Boundries();
            PlayerMovement();
            Collision();
            pause--;
            CheckTheWinner();

            Refresh();
        }

        public void SpeedRandomizer()
        { 
            //Generate random position for yellow circle/the boost
            yellowCircle.X = randGen.Next(22, 308);
            yellowCircle.Y = randGen.Next(22, 248);
        }

        public void PointRandomizer()
        {
            //Generate random position for whitesquare/the point
            whiteSquare.X = randGen.Next(22, 308);
            whiteSquare.Y = randGen.Next(22, 248);
        }

        public void DangerRandomizer()
        {
            //Generate random position for the dangerObject
            dangerObject.X = randGen.Next(22, 308);
            dangerObject.Y = randGen.Next(22, 248);
        }

        public void ObjectMovement()
        {
            // Move the dangerObject
            dangerObject.X += dangerObjectXSpeed;
            dangerObject.Y += dangerObjectYSpeed;

            //checks for player 1 & 2's speed reaching maximum limit
           if (player1Speed > maxSpeed)
            {
                player1Speed = maxSpeed;
            }
            if (player2Speed > maxSpeed)
            {
                player2Speed = maxSpeed;
            }
        }

        public void Boundries()
        {
            // Check if dangerObject hits the boundaries
            if (dangerObject.Left < boundry.Left || dangerObject.Right > boundry.Right)
            {
                dangerObjectXSpeed = -dangerObjectXSpeed;
            }
            if (dangerObject.Top < boundry.Top || dangerObject.Bottom > boundry.Bottom)
            {
                dangerObjectYSpeed = -dangerObjectYSpeed;
            }
        }

        public void PlayerMovement()
        {
            //move player 1
            if (wPressed == true && player1.Y > 20)
            {
                player1.Y = player1.Y - player1Speed;
            }
            if (sPressed == true && player1.Y < 250)
            {
                player1.Y = player1.Y + player1Speed;
            }
            if (aPressed == true && player1.X > 20)
            {
                player1.X = player1.X - player1Speed;
            }
            if (dPressed == true && player1.X < 310)
            {
                player1.X = player1.X + player1Speed;
            }

            //move player 2
            if (upPressed == true && player2.Y > 20.5)
            {
                player2.Y = player2.Y - player2Speed;
            }
            if (downPressed == true && player2.Y < 250)
            {
                player2.Y = player2.Y + player2Speed;
            }
            if (leftPressed == true && player2.X > 20)
            {
                player2.X = player2.X - player2Speed;
            }
            if (rightPressed == true && player2.X < 310)
            {
                player2.X = player2.X + player2Speed;
            }
        }

        public void Collision()
        {
            //Check if the white and yellow orps hit the player1
            if (whiteSquare.IntersectsWith(player1))
            {
                player1Score++;
                scoreLabel1.Text = $"{player1Score}";

                collectPoint.Play();
                whiteSquare.X = randGen.Next(22, 308);
                whiteSquare.Y = randGen.Next(22, 248);
            }
            else if (yellowCircle.IntersectsWith(player1))
            {
                player1Speed++;

                yellowBoost.Play();
                yellowCircle.X = randGen.Next(22, 308);
                yellowCircle.Y = randGen.Next(22, 248);
            }
            else if (dangerObject.IntersectsWith(player1) && pause < 0)
            {
                pause = 175;
                player1Score--;
                scoreLabel1.Text = $"{player1Score}";
                losingPoint.Play();
            }
            pause--;
            //Check if the white and yellow orps hit the player2
            if (whiteSquare.IntersectsWith(player2) )
            {
                player2Score++;
                scoreLabel2.Text = $"{player2Score}";

                collectPoint.Play();
                whiteSquare.X = randGen.Next(22, 308);
                whiteSquare.Y = randGen.Next(22, 248);
            }
            else if (yellowCircle.IntersectsWith(player2))
            {
                player2Speed++;

                yellowBoost.Play();
                yellowCircle.X = randGen.Next(22, 308);
                yellowCircle.Y = randGen.Next(22, 248);
            }
            else if (dangerObject.IntersectsWith(player2) && pause < 0)
            {
                pause = 175;
                player2Score--;
                scoreLabel2.Text = $"{player2Score}";
                losingPoint.Play();
            }
            
        }

        public void CheckTheWinner()
        {
            //check for the winner 
            if (player1Score == 5)
            {
                winLabel.Text = "Player 1 Wins";
                gameTimer.Stop();
                cheer.Play();
            }
            if (player2Score == 5)
            {
                winLabel.Text = "Player 2 Wins";
                gameTimer.Stop();
                cheer.Play();
            }
            if (player1Score == -5)
            {
                winLabel.Text = "Player 2 Wins";
                gameTimer.Stop();
                cheer.Play();
            }
            if (player2Score == -5)
            {
                winLabel.Text = "Player 1 Wins";
                gameTimer.Stop();
                cheer.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}





