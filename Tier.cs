using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Programm
{
    internal class Tier
    {
        internal string name;
        internal int old;
        internal string color;
        internal string gender;
        internal string mood;
        internal int peopleEaten;
        internal string alive;
        internal string theWay;

        public Tier(string name, int old, string color, string gender, string mood, int peopleEaten, string alive, string theWay)
        {
            this.name = name;
            this.old = old;
            this.color = color;
            this.gender = gender;
            this.mood = mood;
            this.peopleEaten = peopleEaten;
            this.alive = alive;
            this.theWay = theWay;
        }

        public void Details()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe {name} should be {old} years old. It is a {color} {gender}, usually {mood}. It has eaten {peopleEaten} people so far. If you really wish to know its status, this creature is {alive}.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n\nPress ENTER to reset the program.\nNO you are not allowed to exit it! You are forever stuck here, with this friendly AI. <3");
            Console.ReadLine();
        }

        public void Indications()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n{theWay}\nWhat, not happy?");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n\nPress ENTER to reset the program.\nNO you are not allowed to exit it! You are forever stuck here, with this friendly AI. <3");
            Console.ReadLine();
        }
        public static void Start()
        {
            // Without this you will never see the Trademark xD
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Variables
            bool check;
            string choice;
            string secondChoice;

            // Instances from class Tier
            Tier t1 = new Tier("whale", 15, "gray", "female", "peaceful", 0, "alive, but struggling like a fish on land", "You walk straight forward until you realise you're not in an ocean and there's no way we can have a whale WITHOUT AN OCEAN!");
            Tier t2 = new Tier("eagle", 47, "brown", "unknown", "angry", 0, "dead, shot by vegans", "Check this out. You first grow yourself a pair of wings, then SEARCH YOURSELF AN EAGLE!");
            Tier t3 = new Tier("worm", 7, "pink", "neutral", "lonely", 25, "alive, probably", "Quite simple. Look under YOUR FOOT.");
            Tier t4 = new Tier("goose", 5, "blue", "male", "angry", 2, "alive.. or not alive.. who cares?", "You walk until you see a shopping centre on your right. Go inside and buy yourself a mirror. Aftewards you go outside, look at what you've wasted money on and VOILE, YOU GOT YOUR GOOSE.");
            Tier t5 = new Tier("goat", 30, "black & white", "hermaphrodite", "depressive", 7, "barely hanging on", "Search Messi or Ronaldo on Google. Then you'll have your GOAT.");

            // Menu information booth forever loop

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n[....... [..    [....         [....          [.......  [.......        [....        [....   [.......          [.       [..       [..[..       [..\r\n       [..    [..    [..    [..    [..       [..    [..[..    [..    [..    [..   [.    [.. [..    [..       [. ..     [. [..   [...[. [..   [...\r\n      [..   [..        [..[..        [..     [..    [..[..    [..  [..        [..[..        [..    [..      [.  [..    [.. [.. [ [..[.. [.. [ [..\r\n    [..     [..        [..[..        [..     [.......  [. [..      [..        [..[..        [. [..         [..   [..   [..  [..  [..[..  [..  [..\r\n   [..      [..        [..[..        [..     [..       [..  [..    [..        [..[..   [....[..  [..      [...... [..  [..   [.  [..[..   [.  [..\r\n [..          [..     [..   [..     [..      [..       [..    [..    [..     [..  [..    [. [..    [..   [..       [.. [..       [..[..       [..\r\n[...........    [....         [....          [..       [..      [..    [....       [.....   [..      [..[..         [..[..       [..[..       [..\r\n                                                                                                                                                 \r\n");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n\nWelcome to the massacre of animals that could have been free, but instead are here for your own amusament. FeelsGoodMan™");
                do
                {
                    check = true;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nChoose one of our magnifique captive pieces of meat by typing its name.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWhale");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Eagle");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Worm");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Goose");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Goat\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    choice = Console.ReadLine().ToLower();

                    if (choice == "whale")
                    {
                        do
                        {
                            check = true;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWould you like to know some juicy details about the {choice}? Or would you rather just know how to get to it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDetails");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Indications\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            secondChoice = Console.ReadLine().ToLower();
                            if (secondChoice == "details")
                            {
                                t1.Details();
                            }
                            else if (secondChoice == "indications")
                            {
                                t1.Indications();
                            }
                            else
                            {
                                Console.Clear();
                                check = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Hard to type one word correclty, ain't it?");
                            }
                        } while (check == false);
                    }
                    else if (choice == "eagle")
                    {
                        do
                        {
                            check = true;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWould you like to know some juicy details about the {choice}? Or would you rather just know how to get to it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDetails");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Indications\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            secondChoice = Console.ReadLine().ToLower();
                            if (secondChoice == "details")
                            {
                                t2.Details();
                            }
                            else if (secondChoice == "indications")
                            {
                                t2.Indications();
                            }
                            else
                            {
                                Console.Clear();
                                check = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Hard to type one word correclty, ain't it?");
                            }
                        } while (check == false);
                    }
                    else if (choice == "worm")
                    {
                        do
                        {
                            check = true;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWould you like to know some juicy details about the {choice}? Or would you rather just know how to get to it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDetails");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Indications\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            secondChoice = Console.ReadLine().ToLower();
                            if (secondChoice == "details")
                            {
                                t3.Details();
                            }
                            else if (secondChoice == "indications")
                            {
                                t3.Indications();
                            }
                            else
                            {
                                Console.Clear();
                                check = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Hard to type one word correclty, ain't it?");
                            }
                        } while (check == false);
                    }
                    else if (choice == "goose")
                    {
                        do
                        {
                            check = true;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWould you like to know some juicy details about the {choice}? Or would you rather just know how to get to it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDetails");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Indications\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            secondChoice = Console.ReadLine().ToLower();
                            if (secondChoice == "details")
                            {
                                t4.Details();
                            }
                            else if (secondChoice == "indications")
                            {
                                t4.Indications();
                            }
                            else
                            {
                                Console.Clear();
                                check = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Hard to type one word correclty, ain't it?");
                            }
                        } while (check == false);
                    }
                    else if (choice == "goat")
                    {
                        do
                        {
                            check = true;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWould you like to know some juicy details about the {choice}? Or would you rather just know how to get to it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDetails");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Indications\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            secondChoice = Console.ReadLine().ToLower();
                            if (secondChoice == "details")
                            {
                                t5.Details();
                            }
                            else if (secondChoice == "indications")
                            {
                                t5.Indications();
                            }
                            else
                            {
                                Console.Clear();
                                check = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Hard to type one word correctly, ain't it?");
                            }
                        } while (check == false);
                    }
                    else
                    {
                        Console.Clear();
                        check = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Make sure you've typed the chosen one's name right. This Zoo's got only 5 creatures. Blame the vegan protestants.\n\n");
                    }
                } while (check == false);
            }
        }
    }
}
