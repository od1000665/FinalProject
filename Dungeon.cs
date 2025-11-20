public class Dungeon()
{
    public static void dungeonStart()
    {
        // Players health
        int health = 20;

        bool redo = false;
        // Random  to make random rooms
        Random random = new Random();
        int randRoom = 0;
        // Title of Dungeon start
        Console.WriteLine("------------------------------------");
        Console.WriteLine(" You have entered the dungeon");

        //
        string[] title = {"t", "s", "e"};
        string[] roomDescription = {""};
        string[] enemyDescription = {""};
        int roomCleared = 0;
        int enemiesKilled = 0;
        


        do
        {
            title = random.Next(0, 3);
           






        } while (health > 0);

    }










}