namespace _01_CSharpFundamentals;

class Program
{
    static void Main(string[] args)
    {
        Player hero = new Player(name: "Aria", health: 100, level: 1, attackPower: 20, maxHealth: 100, potions: 3);
        Enemy enemy = new Enemy(name: "Goblin", health: 40, maxHealth: 40, attackPower: 5);
        bool isValidChoice;



        while (hero.IsAlive && enemy.IsAlive)
        {
            
            Console.WriteLine($"Choose an action: attack, heal, potion: ");
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "attack":
                    Console.WriteLine($"You chose to attack.");
                    hero.Attack(target: enemy);
                    isValidChoice = true;
                    break;
                case "heal":
                    Console.WriteLine($"You chose to heal.");
                    hero.Heal(amount:10);
                    isValidChoice = true;
                    break;
                case "potion":
                    Console.WriteLine($"You chose to use a potion");
                    hero.UsePotion();
                    isValidChoice = true;
                    break;
                default:
                    Console.WriteLine($"Not a valid choice");
                    isValidChoice = false;
                    break;
            }

            if (isValidChoice)
            {
                enemy.Attack(target:hero);
            }
            
        }

        if (hero.IsAlive)
        {
            Console.WriteLine($"{hero.CharacterName} wins");
        }
        else if (enemy.IsAlive)
        {
            Console.WriteLine($"{enemy.CharacterName} wins, You lose");
        }
        else
        {
            Console.WriteLine("Draw");
        }

    }
}