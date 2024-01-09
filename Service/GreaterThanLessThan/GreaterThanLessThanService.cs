using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Service.GreaterThanLessThan
{
    public class GreaterThanLessThanService : IGreaterThanLessThan
    {
        public string CheckGreaterOrLess(string num1, string num2)
        {
            double numberOne = 0;
            double numberTwo = 0;

            bool isTrue = double.TryParse(num1, out numberOne);
            bool isTrueAgain = double.TryParse(num2, out numberTwo);

            if (isTrue && isTrueAgain)
            {
                if (numberOne > numberTwo)
                {
                    return $"{numberOne} is greater than {numberTwo} \n {numberTwo} is less than {numberOne}";
                }
                else if (numberOne == numberTwo)
                {
                    return $"{numberOne} is equal too {numberTwo} ";
                }
                else
                {
                    return $"{numberTwo} is greater than ${numberOne} \n {numberOne} is less than {numberTwo}";
                }
            }
            else
            {
                return "pick some real numbers ";
            }



        }
    }
}