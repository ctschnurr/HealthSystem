using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static bool debug = true;

        static string gameName;
        static string studioName;

        static int lives;
        static int deaths;

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

            sp = 100;
            spMax = 100;

            lives = 3;
            deaths = 0;

            healthStatus = "Perfect Health";

            weaponName = "Stick";
              

            while (choice.Key != ConsoleKey.D0)
            {
                Menu();
            }

            Console.WriteLine("");
            Console.Write("Thank you for playing " + gameName + " By " + studioName);
            Pause();

        }

        static void ShowHud()
        {
            string hudhp = hp.ToString();
            string hudsp = sp.ToString();

            string hudHpMax = hpMax.ToString();
            string hudSpMax = spMax.ToString();

            Console.WriteLine("");
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|       SP: " + hudsp.PadRight(3) + "/" + hudSpMax.PadRight(9) + " HP: " + hudhp.PadRight(3) + "/" + hudHpMax.PadRight(12) + "Status: " + healthStatus.PadRight(21) + " Lives: " + lives + "       |");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
            Console.WriteLine("  |                                                                                      |");
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|       XP: 0 / 1000        Level: 1          Potions: 3          Deaths: " + deaths + "                |");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
            Console.WriteLine("");

        }

        static void Title()
        {
            // Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  .------------------------------------------------------------------------------------------.");
            Console.WriteLine("  |  Health System                                                         by Chris Schnurr  |");
            Console.WriteLine("  '------------------------------------------------------------------------------------------'");
        }

            static void Menu()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Title();

            Console.WriteLine("");
            Console.WriteLine("      (1) Run TakeDamage Method Tests");
            Console.WriteLine("      (2) Run Heal Method Tests");
            Console.WriteLine("      (3) Toggle Debug notes in Tests");
            Console.WriteLine("      (0) Quit");
            Console.WriteLine("");


            Console.WriteLine("  .------------------------------------------------------------------------------------------.");
            Console.WriteLine("  |                                                                                          |");
            Console.WriteLine("  '------------------------------------------------------------------------------------------'");
            Console.WriteLine("");
            Console.ResetColor();

            Console.Write("Enter Choice: ");

            choice = Console.ReadKey(true);
            Console.WriteLine("");

            switch (choice.Key)
            {
                case ConsoleKey.D1:

                    Reset();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 1: 50 damage input to test shield depletion.");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(50);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 2: Now we will apply 75 damage to test shield");
                    Console.WriteLine(" depletion to 0 and spill to health.");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(75);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 3: Now we will apply 80 damage to test health");
                    Console.WriteLine(" depletion to 0 and reduction in life points.");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(80);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 4: Next we will apply 110 damage a few times");
                    Console.WriteLine(" to deplete lives beyond 0.");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(110);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 4 continued: Applying 110 again");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(110);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 4 continued: And once more to show Game Over");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(110);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 5: Now if we try to pass 10 damage into TakeDamage:");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(10);

                    ShowHud();

                    Pause();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Running TakeDamage Method Tests:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(" Test 6: Finally we'll pass -10 as damage");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    Pause();

                    ShowHud();

                    TakeDamage(-10);

                    ShowHud();

                    Pause();

                    break;

                case ConsoleKey.D2:
                                    

                    break;

                case ConsoleKey.D3:

                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Debug notes now OFF");
                        Console.ResetColor();
                        debug = false;
                    }

                    else if (debug == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Debug notes now ON");
                        Console.ResetColor();
                        debug = true;

                    }


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
            if (damage < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ERROR: Negative number detected. Damage value must be positive. No action taken.");
                Console.ResetColor();
            }

            else
            {

                if (debug == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("DEBUG: Checking if player is already dead or not. Current value for hp is ");
                    Console.ResetColor();
                    Console.WriteLine(hp);
                }

                if (hp == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The player is dead!");
                    Console.WriteLine("");

                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Player is dead, no further action to take.");
                        Console.ResetColor();

                    }
                }

                else if (hp > 0)
                {
                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("DEBUG: Check passed. Applying damage of ");
                        Console.ResetColor();
                        Console.Write(damage);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" to player. Current value for sp is ");
                        Console.ResetColor();
                        Console.WriteLine(sp);
                    }


                    if (sp > 0)
                    {
                        sp = sp - damage;

                        if (sp < 1)
                        {
                            if (debug == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("DEBUG: Detected that shield is now depleted, value for SP is ");
                                Console.ResetColor();
                                Console.WriteLine(sp);
                            }

                            int spill = Math.Abs(sp);
                            sp = 0;

                            if (debug == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("DEBUG: Converted negative shield value to positive and set to spill. Set sp to 0");
                                Console.Write("       SP = ");
                                Console.ResetColor();
                                Console.Write(sp);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" Spill = ");
                                Console.ResetColor();
                                Console.Write(spill);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(". Applying spill to hp");
                                Console.ResetColor();
                            }

                            hp = hp - spill;
                            Console.WriteLine("");
                            Console.Write("Shield is depleted! Player took " + spill + " damage!");
                            Console.WriteLine("");
                            HealthStat();

                        }

                        else if (sp > 0)
                        {
                            if (debug == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("DEBUG: Detected that player has enough shield points . Applying damage of ");
                                Console.ResetColor();
                                Console.Write(damage);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(" to shield.");
                                Console.ResetColor();
                            }
                            Console.WriteLine("");
                            Console.Write("Shield took " + damage + " damage!");
                            Console.WriteLine("");
                        }

                    }

                    else if (sp < 1)
                    {
                        if (debug == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("DEBUG: Detected that shield is already depleted. Applying damage of ");
                            Console.ResetColor();
                            Console.Write(damage);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" to hp");
                            Console.ResetColor();
                        }

                        hp = hp - damage;
                        Console.WriteLine("");
                        Console.WriteLine("Player took " + damage + " damage!");
                        Console.WriteLine("");
                        HealthStat();

                        if (debug == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("DEBUG: Rechecking if player is dead. Hp is ");
                            Console.ResetColor();
                            Console.WriteLine(hp);
                        }

                        if (hp < 1)
                        {
                            Console.WriteLine("");
                            Console.Write("Player has ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("DIED");
                            Console.ResetColor();
                            Console.WriteLine("!");
                            Console.WriteLine("");

                            lives = lives - 1;
                            deaths = deaths + 1;

                            if (debug == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("DEBUG: Removed 1 Life");
                                Console.ResetColor();
                            }

                            if (lives == -1)
                            {
                                if (debug == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("DEBUG: Negative number detected for Life (game over). Setting lives and hp to 0 to clear negative values.");
                                    Console.ResetColor();
                                }

                                lives = 0;
                                hp = 0;

                                Console.WriteLine("");
                                Console.WriteLine("Player is out of lives!");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("GAME OVER");
                                Console.ResetColor();
                                Console.WriteLine("!");

                            }

                            else if (lives >= 0)
                            {
                                if (debug == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("DEBUG: Player had a Life remaining, resetting hp to 100.");
                                    Console.ResetColor();
                                }

                                hp = hpMax;
                                HealthStat();

                            }
                        }
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

        static void Reset()
        {
            Console.WriteLine("");
            Console.WriteLine("Stats have been reset.");
            Console.WriteLine("");

            hp = 100;
            hpMax = 100;

            sp = 100;
            spMax = 100;

            lives = 3;
            deaths = 0;

            healthStatus = "Perfect Health";
        }

    }
}
