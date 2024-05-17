public class Gymnast
{
    private string _surname;
    private double _highestResult;

    public Gymnast(string surname, double[] results)
    {
        _surname = surname;
        _highestResult = results[0];
        
        for (int i = 1; i < 3; i++)
        {
            if (results[i] > _highestResult)
            {
                _highestResult = results[i];
            }
        }
    }

    public string GetSurname()
    {
        return _surname;
    }

    public double GetHighestResult()
    {
        return _highestResult;
    }

    public void PrintResult()
    {
        Console.WriteLine($"Фамилия: {_surname}\t\tЛучший результат: {_highestResult:f2}");
    }
}