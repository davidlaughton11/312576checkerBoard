/*David Laughton
*March 22, 2019
*A checkerboard in canvas
*/
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _312576checkerboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    Rectangle w = new Rectangle();
                    w.Height = 100;
                    w.Width = 100;
                    if ((j + i) % 2 == 0)
                    {
                        w.Fill = Brushes.Yellow;
                    }
                    else
                    {
                        w.Fill = Brushes.Black;
                    }
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, i * 100);
                    Canvas.SetLeft(w, j * 100);
                }
            }
        }

    }
}

