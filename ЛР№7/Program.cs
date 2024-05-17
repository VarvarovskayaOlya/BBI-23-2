class Program
{
    static void Main(string[] args)
    {
        var personOfYear = new PersonOfYear();
        personOfYear.AddResponse(new SurveyResponse("Иванов", 10, 50));
        personOfYear.AddResponse(new SurveyResponse("Петров", 5, 25));

        var discoveryOfYear = new DiscoveryOfYear();
        discoveryOfYear.AddResponse(new SurveyResponse("Сидоров", 3, 30));
        discoveryOfYear.AddResponse(new SurveyResponse("Козлов", 7, 70));
        discoveryOfYear.AddResponse(new SurveyResponse("Смирнов", 0, 0));

        personOfYear.PrintTable();
        Console.WriteLine();
        discoveryOfYear.PrintTable();
    }
}