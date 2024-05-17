public abstract class YearEvent
{
    public abstract string EventName { get; }
    public List<SurveyResponse> Responses { get; } = new List<SurveyResponse>();

    public void AddResponse(SurveyResponse response)
    {
        Responses.Add(response);
    }

    public abstract void PrintTable();
}

public class PersonOfYear : YearEvent
{
    public override string EventName => "Человек года";

    public override void PrintTable()
    {
        Console.WriteLine($"Таблица ответов для события \"{EventName}\":");
        foreach (var response in Responses)
        {
            response.PrintResponse();
        }
    }
}

public class DiscoveryOfYear : YearEvent
{
    public override string EventName => "Открытие года";

    public override void PrintTable()
    {
        Console.WriteLine($"Таблица ответов для события \"{EventName}\":");
        foreach (var response in Responses)
        {
            response.PrintResponse();
        }
    }
}