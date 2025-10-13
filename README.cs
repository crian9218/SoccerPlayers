using System;

public class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNumber { get; set; }
    public string Position { get; set; }
    public int GoalsScored { get; set; }

    // Constructor
    public SoccerPlayer(string name, int jerseyNumber, string position, int goalsScored)
    {
        Name = name;
        JerseyNumber = jerseyNumber;
        Position = position;
        GoalsScored = goalsScored;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Player: {Name}");
        Console.WriteLine($"Number: {JerseyNumber}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Goals Scored: {GoalsScored}");
    }
}

public class Program
{
    public static void Main()
    {
        SoccerPlayer player = new SoccerPlayer("Kylian Mbappé", 7, "Forward", 42);

        player.DisplayInfo();
    }
}
