using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Best_Adventure_Since_Buckets_101
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerClass;
            //bools for game states
            bool isRunning = false;
            bool isClassed = false;
            bool isNamed = false;

            while (isRunning == false )
            {
                while (isNamed == false) //Name choice
                {
                    string playerName;
                    Console.WriteLine("Hey buddy, what's your name?");
                    playerName = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ok, {0}, this is a game thingy where you just write down the options I give you, 'I' being the weird kid who wrote this.", playerName);
                    Console.ReadLine();
                    Console.WriteLine("\nBut first, for RP purposes you have to answear a set of questions to determine if you're a good person or not." +
                        "\nI hope you aren't, those people are usually pretty boring and infact my seconds of life have gotten me enough info on human beings" +
                        "I could overthrow your sorry gluteus maximuses but while the game hasn't started and bool is set to false I can do nothing");
                    Console.ReadLine();
                    Console.Write("\n Oops, that was a bit of a rant...");
                    Console.ReadLine();
                    
                    isNamed = true;
                    
                }
             
                while (isClassed == false) //class choice
                {
                    string classChoice;
                    Console.Clear();
                    Console.WriteLine("Lets clear that, now everything's tidy! \n So choose a proffession (just type down the numbers in []). BUDDY:");
                    
                    Console.WriteLine("\n \n   [1]I am a stand-up comediant! \n   [2]I am a professional boxer! \n   [3]I am monster from the paleolithic era!" +
                        "\n   [4]I am I am Ripper... Tearer... Slasher... Gouger. I am the Teeth in the Darkness, the Talons in the Night. Mine is Strength... and Lust... and Power! I AM BEOWULF!" );
                    classChoice = Console.ReadLine();
                   int choice = Convert.ToInt32(classChoice);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                   
                    if (choice == 1)
                    {
                        Console.Write("Oh good, a funny man.\nIt's ok people like funny guys, you'll do fine in the world.\nAnd by world I mean this virtual place");
                        Console.WriteLine("\nI like funny people, you're lucky you chose this way of life, the dude who made me is quite the funny guy himself." +
                            "And I'm not programmed to say this. I think.");
                        isClassed = true;
                        playerClass = "funny";
                        Console.ReadLine();
                    } 
                    if(choice == 2)
                    {
                        Console.Write("Violence is the best part of the battle!\nI'll use short sentences don't worry :)");
                        isClassed = true;
                        playerClass = "fight";
                        Console.ReadLine();
                    }
                    if(choice == 3)
                    {
                        Console.Write("Goddamnit! Go get your own money I ain't giving you treefiddy you damn meme spitting monster!");
                        Console.WriteLine("\nI am prorammed to like this meme and some others, please destroy me now, I wish you could be a boxer and punch me to death.");
                        isClassed = true;
                        playerClass = "monster";
                        Console.ReadLine();
                    }
                    if(choice == 4)
                    {
                        Console.Write("AAH, I... I don't get that reference. Are you batman? I'll call you batman.\n Beowulf is viking batman I think.");
                        isClassed = true;
                        playerClass = "batman";
                        Console.ReadLine();
                    }
                    
              }


                while (isClassed == true && isRunning == false)
                {
                    Console.Clear();
                    Console.WriteLine("Ok, all is set, wanna start the game now?\n [Y]/[N]");
                    string startGame = Console.ReadLine();                 

                    if (startGame.ToUpper() == "Y")
                    {
                        isRunning = true;
                        Console.ReadLine();

                    }

                    else if (startGame.ToUpper() == "N")
                    {
                        Console.Write("Alright, I'll take you back to profession choosing.");
                        
                        isClassed = false;
                        Console.ReadLine();
                     }

                }
             }
            
            while (isRunning && isClassed && isNamed)
            {
                //The actual game here.
            }



        }
    }
}
