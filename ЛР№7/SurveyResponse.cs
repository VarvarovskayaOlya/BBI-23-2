public class SurveyResponse
{
    private string _personOfYear;
    private int _count;
    private double _percentage;

    public SurveyResponse(string personOfYear, int count, double percentage)
    {
        _personOfYear = personOfYear;
        _count = count;
        _percentage = percentage;
    }

    public string GetPersonOfYear()
    {
        return _personOfYear;
    }

    public void PrintResponse()
    {
        Console.WriteLine($"{_personOfYear}: {_count} ответов ({_percentage:0.00}% от общего числа)");
    }
}