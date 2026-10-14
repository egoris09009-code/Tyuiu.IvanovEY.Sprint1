using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEY.Sprint1.Task1.V10.Lib

{
    public class DataService : ISprint1Task1V10
    {
        public double Calculate(double x, double y)
        {
            double result = (x + y) / (1 + x);
            return Math.Round(result, 2);
        }
    }
}
