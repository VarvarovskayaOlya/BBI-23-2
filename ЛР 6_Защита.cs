using System;

struct Gymnast
{
    private string _surname;
    private double _highestResult;

    public Gymnast(string famile1, double[] results)
    {
        _surname = famile1;
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
    Console.WriteLine("Фамилия: {0}\t" + "Лучший результат: {1,4:f2}", _surname, _highestResult);
}

public static void SortByHighestResult(Gymnast[] gymnasts)
{
    for (int i = 1; i < gymnasts.Length; i++)
    {
        Gymnast k = gymnasts[i];
        int j = i - 1;

        while (j >= 0 && gymnasts[j].GetHighestResult() < k.GetHighestResult())
        {
            gymnasts[j + 1] = gymnasts[j];
            j--;
        }

        gymnasts[j + 1] = k;
    }
}
}

class Program
{
    static void Main(string[] args)
    {
        Gymnast[] gymnasts = new Gymnast[5]
        {
            new Gymnast("Борисов", new double[] {15.7, 7.5, 16.0}),
            new Gymnast("Петров", new double[] {16.7, 9.5, 18.0}),
            new Gymnast("Иванов", new double[] {19.7, 2.5, 15.0}),
            new Gymnast("Николаев", new double[] {20.7, 5.5, 13.0}),
            new Gymnast("Андреев", new double[] {12.7, 9.5, 20.0})
        };

        Gymnast.SortByHighestResult(gymnasts);

        Console.WriteLine();

        foreach (var gymnast in gymnasts)
        {
            gymnast.PrintResult();
        }
    }
}