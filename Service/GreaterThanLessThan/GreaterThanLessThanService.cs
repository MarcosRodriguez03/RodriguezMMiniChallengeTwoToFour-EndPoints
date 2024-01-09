using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Service.GreaterThanLessThan
{
    public class GreaterThanLessThanService : IGreaterThanLessThan
    {
        public string CheckGreaterOrLess(double num1, double num2)
        {
            if (num1 > num2)
            {
                return $"{num1} is greater than {num2} \n {num2} is less than {num1}";
            }
            else if (num1 == num2)
            {
                return $"{num1} is equal too {num2} ";
            }
            else
            {
                return $"{num2} is greater than ${num1} \n {num1} is less than {num2}";
            }
        }
    }
}