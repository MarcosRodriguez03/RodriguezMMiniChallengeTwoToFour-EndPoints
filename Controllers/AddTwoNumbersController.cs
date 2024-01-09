
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.AddTwoNumbers; // Added with [ApiController]

namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Controllers;

[ApiController]
[Route("[controller]")]

public class AddTwoNumbersController : ControllerBase
{
    private readonly IAddTwoNumbers _addTwoNumbersService;

    public AddTwoNumbersController(IAddTwoNumbers AddTwoNumbersService)
    {
        _addTwoNumbersService = AddTwoNumbersService;
    }

    [HttpGet]
    [Route("AddNumber/{num1}/{num2}")]
    public string AddTwoNumbersFunction(string num1, string num2)
    {
        return _addTwoNumbersService.AddTwoNumbersFunction(num1, num2);
    }


}
