using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowOnTop.Util
{
    /*-----------------------------------
	 * Author: COMOCO
	 * CreateTime：2021/1/3 16:31:01
	 * Description: GDI+
	 * 
	 * *[ChageLog]：
	 * 
	 *******************************************************************
	 * Copyright @COMOCO 2021. All rights reserved.
	 *******************************************************************
	 --------------------------------------*/
    public static class Bezier
    {
        /// <summary>
        /// 绘制N阶贝塞尔曲线路径
        /// </summary>
        /// <param name="points">输入点</param>
        /// <param name="count">点数（n+1）</param>
        /// <param name="step">步长，步长越小，轨迹点越密集</param>
        /// <returns></returns>
        public static PointF[] draw_bezier_curves(PointF[] points, int count, float step)
        {
            List<PointF> bezier_curves_points = new List<PointF>();

            float t = 0f;
            do
            {
                PointF temp_point = bezier_interpolation_func(t, points, count);

                t += step;

                bezier_curves_points.Add(temp_point);

            } while (t <= 1 && count > 1);  // 一个点的情况直接跳出

            return bezier_curves_points.ToArray();  // 曲线轨迹上的所有坐标点
        }

        /// <summary>
        /// N阶贝塞尔曲线插值计算函数
        /// 根据起点，n个控制点，终点 计算贝塞尔曲线插值
        /// </summary>
        /// <param name="t">当前插值位置0~1，0位起点，1为终点</param>
        /// <param name="points">起点，n-1个控制点，终点</param>
        /// <param name="count">n+1个点</param>
        /// <returns></returns>
        private static PointF bezier_interpolation_func(float t, PointF[] points, int count)
        {
            if (points.Length < 1)  // 一个点都没有
                throw new ArgumentOutOfRangeException();

            PointF[] tmp_points = new PointF[count];
            for (int i = 1; i < count; ++i)
            {
                for (int j = 0; j < count - i; ++j)
                {
                    if (i == 1) // 计算+搬运数据,在计算的时候不要污染源数据
                    {
                        tmp_points[j].X = (float)(points[j].X * (1 - t) + points[j + 1].X * t);
                        tmp_points[j].Y = (float)(points[j].Y * (1 - t) + points[j + 1].Y * t);
                        continue;
                    }
                    tmp_points[j].X = (float)(tmp_points[j].X * (1 - t) + tmp_points[j + 1].X * t);
                    tmp_points[j].Y = (float)(tmp_points[j].Y * (1 - t) + tmp_points[j + 1].Y * t);
                }
            }
            return tmp_points[0];

        }

        /// <summary>
        /// 计算组合数公式
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private static ulong calc_combination_number(int n, int k)
        {
            ulong[] result = new ulong[n + 1];

            for (int i = 1; i <= n; i++)
            {
                result[i] = 1;
                for (int j = i - 1; j >= 1; j--)
                {
                    result[j] += result[j - 1];
                }
                result[0] = 1;
            }
            return result[k];
        }

    }
}
