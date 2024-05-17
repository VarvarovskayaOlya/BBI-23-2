class Program3
{
    static void Main(string[] args)
    {
        List<MenTeam> menTeams =
        [
            new MenTeam("Сборная России Мужская", [
                new Gymnast("Иванов", [3.5, 4.2, 3.9]),
                new Gymnast("Петров", [4.1, 4.3, 4.5]),
                new Gymnast("Сидоров", [3.9, 4.1, 4.3])
            ]),

            new MenTeam("Сборная США Мужская", [
                new Gymnast("Smith", [3.7, 4.1, 3.9]),
                new Gymnast("Johnson", [4.0, 4.2, 3.4]),
                new Gymnast("Williams", [3.9, 4.1, 4.3])
            ]),

            new MenTeam("Сборная Китая Мужская", [
                new Gymnast("Li", [3.7, 2.1, 3.9]),
                new Gymnast("Wang", [4.7, 4.6, 4.4]),
                new Gymnast("Zhang", [3.8, 3.1, 4.6])
            ])
        ];

        List<WomenTeam> womenTeams =
        [
            new WomenTeam("Сборная России Женская", [
                new Gymnast("Иванова", [3.8, 4.2, 3.3]),
                new Gymnast("Петрова", [2.1, 4.3, 4.2]),
                new Gymnast("Сидорова", [3.8, 4.4, 2.3])
            ]),

            new WomenTeam("Сборная Франции Женская", [
                new Gymnast("Smith", [3.7, 4.1, 3.2]),
                new Gymnast("Johnson", [4.0, 4.2, 4.4]),
                new Gymnast("Williams", [3.9, 2.1, 4.1])
            ]),

            new WomenTeam("Сборная Италии Женская", [
                new Gymnast("Li", [3.8, 3.1, 3.9]),
                new Gymnast("Wang", [4.1, 2.9, 2.4]),
                new Gymnast("Zhang", [3.8, 4.9, 3.1])
            ])
        ];

        menTeams.Sort((team1, team2) => team2.GetAverageResult().CompareTo(team1.GetAverageResult()));
        womenTeams.Sort((team1, team2) => team2.GetAverageResult().CompareTo(team1.GetAverageResult()));

        Console.WriteLine("Мужские команды:");
        foreach (var team in menTeams)
        {
            Console.WriteLine($"{team.TeamName}: средний результат {team.GetAverageResult():f2}");
        }

        Console.WriteLine("\nЖенские команды:");
        foreach (var team in womenTeams)
        {
            Console.WriteLine($"{team.TeamName}: средний результат {team.GetAverageResult():f2}");
        }

        List<Team> teams = new List<Team>();
        teams.AddRange(menTeams);
        teams.AddRange(womenTeams);

        teams.Sort((team1, team2) => team2.GetAverageResult().CompareTo(team1.GetAverageResult()));
        
        Team highestTeam = teams[0];
        Console.WriteLine($"\nЛучшая команда: {highestTeam.TeamName}");
    }
}