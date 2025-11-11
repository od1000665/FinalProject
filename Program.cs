using System.Reflection.Metadata;

namespace Adventure_Game_Try_1;

class Program
{
    static void Main(string[] args)
    {
        int playerHP = 20;
        int playerD = 1;
        bool redo = false;
        Console.WriteLine("------------------------------------");
        Console.WriteLine("         Adventure Game");

        do
        {
            redo = false;
            // Title
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Instructions");
            Console.WriteLine("3) Exit");
            Console.Write(">> ");
            string pick = Console.ReadLine() + "";
            switch (pick)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                default:

                    break;
            }

        } while (redo == true);

    }

    




    static void player(int playerHP, int playerD)
    {

        
    }
    
}



