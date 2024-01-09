
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeTwoToFour_EndPoints.Service.TwoQuestions;

namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Controllers;

[ApiController]
[Route("[controller]")]

public class TwoQuestionsController : ControllerBase
{
    private readonly ITwoQuestions _twoQuestionsService;

    public TwoQuestionsController(ITwoQuestions TwoQuestionsService)
    {
        _twoQuestionsService = TwoQuestionsService;
    }

    [HttpGet]
    [Route("MakeASentence/{name}/{time}")]
    public string MakeASentence(string name, string time)
    {
        return _twoQuestionsService.MakeASentence(name, time);
    }

}
