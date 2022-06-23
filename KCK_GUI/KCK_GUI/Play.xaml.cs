using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KCK_GUI
{
    /// <summary>
    /// Interaction logic for Play.xaml
    /// </summary>
    public partial class Play : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();
        bool moveLeft, moveRight;
        List<Rectangle> itemRemover = new List<Rectangle>();
        Random rand = new Random();
        int enemyCounter = 100;
        int playerSpeed = 10;
        int limit = 50;
        int score = 0;
        int damage = 3;
        int enemySpeed = 5;

        Rect playerHitBox;
        public Play()
        {
            InitializeComponent();

            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            MyCanvas.Focus();

            ImageBrush bg = new ImageBrush();
            bg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/background.png"));
            bg.TileMode = TileMode.Tile;
            bg.Viewport = new Rect(0,0, 0.15, 0.15);
            bg.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            MyCanvas.Background = bg;

            
            Ship ship = new Ship();
            ship.MakeShip(MyCanvas);

        }

        private void GameLoop(object sender, EventArgs e)
        {
            playerHitBox = new Rect(Canvas.GetLeft(player), Canvas.GetTop(player), player.Width, player.Height);

            enemyCounter -= 1;
            scoreText.Content = "Score: " + score;
            HP.Content = "HP: " + damage;

            if (enemyCounter < 0)
            {
                //MakeEnemies();
                Enemy enemy = new Enemy(MyCanvas);
                enemy.MakeEnemies();
                enemyCounter = limit;
            }
            if(moveLeft == true && Canvas.GetLeft(player) > 0)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) - playerSpeed);
            }
            if(moveRight == true && Canvas.GetLeft(player) + 90 < 630)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) + playerSpeed);   
            }

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                if(x is Rectangle && (string)x.Tag == "bullet")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) - 20);
                    Rect bulletHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if(Canvas.GetTop(x) < 10)
                    {
                        itemRemover.Add(x);
                    }

                    foreach (var ii in MyCanvas.Children.OfType<Rectangle>())
                    {
                        if (ii is Rectangle && (string)ii.Tag == "enemy")
                        {
                            Rect enemyHit = new Rect(Canvas.GetLeft(ii), Canvas.GetTop(ii), ii.Width, ii.Height);
                            if(bulletHitBox.IntersectsWith(enemyHit))
                            {
                                itemRemover.Add(x);
                                itemRemover.Add(ii);
                                score += 10;
                            }
                        }
                    }
                }
                if(x is Rectangle && (string)x.Tag == "enemy")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + enemySpeed);
                    if(Canvas.GetTop(x) > 750)
                    {
                        itemRemover.Add(x);
                        //score =+ 10;
                    }
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if(playerHitBox.IntersectsWith(enemyHitBox))
                    {
                        itemRemover.Add(x);
                        damage--;
                    }
                }
            }
            foreach (Rectangle ii in itemRemover)
            {
                MyCanvas.Children.Remove(ii);
            }
            if(damage == 0)
            {
                gameTimer.Stop();
                HP.Content = "HP: 0";
                HP.Foreground = Brushes.Red;
                MessageBox.Show("U LOST :( \n YOUR SCORE IS: " + score);
            }
        }

        private void MyCanvas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if (e.Key == Key.Right)
            {
                moveRight = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if (e.Key == Key.Right)
            {
                moveRight = false;
            }
            if(e.Key == Key.Space)
            {
                Rectangle newBullet = new Rectangle
                {
                    Tag = "bullet",
                    Height = 20,
                    Width = 5,
                    Fill = Brushes.White,
                    Stroke = Brushes.Red
                };
                Canvas.SetLeft(newBullet, Canvas.GetLeft(player) + player.Width / 2);
                Canvas.SetTop(newBullet, Canvas.GetTop(player) - newBullet.Height);
                MyCanvas.Children.Add(newBullet);
            }
        }
    }
}
