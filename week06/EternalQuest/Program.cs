using System;

class Program
{
    // Exceeding requirements: I added a simple leveling system, the player gains
    // a level for every 500 points earned and the level shows next to the score.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
