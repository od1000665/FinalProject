using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Adventure_Game_Try_1;

class Program
{
    static void Main(string[] args)
    {   // Redos
        bool redo = false; 
        bool redo1 = true;
        string answer = " ";
        Console.WriteLine("------------------------------------");
        // Title
        Console.WriteLine("         Dice Dungeon");  

 
        // Naming Yourself
        do
        {
            redo = true;
            redo1 = true;
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Enter your username?");
            Console.Write(">> ");
            string username = Console.ReadLine() + "";
            do
            {
                // Asking if it is correct
                Console.WriteLine("------------------------------------");
                Console.WriteLine($" Is  {username}  correct? (y/n)");
                Console.Write(">> ");
                answer = Console.ReadLine() + ""; 
                // Exit out of here if "y"
                if (answer == "y") 
                {
                    redo = false;
                    redo1 = false;
                }
                // Goes back to "Naming Yourself"
                else if (answer == "n")
                {
                    redo1 = false;
                }
                // Goes back to "Asking if it is correct"
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(" That is not an answer");
                }
            } while (redo1 == true);
        } while (redo == true);
       

        do
        {
            // Start of new game
            redo = false;
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" 1) Play");
            Console.WriteLine(" 2) Instructions");
            Console.WriteLine(" 3) Exit");
            Console.Write(">> ");
            answer = Console.ReadLine() + "";
            switch (answer)
            {   
                // Play
                case "1": 

                    Dungeon.dungeonStart();
                    Console.ReadKey();
                    break;
                // Instrutions
                case "2": 
                    
                    Console.WriteLine("This is intructions");
                    redo = true;

                    break;
                // Exit the game
                case "3": 

                    Console.WriteLine(" == Thanks For Playing ==");

                    break;
                // Will go back to the begining of the "Start of new game"
                default: 
                    redo = true;
                    Console.WriteLine(" That Was Not An Option!");

                    break;
            }

        } while (redo == true);

        Console.WriteLine("This is the end");
    }
}
