using System;

public class Player{

    public string number;
    public int healthPoints;
    public int experiencePoints;

    public static void Main()
    {
        

    }

    public void TakeDamage(int a){
    healthPoints=healthPoints-a;
    Console.WriteLine($"Player took{healthPoints} pts damage");
    }

    public void AddXP(int x){
    experiencePoints=experiencePoints+x;
    }

    public void Show(){
    Console.WriteLine(number+" hp:"+healthPoints+" xp:"+experiencePoints);
    }

}