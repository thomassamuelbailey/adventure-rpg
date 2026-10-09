using System;
public class Program
{
	public static void Main()
	{
    Console.WriteLine("Welcome Adventurer");

    Console.WriteLine("what is your name? ");
    var name = Console.ReadLine();
    Console.WriteLine("\nWelcome, " + name + "!");
    int health = 100;
    int gold = 0;
    Random random = new Random();
  //Loop      
    bool playing = true;
    while (playing)
    {
    Console.WriteLine("\n--------------------");
    Console.WriteLine("Health: " + health);
    Console.WriteLine("Gold: " + gold);
    Console.WriteLine("--------------------");
        
Console.WriteLine(" 1 = Forest");
Console.WriteLine(" 2 = Cave");
Console.WriteLine(" 3 = Town");
Console.WriteLine(" 4 = Quit");

    string choice = Console.ReadLine();
        
     if (choice == "1")
        {
        Console.WriteLine("You enter the forest.");
        Console.WriteLine("\nYou find a chest!");
        Console.WriteLine(" 1 = Open it");
        Console.WriteLine(" 2 = Ignore it");
        
        string forestChoice = Console.ReadLine();

        if (forestChoice == "1")
                {
                int encounter = random.Next(1, 8);

                if (encounter == 1)
                    {
                    Console.WriteLine("\nIt's a MIMIC!");
                    health -= 20;
                    Console.WriteLine("You take 20 damage!");
                        if (health <= 0)
                            {
                                health = 0;
                                Console.WriteLine("You died!");
                                playing = false;
                            }
                        
                    }
                else
                    {
                    int treasure = random.Next(1, 51);
            
                    Console.WriteLine("\nThe chest contains treasure!");
                    gold += treasure;
            
                    Console.WriteLine("You found " + treasure + " gold!");
                    }
                 }
        else if (forestChoice == "2")
        {
        Console.WriteLine("\nYou leave the chest alone.");
        }
            
        }
            
    else if (choice == "2")
        {
        Console.WriteLine("You enter the cave.");
                
                bool inCave = true;
                while (inCave)
                {
                        Console.WriteLine(" 1 = Explore");
                        Console.WriteLine(" 2 = Leave");

                        string caveChoice = Console.ReadLine();
                        if (caveChoice == "1")
                        {
                                Console.WriteLine("A goblin attacks!");
                                        Console.WriteLine("\n 1 = Fight");
                                        Console.WriteLine(" 2 = Flee");
                        
                                        string goblinChoice = Console.ReadLine();
                                                if (goblinChoice == "1")
                                                {
                                                        health -= 40;
                                                        if (health < 0)
{
    health = 0;
}

if (health <= 0)
{
    Console.WriteLine("You died!");
    playing = false;
    inCave = false;
}
                                                        gold += 50;
                                                        
                                                        Console.WriteLine("You killed the goblin");
                                                                          

                                                        Console.WriteLine("Health: " + health);
                                                        Console.WriteLine("Gold: " + gold);
                                                }
                                                else if (goblinChoice == "2")
                                                {
                                                       if (gold >= 15)
                                                       {
                                                                gold -= 15;
                                                                Console.WriteLine("you managed to escape. But the goblin swiped some gold from your pockets!");
                                                                Console.WriteLine("Health: " + health);
                                                                Console.WriteLine("Gold: " + gold);
                                                       }
                                                        else if (gold < 15)
                                                        {
                                                                health -= 15;
                                                                if (health < 0)
{
    health = 0;
}

if (health <= 0)
{
    Console.WriteLine("You died!");
    playing = false;
    inCave = false;
}
                                                                Console.WriteLine("you managed to escape. But the goblin hit you with a small attack!");
                                                                Console.WriteLine("Health: " + health);
                                                                Console.WriteLine("Gold: " + gold);
                                                        }
                                                                
                                                }
                        }

                        else if (caveChoice == "2")
                        { 
                                inCave = false;
                        }
                        else
                        {
                                Console.WriteLine("Invalid choice.");
                        }
                }
        }
            
    else if (choice == "3")
        {
            Console.WriteLine("You enter the town.");

            bool inTown = true;
            while (inTown)
            {
                    
                    Console.WriteLine("\n ====Town====");
                    Console.WriteLine("\n 1 = Talk to the villager");
                    Console.WriteLine(" 2 = Stare at the villager");
                	Console.WriteLine(" 3 = Visit Healer");
                    Console.WriteLine(" 4 = Leave");

                    string townChoice = Console.ReadLine();
                    if (townChoice == "1")
                        {
                        Console.WriteLine("She greets you with a smile \"Greetings newcomer, are you the adventurer Elron promissed would arrive today\"");
                      
                        }
                    else if (townChoice == "2")
                        {
                        Console.WriteLine("...");
                        gold += 5;
                        Console.WriteLine("\nShe has fear in her eyes, she throws you 5 gold coins");
                        Console.WriteLine("\"Please...it's all I have...\"");
                        Console.WriteLine("\nGain 5 gold");
                        }
                    else if (townChoice == "3")
                        {
                        Console.WriteLine("Your enter the local healer's shop");
                        Console.WriteLine(" 1 = Heal - Costs 50 Gold");
                        Console.WriteLine(" 2 = Leave");
                        string healerChoice = Console.ReadLine();
                    
                                if (healerChoice == "1")
                                {
                                    if (health == 100)
                                    {
                                        Console.WriteLine("You are already at full health!");
                                    }
                                    else if (gold >= 50)
                                    {
                                        health = 100;
                                        gold -= 50;
                                        Console.WriteLine("FULLY HEALED");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You don't have enough gold!");
                                    }
                                }   
                                else if (healerChoice == "2")
                                {
                                        Console.WriteLine("You leave the healers shop");
                                }
                                else 
                                {
                                        Console.WriteLine("Invalid choice.");
                                }
                        }
                            
                        else if (townChoice == "4")
                            {
                                inTown = false;
                            }
                 
                    else 
                        {
                        Console.WriteLine("Invalid choice.");
                        }
            }
        }
            
    else if (choice == "4")
        {
        Console.WriteLine("Goodbye!");
        playing = false;
        }
            
    else
        {
        Console.WriteLine("Invalid choice.");
        }
    if (health <= 0)
        {
        Console.WriteLine("You died!");
        playing = false;
        }
           
    }
    }
}
