namespace _01_CSharpFundamentals;

public class Player : Character
{
    //ADD NAME, HEALTH, LEVEL, ATTACK POWER, MAX_HEALTH.
    protected int Level;
    protected int Potions;
    
    public Player(string name, int health, int level, int attackPower, int maxHealth, int potions) : base(name,health,maxHealth,attackPower)
    {
        Level = level;
        Potions = potions;
    }

    public int AvailablePotions
    {
        get
        {
            return Potions;
        }
    }
    
    public void LevelUp()
    {
        Level = Level + 1;
        MaxHealth = MaxHealth + 10;
        AttackPower = AttackPower + 10;
        Health = MaxHealth;
        Console.WriteLine($"{Name} has levelled up to level {Level}");
        Console.WriteLine($"{Name} new health is {Health}");
        Console.WriteLine($"{Name} new max health is {MaxHealth}");
        Console.WriteLine($"{Name} new attack power is {AttackPower}");
    }

    public void UsePotion()
    {
        if (Potions >= 1)
        {
            Console.WriteLine($"{Name} drinks a potion");
            Heal(amount:10);
            Potions = Potions - 1;
        }
        else
        {
            Console.WriteLine($"No potion left!");
        }
    }
    
    
}