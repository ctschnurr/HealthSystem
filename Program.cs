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
        static int testval;
        static string testName;
        static string testMessage1;
        static string testMessage2;

        static string gameName;
        static string studioName;

        static int lives;
        static int deaths;

        static int health;
        static int healthMax;
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

            health = 100;
            healthMax = 100;

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
            string hudhp = health.ToString();
            string hudsp = sp.ToString();

            string hudHpMax = healthMax.ToString();
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
            Console.WriteLine("      (3) Run RegenerateShield Method Tests");
            Console.WriteLine("      (9) Toggle Debug notes in Tests");
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

                    Console.Clear();

                    Reset();

                    testName = "TakeDamage";

                    testval = 50;

                    testMessage1 = "Applying " + testval + " damage input to test shield depletion.";
                    testMessage2 = null;

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testval = 75;

                    testMessage1 = "Test 2: Now we will apply " + testval + " damage to test shield";
                    testMessage2 = null;

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testval = 80;

                    testMessage1 = "Test 3: Now we will apply " + testval + " damage to test health";
                    testMessage2 = "depletion to 0 and reduction in life points.";

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testval = 110;

                    testMessage1 = "Test 4: Next we will apply " + testval + " damage a few times";
                    testMessage2 = "to deplete lives beyond 0.";

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testMessage1 = "Test 4 continued: Applying " + testval + " again.";
                    testMessage2 = null;

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testMessage1 = "Test 4 continued: And once more to show Game Over.";
                    testMessage2 = null;

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();
                    
                    testval = 10;

                    testMessage1 = "Test 5: Now if we try to pass " + testval + " damage into TakeDamage:";
                    testMessage2 = null;

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();
                    Pause();

                    testval = -10;

                    testMessage1 = "Test 6: Now applying " + testval + "damage";
                    testMessage2 = "to test error checking.";

                    testFrame();

                    ShowHud();
                    TakeDamage(testval);
                    ShowHud();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tests complete.");
                    Console.ResetColor();

                    Pause();

                    break;

                case ConsoleKey.D2:

                    Console.Clear();

                    Reset();

                    testName = "Heal";

                    health = 1;
                    HealthStat();
                    testval = 60;

                    testMessage1 = "Test 1: I have reduced player's Hit Points to 1.";
                    testMessage2 = "Applying " + testval + " health input to test healing.";

                    testFrame();

                    ShowHud();
                    Heal(testval);
                    ShowHud();
                    Pause();

                    testMessage1 = "Test 2: Applying another " + testval + " health input.";
                    testMessage2 = "to test range clamping of Hit Points to Max Health.";

                    testFrame();

                    ShowHud();
                    Heal(testval);
                    ShowHud();
                    Pause();

                    testMessage1 = "Test 3: Applying another " + testval + " health input.";
                    testMessage2 = "to test reaction to Hit Points already being full.";

                    testFrame();

                    ShowHud();
                    Heal(testval);
                    ShowHud();
                    Pause();

                    testval = -10;

                    testMessage1 = "Test 4: Now applying " + testval + " health input.";
                    testMessage2 = "to test to test error checking.";

                    testFrame();

                    ShowHud();
                    Heal(testval);
                    ShowHud();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tests complete.");
                    Console.ResetColor();

                    Pause();

                    break;

                case ConsoleKey.D3:

                    Console.Clear();

                    Reset();

                    testName = "RegenerateShield";
                    sp = 1;
                    testval = 60;

                    testMessage1 = "Test 1: I have reduced player's Shield Points to 1.";
                    testMessage2 = "Applying " + testval + " Shield Regen input to test shield restore.";

                    testFrame();

                    ShowHud();
                    RegenerateShield(testval);
                    ShowHud();
                    Pause();

                    testMessage1 = "Test 2: Applying another " + testval + " Sheild Regen input";
                    testMessage2 = "to test range clamping of Shield Points to Max Shield.";

                    testFrame();

                    ShowHud();
                    RegenerateShield(testval);
                    ShowHud();
                    Pause();

                    testval = -10;

                    testMessage1 = "Test 3: Now applying " + testval + " health input to test error checking";
                    testMessage2 = "";

                    testFrame();

                    ShowHud();
                    RegenerateShield(testval);
                    ShowHud();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tests complete.");
                    Console.ResetColor();

                    break;

                case ConsoleKey.D9:

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

        static void testFrame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.Write("Running ");
            Console.ResetColor();
            Console.Write(testName);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Method Tests:");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" " + testMessage1);
            if (testMessage2 == null)
            {

            }
            else if (testMessage2 != null)
            {
                Console.WriteLine(" " + testMessage2);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ResetColor();
            Pause();
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
                    Console.WriteLine(health);
                }

                if (health == 0)
                {
                    Console.WriteLine("The player is dead!");

                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Player is dead, no further action to take.");
                        Console.ResetColor();

                    }
                }

                else if (health > 0)
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

                            health = health - spill;
                            Console.Write("Shield is depleted! Player took " + spill + " damage!");
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
                            Console.Write("Shield took " + damage + " damage!");
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

                        health = health - damage;
                        Console.WriteLine("Player took " + damage + " damage!");
                        HealthStat();

                        if (debug == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("DEBUG: Rechecking if player is dead. Hp is ");
                            Console.ResetColor();
                            Console.WriteLine(health);
                        }

                        if (health < 1)
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
                                health = 0;

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

                                health = healthMax;
                                HealthStat();

                            }
                        }
                    }                   
                }
            }
        }

        static void Heal(int hp)
        {
            int healToMax;
            healToMax = healthMax - health;

            if (hp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ERROR: Negative number detected. Heal value must be positive. No action taken.");
                Console.ResetColor();
            }

            else if (health == healthMax)
            {
                if (debug == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("DEBUG: Detected that hp are already full. No action taken.");
                    Console.ResetColor();
                }

                Console.WriteLine("Hit Points are already full!");
            }

            else
            {
                if (hp > healToMax)
                {
                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Detected that heal value is greater than amount needed to full health.");
                        Console.WriteLine("Setting hp to max and disregarding rest.");
                        Console.ResetColor();
                    }

                    health = healthMax;
                    HealthStat();

                    Console.WriteLine("Healed " + healToMax + " Hit Points!");
                }

                else
                {
                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Detected that heal value is less than amount needed to full health. Adding heal value to hp.");
                        Console.ResetColor();
                    }

                    health = health + hp;
                    HealthStat();

                    Console.WriteLine("Healed " + hp + " Hit Points!");
                }
            }
        }

        static void RegenerateShield(int hp)
        {
            int shieldToMax;
            shieldToMax = spMax - sp;

            if (hp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ERROR: Negative number detected. Shield Regen value must be positive. No action taken.");
                Console.ResetColor();
            }

            else if (sp == spMax)
            {
                if (debug == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("DEBUG: Detected that sp are already full. No action taken.");
                    Console.ResetColor();
                }

                Console.WriteLine("Shield Points are already full!");
            }

            else
            {
                if (hp > shieldToMax)
                {
                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Detected that Shield Regen value is greater than amount needed to full shield.");
                        Console.WriteLine("Setting sp to max and disregarding rest.");
                        Console.ResetColor();
                    }

                    sp = spMax;

                    Console.WriteLine("Restored " + shieldToMax + " Shield Points!");
                }

                else
                {
                    if (debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DEBUG: Detected that Shield Regen value is less than amount needed to full shield. Adding Shield Regen value to sp.");
                        Console.ResetColor();
                    }

                    sp = sp + hp;

                    Console.WriteLine("Restored " + hp + " Shield Points!");
                }
            }
        }

        static void HealthStat()
        {
            healthStatus = "";

            if (health == 100)
            {
                healthStatus = "Perfect Health";
            }

            if ((health < 100) && (health >= 75))
            {
                healthStatus = "Healthy";
            }

            if ((health < 75) && (health >= 50))
            {
                healthStatus = "Hurt";
            }

            if ((health < 50) && (health >= 10))
            {
                healthStatus = "Badly Hurt";
            }

            if ((health < 10) && (health > 0))
            {
                healthStatus = "Imminent Danger";
            }

            if (health <= 0)
            {
                healthStatus = "DEAD";

            }
        }

        static void Reset()
        {
            Console.WriteLine("");
            Console.WriteLine("Stats have been reset.");
            Console.WriteLine("");

            health = 100;
            healthMax = 100;

            sp = 100;
            spMax = 100;

            lives = 3;
            deaths = 0;

            healthStatus = "Perfect Health";
        }

    }
}
