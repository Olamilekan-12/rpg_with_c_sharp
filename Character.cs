namespace _01_CSharpFundamentals;

public class Character
{
    protected string Name;
    protected int Health;
    protected int MaxHealth;
    protected int AttackPower;

    public Character(string name, int health, int maxHealth, int attackPower)
    {
        Name = name;
        Health = health;
        MaxHealth = maxHealth;
        AttackPower = attackPower;
    }

    public bool IsAlive
    {
        get
        {
            return Health > 0;
        }
    }

    public string CharacterName
    {
        get
        {
            return Name;
        }
    }

    public void TakeDamage(int amount)
    {
        if (IsAlive)
        {
            Health = Health - amount;
            if (Health <= 0)
            {
                Die();
                //Health = 0;
            }
            Console.WriteLine($"{Name} took {amount} damage. Health is now {Health}");
        }
    }

    public void Heal(int amount)
    {
        Health = Health + amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        Console.WriteLine($"{Name} healed {amount}. Health is now {Health}.");
    }

    public void Attack(Character target)
    {
        if (IsAlive && target.IsAlive)
        {
            Console.WriteLine($"{Name} attacks {target.Name}");
            target.TakeDamage(AttackPower);
        }

    }

    public virtual void Die()
    {
        Console.WriteLine($"{Name} has died.");
        Health = 0;
    }
}