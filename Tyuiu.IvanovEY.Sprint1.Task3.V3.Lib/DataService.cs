using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEY.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            double result = length * width * height;
            return Math.Round(result, 3);
        }
    }
}
