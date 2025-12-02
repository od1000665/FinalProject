using System.Collections;
using Adventure_Game_Try_1;

public class Dungeon()
{

    public static void dungeonStart(out int roomsCleared, out int enemiesKilled)
    {
        string placeholder = ""; // placeHolder
        // Players health
        int health = 20;
        int enemiesKilledLocal = 0;
        int roomsClearedLocal = 0;
        int diceRoll = 0;
        bool redo = true;
        // Random  to make random rooms
        Random random = new Random();
        // Title of Dungeon start
        Console.WriteLine("------------------------------------");
        Console.WriteLine("  You are now in the dungeon");
        Console.WriteLine("------------------------------------");

        // Lists
        List<string> title = new List<string> { "Square Room", "Triagle Room", "Circle Room", "a Long Hallway"};
        List<string> roomDescribe = new List<string> { "The ground is made out of dirt with the walls are made out of rock", "It is small with a concrete ground and dirty walls", "The ground is made of creaky wood while the walls are made out of concrete"};
        List<string> enemyDescribe = new List<string> { "No Enemies", "a Goblin", "a Skeleton", "a Giant Rat", "a Moss Zombie", "a Gloom Orb"};

        roomsClearedLocal = 1;
        enemiesKilledLocal = 0;
        Console.WriteLine($"Room {roomsClearedLocal}");
        do
        {
            // To randomly make the title of the room
            int randTitleIndex = random.Next(title.Count);
            string randomTitle = title[randTitleIndex];
            // To randomly make the description of the room
            int randRoomIndex = random.Next(roomDescribe.Count);
            string randomRoomDescribe = roomDescribe[randRoomIndex];
            // To randomly make the description of the enemies
            int randEnemyIndex = random.Next(enemyDescribe.Count);
            string randomEnemyDescribe = enemyDescribe[randEnemyIndex];

            redo = true;
            // The UI of the room of the dungeon
            Console.WriteLine($"You have entered {randomTitle}");
            Console.WriteLine(randomRoomDescribe);
            Console.WriteLine($"There is {randomEnemyDescribe} in this room");

            do
            {
                // Tells you if there is an enemy or not
                if (randomEnemyDescribe == "No Enemies")
                {
                    Console.Write("Press Enter To Continue ");
                    placeholder = Console.ReadLine() + ""; // placeHolder
                    Console.WriteLine("------------------------------------");
                }
                // Enemy encounter
                else
                {
                    while (redo == true)
                    {
                        Console.WriteLine("Would you like to fight? (y/n)");
                        Console.Write(">> ");
                        string answer = Console.ReadLine() + "";
                        Console.WriteLine("------------------------------------");
                        // If you say "y" to fighting the enemy
                        if (answer == "y")
                        {
                            int enemy = 1;
                            while (enemy == 1)
                            {
                                // Random chance of killing the enemy
                                diceRoll = random.Next(1, 6);
                                Console.WriteLine($"  You rolled a {diceRoll}");
                                Console.WriteLine("------------------------------------");
                                // If you killed the enemy
                                if (diceRoll == 1 || diceRoll == 3 || diceRoll == 5)
                                {
                                    Console.WriteLine(" You killed the enemy");
                                    Console.WriteLine("------------------------------------");
                                    enemy = 0;
                                    ++enemiesKilledLocal;
                                }
                                // If you did not kill the enemy
                                else
                                {
                                    Console.WriteLine("  You missed and got attacked");
                                    --health;
                                    Console.WriteLine($"  You have {health} health left");
                                    if (health > 0)
                                    {
                                        Console.Write("Press Enter To Continue ");
                                        placeholder = Console.ReadLine() + ""; // placeHolder
                                        Console.WriteLine("------------------------------------");

                                    }
                                    else
                                    {
                                        redo = false;
                                        enemy = 2;
                                    }
                                    
                                    
                                }
                                
                            }
                            if (health == 20)
                            {
                                Console.WriteLine("It dropped nothing");
                                Console.Write("Press Enter To Continue");
                                placeholder = Console.ReadLine() + ""; // placeHolder  
                                Console.WriteLine("------------------------------------");
                            }
                            else
                            {
                                
                                if (diceRoll == 3)
                                {
                                    Console.WriteLine(" It dropped a health potion");
                                    diceRoll = random.Next(1, 2);
                                    Console.WriteLine($" It healed you for {diceRoll} health");
                                    health = health + diceRoll;
                                    Console.WriteLine($"  You have {health} health now");
                                    Console.Write("Press Enter To Continue");
                                    placeholder = Console.ReadLine() + ""; // placeHolder
                                }
                                else
                                {
                                    Console.WriteLine("It dropped nothing");
                                    Console.Write("Press Enter To Continue");
                                    placeholder = Console.ReadLine() + ""; // placeHolder  
                                    Console.WriteLine("------------------------------------");
                                }
                            }
                            
                            

                            redo = false;
                        }
                        // If you did not want to fight the enemy
                        else if (answer == "n")
                        {
                            // have a chance of taking from 0 - 3 damage by not wanting to
                            diceRoll = random.Next(0, 3);
                            Console.WriteLine($"You took {diceRoll} damage");
                            health = health - diceRoll;
                            Console.WriteLine($"You have {health} health left");
                            Console.Write("Press Enter To Continue ");
                            placeholder = Console.ReadLine() + ""; // placeHolder
                            Console.WriteLine("------------------------------------");
                            redo = false;
                        }
                        else
                        {
                            
                            Console.WriteLine("That was not an option");
                            Console.WriteLine("------------------------------------");

                        }
                    }

                }

                // Checking if room is cleared with greater than 0 health
                if (health > 0)
                {
                    
                    redo = false;
                    ++roomsClearedLocal;
                    Console.WriteLine($"Room {roomsClearedLocal}");
                }
                else
                {   
                    // you have lost
                    redo = false;
                }

            } while (redo == true);


        } while (health > 0);

        roomsCleared = roomsClearedLocal;
        enemiesKilled = enemiesKilledLocal;
    
    }
    
}