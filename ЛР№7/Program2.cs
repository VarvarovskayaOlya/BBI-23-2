class Program2
{
    static void Main(string[] args)
    {
        var gymnast1 = new Gymnast("Иванов", [3.5, 4.2, 3.9]);
        var gymnast2 = new Gymnast("Петров", [4.1, 4.3, 4.5]);
        var gymnast3 = new Gymnast("Козлов", [3.9, 4.1, 4.3]);

        var longJump = new LongJump([gymnast1, gymnast2]);
        var highJump = new HighJump([gymnast1, gymnast3]);
        
        longJump.PerformJump();
        highJump.PerformJump();
        
        Console.WriteLine();
        longJump.PrintTable();
        highJump.PrintTable();
    }
}