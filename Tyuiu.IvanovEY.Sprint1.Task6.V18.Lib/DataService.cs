using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEY.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            bool isNumber = int.TryParse(value, out int number);
            if (isNumber && number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
    