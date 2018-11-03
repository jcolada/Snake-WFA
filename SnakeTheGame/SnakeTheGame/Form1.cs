using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeTheGame
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private Brush snakeColor;
        private bool brdrlsMode = false;
        private bool insMode = false;

        //every 3 times we eat we will increase speed
        private int eatCount = 0; 
        public int highScoreNum = 0;

        public Form1()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 100;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();
            
            //startGame();
        }

        private void updateScreen(object sender, EventArgs e)
        {
            if(Settings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                if(Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                else if(Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if(Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                else if(Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }
                movePlayer();
            }
            pbCanvas.Invalidate();
        }

        private void movePlayer()
        {
            for(int i = Snake.Count - 1; i >= 0; i--)
            {
                //movement of the snake's head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].x++;
                            break;
                        case Directions.Left:
                            Snake[i].x--;
                            break;
                        case Directions.Up:
                            Snake[i].y--;
                            break;
                        case Directions.Down:
                            Snake[i].y++;
                            break;
                    }

                    int maxXpos = pbCanvas.Size.Width / Settings.Height;
                    int maxYpos = pbCanvas.Size.Height / Settings.Width;


                    if (brdrlsMode)
                    {
                        //borderless
                        if (Snake[i].x == -1)
                        {
                            Snake[i].x = maxXpos;
                        }
                        else if (Snake[i].x == maxXpos + 1)
                        {
                            Snake[i].x = -1;
                        }
                        else if (Snake[i].y == maxYpos + 1)
                        {
                            Snake[i].y = 0;
                        }
                        else if (Snake[i].y == 0)
                        {
                            Snake[i].y = maxYpos;
                        }
                    }
                    else
                    {
                        if ( //detect if snake reaches border of game, end game if true
                        Snake[i].x < 0 || Snake[i].y < 0 ||
                        Snake[i].x > maxXpos || Snake[i].y > maxYpos
                        )
                        {
                            die();
                        }

                    }


                    //detect collision with self
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if ((Snake[i].x == Snake[j].x) && (Snake[i].y == Snake[j].y))
                        {
                            die();
                        }
                    }

                    //detects food collision
                    if ((Snake[0].x == food.x) && (Snake[0].y == food.y))
                    {
                        eat();
                    }
                }

                //otherwise move body to location of head
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if(Settings.GameOver == false)
            {

                for(int i = 0; i < Snake.Count; i++)
                {
                    //draw snake body and head
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(
                            Snake[i].x * Settings.Width,
                            Snake[i].y * Settings.Height,
                            Settings.Width, Settings.Height
                            ));
                    //draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(
                            food.x * Settings.Width,
                            food.y * Settings.Height,
                            Settings.Width, Settings.Height
                            ));
                }
            }
            else
            {
                //end game text
                string gameOver = "Game Over \n" + "Final Score is " + Settings.Score + "\n";
                endText.Text = gameOver;
                endText.Visible = true;
            }
        }

        private void startGame()
        {
            endText.Visible = false;
            new Settings();
            Snake.Clear();

            getSnakeColorChoice();
            brdrlsMode = borderlessModeIndicator.Checked;
            insMode = insaneModeIndicator.Checked;
            if (insMode)
            {
                gameTimer.Interval = 10;
            }
            DisableOptions();

            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head);

            gameScore.Text = Settings.Score.ToString();
            generateFood();
        }

        private void generateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            int maxYpos = pbCanvas.Size.Height / Settings.Height;

            Random rnd = new Random();
            food = new Circle { x = rnd.Next(0, maxXpos), y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            Circle body = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };

            Snake.Add(body);
            Settings.Score += Settings.Points;
            gameScore.Text = Settings.Score.ToString();

            //only increase speed on not insane mode
            if (!insMode)
            {
                if (eatCount == 3)
                {
                    eatCount = 0;
                    gameTimer.Interval -= Settings.Speed;
                }
                eatCount++;
            }        

            generateFood();
        }

        private void die()
        {
            Settings.GameOver = true;
            if((int)Settings.Score > highScoreNum)
            {
                highScoreNum = (int)Settings.Score;
                highScoreValue.Text = highScoreNum.ToString();
            }
            EnableOptions();            
        }

        private void start_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void getSnakeColorChoice()
        {
            switch(snakeColorChoice.SelectedItem.ToString())
            {
                case "Green":
                    snakeColor = Brushes.Green;
                    break;
                case "Red":
                    snakeColor = Brushes.Red;
                    break;
                case "Blue":
                    snakeColor = Brushes.Blue;
                    break;
                case "Yellow":
                    snakeColor = Brushes.Yellow;
                    break;
                case "Purple":
                    snakeColor = Brushes.Purple;
                    break;
                case "Orange":
                    snakeColor = Brushes.Orange;
                    break;
                case "Pink":
                    snakeColor = Brushes.Pink;
                    break;
                case "Aqua":
                    snakeColor = Brushes.Aqua;
                    break;
            }
        }
        private void EnableOptions()
        {
            snakeColorChoice.Enabled = true;
            start.Enabled = true;
            borderlessModeIndicator.Enabled = true;
            insaneModeIndicator.Enabled = true;
        }
        private void DisableOptions()
        {
            snakeColorChoice.Enabled = false;
            start.Enabled = false;
            borderlessModeIndicator.Enabled = false;
            insaneModeIndicator.Enabled = false;
        }
    }
}
