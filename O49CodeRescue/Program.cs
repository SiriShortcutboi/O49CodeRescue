using System;

public class Program()
{
    public static void Main()
    {
        Player playerOne = new Player();
        Console.WriteLine($"I am Speedrunner #{playerOne.speedrunnernumber}.");
        TakeDamage(20);
        AddXP(25);
        System.Console.WriteLine("Current stats are");
        Show();
    }
}
public class Player{
    public static string SpeedRunnerNumber {get; private set;} = "0";
    public static int HealthPoints {get; private set;} = 100;
    public static int ExperiencePoints {get; private set;} = 0;

    public Player(string SpeedRunnerNumber, int HealthPoints, int ExperiencePoints)
    {
        string SpeedRunnerNumber = speedrunnernumber;
        int HealthPoints = healthpoints;
        int ExperiencePoints = experiencepoints;

    }
    public void TakeDamage(int healthpoints, int agony)
    {
        healthpoints = healthpoints-agony;
        Console.WriteLine($"Player took {agony} damage points");
    }

    public void AddXP(int x)
    {
        ExperiencePoints = experiencepoints+x;
    }

    public void Show()
    {
        Console.WriteLine(SpeedrunnerNumber + " hp: " + HealthPoints + " xp: " + ExperiencePoints);
    }
}

/* 
Reflection Questions
Answer these in comments at the bottom of your code.

Why are PascalCase names used for classes and methods? TO show they are important,
to differentiate from simple variables that might last only a short time inside one
of those methods.                                                      ^
                                                                       |
Why is code formatting important in large projects?
Because you start to learn the system, and then when the system is 
off it can throw you off a lot. Meaning spacing,                       ^
                                                                       |
But it can throw you off in other ways too. Knowing things             |
should be PascalCase or a certain type of secure and then finding      |
 a public method called _input is crazy. it just looks weird-----------

*/