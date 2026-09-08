namespace _01_CSharpFundamentals;

public class Boss : Enemy
{
    public Boss(string name, int health, int maxHealth, int attackPower) : base(name, health, maxHealth, attackPower)
    {
        
    }

    public override void Die()
    {
        base.Die();
        Console.WriteLine($"The ground trembles as {Name} falls...!!!");
    }
}