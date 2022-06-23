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
    class Enemy
    {
        Canvas MyCanvas;
        Random rand = new Random();

        public Enemy(Canvas MyCanvas)
        {
            this.MyCanvas = MyCanvas;
        }
        public void MakeEnemies()
        {
            ImageBrush enemySprite = new ImageBrush();
            enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/enemy.png"));
            Rectangle newEnemy = new Rectangle
            {
                Tag = "enemy",
                Height = 50,
                Width = 56,
                Fill = enemySprite
            };
            Canvas.SetTop(newEnemy, -100);
            Canvas.SetLeft(newEnemy, rand.Next(30, 570));
            MyCanvas.Children.Add(newEnemy);
        }
    }
}
