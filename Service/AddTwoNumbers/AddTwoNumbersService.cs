
namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Service.AddTwoNumbers
{
    public class AddTwoNumbersService : IAddTwoNumbers

    {
        public double AddTwoNumbersFunction(string num1, string num2)
        {
            double numberOne = Convert.ToDouble(num1);
            double numberTwo = Convert.ToDouble(num2);
            return numberOne + numberTwo;
        }
    }
}