using Dictionary.Characters;
using Dictionary.Characters.Characters_List;
using Dictionary.Enemies;
using Dictionary.Enemies.Enemies_List;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
        }

        static void Task1() 
        { 
            Dictionary<string, Character> charactersNames = new Dictionary<string, Character>();

            charactersNames["Vin"] = new VinDiesel();
            charactersNames["Ryan"] = new RyanGosling();
            charactersNames["Arnold"] = new ArnoldSchwarzenegger();

            foreach (KeyValuePair<string, Character> keyValuePair in charactersNames)
            {
                Console.WriteLine(keyValuePair.Key);
                keyValuePair.Value.Attack();
            }
        }

        static void Task2()
        {
            LinkedList<Enemy> enemies = new LinkedList<Enemy>();
            LinkedList<Enemy> dethEnemies = new LinkedList<Enemy>(); 

            Random random = new Random();

            enemies.AddLast(new Boss()
            {
                HP = random.Next(70, 201)
            });
            enemies.AddLast(new Minion()
            {
                HP = random.Next(19, 101)
            });
            enemies.AddLast(new Imposter()
            {
                HP = random.Next(49, 121)
            });

            while( dethEnemies.Count == 0 ) 
                {
                    foreach (Enemy enemy in enemies)
                    {
                        enemy.HP -= 2;
                        if ( enemy.HP <= 0 )
                    {
                        dethEnemies.AddLast(enemy);
                    }
                    }                    
                }

            Console.Write("Dead: ");
            foreach(Enemy enemy in dethEnemies)
            {
                Console.Write(enemy + " ");
            }
            Console.WriteLine();

            Enemy MaxHPEnemy = null;
            foreach (Enemy enemy in enemies)
            {
                if ( enemy.HP <= 0 )               
                    continue;                
                if(MaxHPEnemy == null)
                    MaxHPEnemy = enemy;
                else if( MaxHPEnemy.HP <= enemy.HP )
                    MaxHPEnemy = enemy;                
            }
            Console.WriteLine(MaxHPEnemy + ": " + MaxHPEnemy.HP);
        }
    }
}
