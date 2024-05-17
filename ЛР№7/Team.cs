public class Team
{
    public string TeamName { get; }
    public List<Gymnast> Gymnasts { get; } = new List<Gymnast>();
    
    public Team(string teamName, List<Gymnast> gymnasts)
    {
        TeamName = teamName;
        Gymnasts = gymnasts;
    }
    
    public double GetAverageResult()
    {
        double totalResult = 0;
        foreach (var gymnast in Gymnasts)
        {
            totalResult += gymnast.GetHighestResult();
        }

        return totalResult / Gymnasts.Count;
    }
}

public class MenTeam : Team
{
    public MenTeam(string teamName, List<Gymnast> gymnasts) : base(teamName, gymnasts)
    {
    }
}

public class WomenTeam : Team
{
    public WomenTeam(string teamName, List<Gymnast> gymnasts) : base(teamName, gymnasts)
    {
    }
}