using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WindowOnTop.Util
{
    /*-----------------------------------
	* Author: COMOCO
	* CreateTime：2021/1/1 12:14:29
	* Description: 坐标系类
	* 
	* *[ChageLog]：
	* 
	*******************************************************************
	* Copyright @COMOCO 2021. All rights reserved.
	*******************************************************************
	--------------------------------------*/
    class XySys
    {
		Canvas _temp_Canvas=new Canvas();

        public Canvas CreateCanvas(int WH_Canvas,int Num_Cell)
        {

            return createSys_Private(WH_Canvas,Num_Cell);
        }

        private Canvas createSys_Private(int Wh_Canvas,int Num_Cell)
        {
            Point xy_start=new Point();

            Point xy_end=new Point();

            xy_start.X = 0;

            xy_start.Y = 0;

            xy_end.Y = 0;

            xy_end.X = 0;

            { //绘制横线
                xy_start.X = 0;
                for (int j = 0; j < Num_Cell; j++)
                {
                    xy_start.Y = j * Wh_Canvas / Num_Cell;

                    xy_end.X = Wh_Canvas;

                    xy_end.Y = xy_start.Y;

                    DrawLine(xy_start,xy_end);
                }

            }
            {
                //绘制纵线
                xy_start.Y = 0;
                for (int j = 0; j <= Num_Cell; j++)
                {
                    xy_start.X = j * Wh_Canvas / Num_Cell;
                    xy_end.X = xy_start.X;
                    xy_end.Y = Wh_Canvas;
                    DrawLine(xy_start, xy_end);
                }
            }

            return _temp_Canvas;
        }

        private void DrawLine(Point startPt,Point endPt)
        {
            LineGeometry myLineGeometry=new LineGeometry();

            myLineGeometry.StartPoint = startPt;

            myLineGeometry.EndPoint = endPt;    //设置一条线的起点和终点

            System.Windows.Shapes.Path myPath =new System.Windows.Shapes.Path();    //这条线用路径给画出来

            myPath.Stroke = Brushes.Black;

            myPath.StrokeThickness = 1;

            myPath.Data = myLineGeometry;

            _temp_Canvas.Children.Add(myPath);

        }


    }
}
