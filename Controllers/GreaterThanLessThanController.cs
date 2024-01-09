using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.GreaterThanLessThan;
namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Controllers;
[ApiController]
[Route("[controller]")]


public class GreaterThanLessThanController : ControllerBase
{
    private readonly IGreaterThanLessThan _greaterThanLessThanService;

    public GreaterThanLessThanController(IGreaterThanLessThan greaterThanLessThanService)
    {
        _greaterThanLessThanService = greaterThanLessThanService;
    }

    [HttpGet]
    [Route("GreaterThanLessThan/{num1}/{num2}")]
    public string CheckGreaterOrLess(string num1, string num2)
    {
        // if (num1 > num2)
        // {
        //     return $"{num1} is greater than {num2} \n {num2} is less than {num1}";
        // }
        // else if (num1 == num2)
        // {
        //     return $"{num1} is equal too {num2} ";
        // }
        // else
        // {
        //     return $"{num2} is greater than ${num1} \n {num1} is less than {num2}";
        // }
        return _greaterThanLessThanService.CheckGreaterOrLess(num1, num2);
    }

}
