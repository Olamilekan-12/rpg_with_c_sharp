namespace _01_CSharpFundamentals;

class Program
{
    static void Main(string[] args)
    {
        Player hero = new Player(name: "Aria", health: 100, level: 1, attackPower: 20, maxHealth: 100, potions: 3);
        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(new Enemy(name: "Goblin", health: 40, maxHealth: 40, attackPower: 50));
        enemies.Add(new Enemy(name: "Orc", health: 50, maxHealth: 50, attackPower: 7));
        enemies.Add(new Enemy(name: "Gollum", health: 20, maxHealth: 20, attackPower: 2));
        
        RunBattle(hero:hero, enemies: enemies);


    }

    static void RunBattle(Player hero, List<Enemy> enemies)
    {
        bool isValidChoice;

        foreach (Enemy enemy in enemies)
        {
            Console.WriteLine($"A wild {enemy.CharacterName} appears!");
            
            while (hero.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"{hero.CharacterName}: {hero.CurrentHealth}/{hero.MaxHealthValue} HP, {hero.AvailablePotions} {(hero.AvailablePotions > 1 ? "potions" : "potion")} left");
                Console.WriteLine($"Choose an action: attack, heal, potion: "); 
                string input = Console.ReadLine();
                bool success = Enum.TryParse(input, true, out PlayerAction action);
                if (success)
                {
                    switch (action)
                    {
                        case PlayerAction.Attack:
                            Console.WriteLine($"You chose to attack.");
                            hero.Attack(target: enemy);
                            break;
                        case PlayerAction.Heal:
                            Console.WriteLine($"You chose to heal.");
                            hero.Heal(amount:10);
                            break;
                        case PlayerAction.Potion:
                            Console.WriteLine($"You chose to use a potion");
                            hero.UsePotion();
                            break;
                    }
                    isValidChoice = true;
                }
                else
                {
                    Console.WriteLine($"Not a valid choice");
                    isValidChoice = false;

                }

        
                if (isValidChoice)
                {
                    enemy.Attack(target:hero);
                }

                if (!hero.IsAlive && enemy.IsAlive)
                {
                    Console.WriteLine($"{hero.CharacterName} dies at the hand of {enemy.CharacterName}");
                }
            
            }

            if (!hero.IsAlive)
            {
                break;
            }
      
        }
        
        if (hero.IsAlive)
        {
            Console.WriteLine($"{hero.CharacterName} wins");
        }else
        {
            Console.WriteLine("You lose");
        }
    }
}