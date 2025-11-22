namespace Project;

public interface IEnemy
{
    string Name { get; }
    int Health { get; set; }
    int AttackPower { get; }
    
    void Attack(Player player);
    void TakeDamage(int damage);
    bool IsDefeated { get; }
}

 

 //tells you what the enemy is
 //represents a character (an object)
 //will be used by CombatConflicts
 //defines stats and combat behavior