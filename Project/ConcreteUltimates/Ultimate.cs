using System;

namespace Project.ConcreteUltimates;

public class Ultimate : IEnemy, IPuzzle
{
    public string Name => "Ultimate Foe";
    public int Health { get; set; } = 30;
    public int AttackPower => 10;

    public bool IsDefeated => Health <= 0;

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!");
        player.Health -= AttackPower;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
    }

    public string Description => "Solve the ancient riddle to proceed. What has hands but cannot clap?";
    public bool IsResolved { get; set; } = false;

    public bool Resolve(Player player)
    {
        Console.Write("Enter your answer: ");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "clock")
        {
            IsResolved = true;
            Console.WriteLine("Correct! You have solved the puzzle.");
            return true;
        }

        Console.WriteLine("Incorrect answer. Try again.");
        return false;
    }
}


//concrete ultimates conflict that will be both puzzle and enemy
// currently using enemy implementation only