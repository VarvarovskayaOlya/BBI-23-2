public abstract class Discipline
{
    public abstract string DisciplineName { get; }
    
    public abstract List<Gymnast> Gymnasts { get; }

    public abstract void PerformJump();
    
    public abstract void PrintTable();
}

public class LongJump : Discipline
{
    public override string DisciplineName => "Прыжки в длину";
    public override List<Gymnast> Gymnasts { get; }
    
    public LongJump(List<Gymnast> gymnasts)
    {
        Gymnasts = gymnasts;
    }

    public override void PerformJump()
    {
        foreach (Gymnast gymnast in Gymnasts)
        {
            Console.WriteLine($"Прыжок в длину: {gymnast.GetSurname()}");
        }
    }
    
    public override void PrintTable()
    {
        Console.WriteLine($"Таблица результатов для дисциплины \"{DisciplineName}\":");
        foreach (Gymnast gymnast in Gymnasts)
        {
            gymnast.PrintResult();
        }
    }
}

public class HighJump : Discipline
{
    public override string DisciplineName => "Прыжки в высоту";
    public override List<Gymnast> Gymnasts { get; }
    
    public HighJump(List<Gymnast> gymnasts)
    {
        Gymnasts = gymnasts;
    }

    public override void PerformJump()
    {
        foreach (Gymnast gymnast in Gymnasts)
        {
            Console.WriteLine($"Прыжок в высоту: {gymnast.GetSurname()}");
        }
    }
    
    public override void PrintTable()
    {
        Console.WriteLine($"Таблица результатов для дисциплины \"{DisciplineName}\":");
        foreach (Gymnast gymnast in Gymnasts)
        {
            gymnast.PrintResult();
        }
    }
}