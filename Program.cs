using System.Reflection.Metadata;

namespace Adventure_Game_Try_1;

class Program
{
    static void Main(string[] args)
    {
        bool redo = false;
        Console.WriteLine("------------------------------------");
        Console.WriteLine("         Adventure Game");

        do
        {
            // Title
            redo = false;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Instructions");
            Console.WriteLine("2) Play");
            Console.WriteLine("3) Exit");
            Console.Write(">> ");
            string pick = Console.ReadLine() + "";

            switch (pick)
            {
                case "1": // Going to Instruction
                    Console.WriteLine("------------------------------------");
                    direction(redo, pick);
                    redo = true;
                    break;

                case "2":  // Going to Play
                    Console.WriteLine("Welcome to the Adventure Game");
                    startGame(pick);
                    break;

                case "3":  // Going to Exit
                    redo = false;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Thanks for playing!"); 
                    break;

                default: // Wrong chioce go back to Title
                    Console.WriteLine("------------------------------------");
                    redo = true;
                    Console.WriteLine("THAT WAS NOT AN OPTION!!");

                    break;
            }
        } while (redo == true);
        


    }
    static void direction(bool redo, string pick)  //instrutions
    {
        do
        {
            redo = false;

            Console.WriteLine("   Instructions: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Type n to go North");
            Console.WriteLine(" Type e to go East");
            Console.WriteLine(" Type s to go South");
            Console.WriteLine(" Type w to go West");
            Console.WriteLine(" Type y/n for Yes and No");
            Console.WriteLine(" Also some will ask for numbers");
            Console.WriteLine("1) Exit");
            Console.Write(">> ");
            pick = Console.ReadLine() + "";
            if (pick == "1")
            {
                return;
            }
            else
            {
                redo = true;
                Console.WriteLine("");
                Console.WriteLine("THAT WAS NOT AN OPTION");
            }
        } while (redo == true);

    }
    static void startGame(string pick) // start of the game
    {
        string a = " ";
        string b = " ";
        string c = " ";
        string d = " ";
        string e = " ";
        string f = " ";
        string g = " ";
        string h = " ";
        string[] inventory = { };
        d = "X";
        do
        {
            Console.WriteLine("North of you is a giant steep mountain with a giant door,");
            Console.WriteLine("south of you is a ragging river, and west and east of you");
            Console.WriteLine("is all forest.");
            Console.WriteLine("Where would you like to do?");
            Console.WriteLine("1) Map");
            Console.WriteLine("2) Inventory");
            Console.WriteLine("");
            Console.Write(">> ");
            pick = Console.ReadLine() + "";

            switch (pick)
            {
                case "1":         // outsideMap
                    Console.WriteLine("");
                    outsideMap(a, b, c, d, e, f, g, h);

                    break;


                default:

                    break;
            }
        } while (true);
        
        

        

    }

    static void inventory(string[] inventory) // inventory
    {
        foreach (string item in inventory)
        {
            Console.WriteLine($" - {item}");
        }
    }

    static void outsideMap(string a, string b, string c, string d, string e, string f, string g, string h) // outside map
    {
        Console.WriteLine("---------------");
        Console.WriteLine($"|{a}|{b}|{c}|{d}|{e}|{f}|{g}|");
        Console.WriteLine("---------------");
        Console.WriteLine($"| |{h}| | | | | |");
        Console.WriteLine("---------------");
        //Console.WriteLine($"|{i}|{j}|{k}|{l}|{m}|{n}|{o}|");
        
        
    }
}









