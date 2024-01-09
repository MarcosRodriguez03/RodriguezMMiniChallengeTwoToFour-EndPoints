
namespace RodriguezMMiniChallengeTwoToFour_EndPoints.Service.TwoQuestions
{
    public class TwoQuestionsService : ITwoQuestions
    {
        public string MakeASentence(string name, string time)
        {
            return $"You are {name} and you woke up at {time}. ";
        }
    }
}