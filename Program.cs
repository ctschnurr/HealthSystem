using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static string gameName;
        static string studioName;

        static int hp;
        static int hpMax;
        static string healthStatus;

        static int sp;
        static int spMax;

        static string weaponName;
        static int weapon;
        static int medPack;

        static ConsoleKeyInfo choice;

        static string locationName;

        static void Main(string[] args)
        {

            gameName = "Health System v1.0";
            studioName = "Schnurr Studio";

            hp = 100;
            hpMax = 100;

            sp = 50;
            spMax = 50;

            healthStatus = "Perfect Health";
            weapon = 1;
            weaponName = "Stick";
            medPack = 25;

            Courtyard();

            Console.WriteLine("");
            Console.Write("Thank you for playing " + gameName + " By " + studioName);
            Pause();

        }
        static void Title()
        {
            Console.Clear();
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|  You are in the " + locationName.PadRight(73) + "|");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
        }
        static void ShowHud()
        {
            string hudHpMax = hpMax.ToString();
            string hudSpMax = spMax.ToString();

            Console.WriteLine("");
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|  SP: " + sp + "/" + hudSpMax.PadRight(5) + " HP: " + hp + "/" + hudHpMax.PadRight(7) + "Status: " + healthStatus.PadRight(17) + "  |     Weapon: " + weaponName.PadRight(20) + "|");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
            Console.WriteLine("");

        }

        static ConsoleKeyInfo MakeChoice()
        {
            Console.WriteLine("");
            Console.Write("Enter Choice: ");

            choice = Console.ReadKey(true);
            Console.WriteLine("");

            return choice;
        }

        static void Pause()
        {
            Console.ReadKey(true);
            Console.WriteLine("");
        }

        static void Courtyard()
        {
            locationName = "Courtyard";

            while (choice.Key != ConsoleKey.Q)
            {
                Title();

                Console.WriteLine("");
                Console.WriteLine("  (A)rena");
                Console.WriteLine("  (B)lacksmith");
                Console.WriteLine("  (H)ealer");
                Console.WriteLine("  (Q)uit");
                Console.WriteLine("");

                ShowHud();

                choice = MakeChoice();

                if (choice.Key == ConsoleKey.A)
                {
                    Arena();
                }

    //            if (choice.Key == ConsoleKey.B)
    //            {
    //                Blacksmith();
    //            }
    //
    //            if (choice.Key == ConsoleKey.H)
    //            {
    //                Healer();
    //            }

                
            }
            
        }

        static void Arena()
        {
            locationName = "Arena";

            while (choice.Key != ConsoleKey.R)
            {
                Title();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" (F)ight");
                Console.WriteLine(" (R)eturn to Courtyard");
                Console.WriteLine("");
                Console.WriteLine("");

                ShowHud();

                choice = MakeChoice();

                if (choice.Key == ConsoleKey.F)
                {
                    Battle();
                }
            }
        }

        static void Battle()
        {
            int baddieHP = 10;


            Console.Clear();
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|  You are in battle!                                                                      |");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
            Pause();
        }

        
    }
}
