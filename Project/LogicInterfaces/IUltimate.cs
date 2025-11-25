namespace Project
{
    public interface IUltimate
    {
        string Name { get; }
        string Description { get; }
        
        bool Resolve(Player player);
        bool IsResolved { get; set; }

        int Health { get; set; }
        int AttackPower { get; }
        
        void Attack(Player player);
        void TakeDamage(int damage);
        bool IsDefeated { get; }
    }
}
