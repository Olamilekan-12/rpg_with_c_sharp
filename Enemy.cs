namespace _01_CSharpFundamentals;

public class Enemy : Character
{
    public Enemy(string name, int health, int maxHealth, int attackPower) : base(name, health, maxHealth, attackPower)
    {
        
    }

    public override void Die()
    {
        base.Die();
        Console.WriteLine($"{Name} drops loot.");
    }
}