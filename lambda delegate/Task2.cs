using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task2
{
    public Action showCurrentTime = () => Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
    public Action showCurrentDate = () => Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
    public Action showCurrentDayOfWeek = () => Console.WriteLine("Current Day of Week: " + DateTime.Now.DayOfWeek);
    public Func<double, double, double> calculateTriangleArea = (baseLength, height) => 0.5 * baseLength * height;
    public Func<double, double, double> calculateRectangleArea = (width, height) => width * height;
}