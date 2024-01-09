
namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Service.AddTwoNumbers
{
    public class AddTwoNumbersService : IAddTwoNumbers

    {
        public string AddTwoNumbersFunction(string num1, string num2)
        {
            double numberOne = 0;
            bool isTrue = double.TryParse(num1, out numberOne);

            double numberTwo = 0;
            bool isTrueAgain = double.TryParse(num2, out numberTwo);

            if (isTrue && isTrueAgain)
            {
                return $"{numberOne} plus {numberTwo} equals {numberOne + numberTwo}";
            }
            else
            {
                return "enter two valid numbers";
            }



            // double numberOne = Convert.ToDouble(num1);
            // double numberTwo = Convert.ToDouble(num2);

        }
    }
}