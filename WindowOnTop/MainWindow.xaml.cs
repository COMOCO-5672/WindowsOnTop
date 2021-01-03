using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
using WindowOnTop.Model;
using WindowOnTop.Util;
using Point = System.Windows.Point;

namespace WindowOnTop
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XySys xySys = new XySys();

            var mySys = xySys.CreateCanvas((int)DRStackPanel.Width, 10);

            //DRStackPanel.Children.Add(mySys);

            PointF[] pointList = new PointF[] { new PointF(0.3f, 0.4f), new PointF(200, 200), new PointF(50.3f, 103.2f) };

            PointF[] aa = Bezier.draw_bezier_curves(pointList, pointList.Length, 0.001f);

            List<Point> points= new List<Point>();

            foreach (var t in aa)
            {
                points.Add(new Point()
                {
                    X = t.X,
                    Y = t.Y
                });
            }
            Canvas canvas = new Canvas();

            Polyline polyline = new Polyline();

            polyline.Stroke = new SolidColorBrush(Colors.Red);

            polyline.StrokeThickness = 2;

            points?.ForEach(x=>{ polyline.Points.Add(x); });

            DRStackPanel.Children.Add(polyline);
        }
    }
}
