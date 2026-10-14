using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEY.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Cos(Math.PI / x);
            double denominator = 3 * Math.Pow(Math.E, x + y);
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}
