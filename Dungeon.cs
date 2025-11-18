public class Dungeon()
{
    public static void dungeonStart()
    {
        var health = 20;
        bool redo = false;
        Random rand = new Random();
        int randRoom = 0;

        Console.WriteLine("This is the start of the dungeon");
        do
        {
            Console.WriteLine("Do you want to enter? (y/n)");
            Console.WriteLine("");
            Console.Write(">> ");
            string answer = Console.ReadLine() + "";
            if (answer == "y")
            {
            
            }
            else if (answer == "n")
            {
            
            }
            else
            {
            
            }
        } while (true);
        

    }
    public static void dungeonRoom()
    {
        
    }
}