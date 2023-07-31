namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            coins(gameSpeed);
            coinsCollected();
        }

        int collected = 0;

        Random random = new Random();
        int x;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = random.Next(0, 200);
                enemy1.Location = new Point(x, 0);
               
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = random.Next(0, 200);
                enemy2.Location = new Point(x, 0);
  
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = random.Next(200, 350);
                enemy3.Location = new Point(x, 0);
                
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = random.Next(0, 200);
                coin1.Location = new Point(x, 0);
                
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = random.Next(0, 200);
                coin2.Location = new Point(x, 0);

            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = random.Next(0, 200);
                coin3.Location = new Point(x, 0);

            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = random.Next(0, 200);
                coin4.Location = new Point(x, 0);

            }
            else
            {
                coin4.Top += speed;
            }
            if (coin5.Top >= 500)
            {
                x = random.Next(0, 200);
                coin5.Location = new Point(x, 0);

            }
            else
            {
                coin5.Top += speed;
            }
            if (coin6.Top >= 500)
            {
                x = random.Next(0, 200);
                coin6.Location = new Point(x, 0);

            }
            else
            {
                coin6.Top += speed;
            }
        }


        void gameOver()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveLine(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            //pictureBox1.Top += speed;
            //pictureBox2.Top += speed;
            //pictureBox3.Top += speed;
            //pictureBox4.Top += speed;

        }

        void coinsCollected()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin5.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin6.Bounds))
            {
                collected++;
                coinScore.Text = "Coins Score = " + collected.ToString();
                x = random.Next(50, 300);
                coin6.Location = new Point(x, 0);
            }
        }

        int gameSpeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left > 0)
                {
                    car.Left += -8;

                }
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Left < 350)
                {
                    car.Left += 8;

                }
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }

        private void enemy2_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }
    }
}