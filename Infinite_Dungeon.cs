using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Adventure_Game_Try_1;

class Program
{
    static void Main(string[] args)
    {
        bool redo = false; // Redos
        bool redo1 = true;
        string answer = " ";
        Console.WriteLine("------------------------------------");
        Console.WriteLine("         The Infinite Dungeon");   // Title
    
        do
        {
            redo = true;
            redo1 = true;
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" What is your name?");
            Console.Write(">> ");
            string name = Console.ReadLine() + "";
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($" Is  {name}  right? (y/n)");
                Console.Write(">> ");
                answer = Console.ReadLine() + "";
                if (answer == "y")
                {
                    redo = false;
                    redo1 = false;
                }
                else if (answer == "n")
                {
                    redo1 = false;
                }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(" That is not an answer");
                }
            } while (redo1 == true);
            
            

 
        } while (redo == true);
       
        do
        {
            redo = false;
            
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" 1) Play");
            Console.WriteLine(" 2) Instructions");
            Console.WriteLine(" 3) Exit");
            Console.Write(">> ");
            answer = Console.ReadLine() + "";
            switch (answer)
            {
                case "1": // Play

                    Dungeon.dungeonStart();
                    Console.ReadKey();
                    break;

                case "2": // Instrutions
                    
                    Console.WriteLine("This is intructions");
                    redo = true;

                    break;

                case "3": // Exit

                    Console.WriteLine(" == Thanks For Playing ==");

                    break;

                default: // Will Redo The Entire Code 
                    redo = true;
                    Console.WriteLine(" That Was Not An Option!");

                    break;
            }

        } while (redo == true);


        

        Console.WriteLine("This is the end");








    }
}


