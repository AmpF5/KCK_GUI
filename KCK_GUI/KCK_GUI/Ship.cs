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
    class Ship
    {
        public void MakeShip(Canvas MyCanvas)
        {
            ImageBrush playerImage = new ImageBrush();
            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/ship.png"));
            var player = MyCanvas.Children.OfType<Rectangle>().First(x => x.Name == "player");
            player.Fill = playerImage;
        }
    }
}
