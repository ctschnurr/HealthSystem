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

        static int lives;

        static int hp;
        static int hpMax;
        static string healthStatus;

        static int sp;
        static int spMax;

        static string weaponName;

        static ConsoleKeyInfo choice;

        static int dice = 0;

        static void Main(string[] args)
        {
            
            gameName = "Health System v1.0";
            studioName = "Schnurr Studio";

            hp = 100;
            hpMax = 100;

            sp = 50;
            spMax = 50;

            healthStatus = "Perfect Health";

            weaponName = "Stick";


            int choice = 1;

            while (choice != 0)
            {
                ShowHud();
                Menu();               
            }

            Console.WriteLine("");
            Console.Write("Thank you for playing " + gameName + " By " + studioName);
            Pause();

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

        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("  (1) Run Tests");
            Console.WriteLine("");
            Console.WriteLine("  (0) Quit");
            Console.WriteLine("");

            Console.Write("Enter Choice: ");

            choice = Console.ReadKey(true);
            Console.WriteLine("");

            switch(choice.Key)
            {
                case ConsoleKey.D1:

                        Console.WriteLine("");
                        Console.WriteLine("DEBUG: Read input as '1', running tests for player stats.");             

                    Pause();

                    TakeDamage(dice);

                    break;
            }

        }

        static void Pause()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
            Console.WriteLine("");
        }

        

        static void TakeDamage(int damage)
        {
            if(damage < 0)
            {
                Console.WriteLine("ERROR: Negative number detected. Damage value must be positive. No action taken.");
            }

            else
            {
                
                if (debug == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("DEBUG: Checking if player is already dead or not. Current value for hp is " + hp + ". ");
               

                if (hp == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("The player is dead!");
                    Pause();
                }

                else
                {
                    if (debug == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("DEBUG: Check passed. Applying damage of " + damage + " to player. Current value for sp is " + sp);
                    }

                    if (sp < 1)
                    {
                        if (debug == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("DEBUG: Detected that shield is already depleted. Applying damage to hp");
                        }

                        hp = hp - damage;
                        Console.WriteLine("");
                        Console.Write("Player took " + damage + " damage!");
                        HealthStat();
                    }

                    else
                    {
                        sp = sp - damage;

                        if (sp < 1)
                        {
                            if (debug == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("DEBUG: Detected that shield is now depleted, value for sp is " + sp);
                            }

                            int spill = Math.Abs(sp);
                            sp = 0;

                            if (debug == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("DEBUG: Converted negative shield value to positive, and set sp to 0. SP = " + sp + ", Spill = " + spill + ". Applying spill to hp");
                            }

                            hp = hp - spill;
                            Console.WriteLine("");
                            Console.Write("Shield is depleted! Player took " + spill + " damage!");
                            HealthStat();

                        }

                    }

                    if (debug == true)
                    { 
                    Console.WriteLine("");
                    Console.WriteLine("DEBUG: Value for hp is now " + hp);
                    }

                    if (hp < 1)
                    {
                        if (debug == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("DEBUG: Death detected. Setting health to 0 to clear possible negative value and removing 1 life.");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Player has ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("DIED");
                        Console.ResetColor();
                        Console.WriteLine("!");
                        hp = 0;
                        lives = (lives - 1);

                        if (lives == -1)
                        {
                            if (debug == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("DEBUG: Out of lives detected. Setting lives to 0 to clear negative value.");
                            }

                            lives = 0;

                            Console.WriteLine("Press any key to continue");
                            Console.WriteLine("");
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Player is out of lives!");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("GAME OVER");
                            Console.ResetColor();
                            Console.WriteLine("!");
                            Console.WriteLine("");


                        }

                        Pause();
                    }
                }
            }
        }

        static void HealthStat()
        {
            healthStatus = "";

            if (hp == 100)
            {
                healthStatus = "Perfect Health";
            }

            if ((hp < 100) && (hp >= 75))
            {
                healthStatus = "Healthy";
            }

            if ((hp < 75) && (hp >= 50))
            {
                healthStatus = "Hurt";
            }

            if ((hp < 50) && (hp >= 10))
            {
                healthStatus = "Badly Hurt";
            }

            if ((hp < 10) && (hp > 0))
            {
                healthStatus = "Imminent Danger";
            }

            if (hp <= 0)
            {
                healthStatus = "DEAD";

            }
        }

    }

}
