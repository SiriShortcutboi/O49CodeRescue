using System;

public class Program
{
    public static void Main()
    {
        Player playerOne = new Player();
        Console.WriteLine($"I am Speedrunner #{playerOne.SpeedRunnerNumber}.");
        playerOne.TakeDamage(20);
        playerOne.AddXP(25);
        Console.WriteLine("Current stats are");
        playerOne.Show();
    }
}

public class Player
{
    public string SpeedRunnerNumber { get; private set; }
    public int HealthPoints { get; private set; }
    public int ExperiencePoints { get; private set; }

    public Player(string speedRunnerNumber = "7", int healthPoints = 100, int experiencePoints = 0)
    {
        SpeedRunnerNumber = speedRunnerNumber;
        HealthPoints = healthPoints;
        ExperiencePoints = experiencePoints;
    }

    public void TakeDamage(int agony)
    {
        HealthPoints -= agony;
        Console.WriteLine($"Player took {agony} damage points");
    }

    public void AddXP(int x)
    {
        ExperiencePoints += x;
    }

    public void Show()
    {
        Console.WriteLine($"Speedrunner player number: {SpeedRunnerNumber} hp: {HealthPoints} xp: {ExperiencePoints}");
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