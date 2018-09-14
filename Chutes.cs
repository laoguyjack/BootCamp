using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P3
{
    // Jack Savath
    // p3.cs

    class Chutes
    {
        static void Welcome()
        {
            // This method is the welcome message to the program

            Console.WriteLine("\n\nWelcome to my virtual version of the classical game");
            Console.WriteLine("Chutes and Ladders. The object of the game is to get to");
            Console.WriteLine("the 100th square before anyone else. Use ladders to get you");
            Console.WriteLine("there quicker. However, try to avoid chutes as they'll set");
            Console.WriteLine("you back a couple of spaces. Let's get started!");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static int[] BoardSetup()
        {
            StreamReader f;
            String line;
            int index, value;           // variable used to read over strings from the file
            int sizeOfgame = 101;       // size of the boardgame
            int[] offSet = new int[sizeOfgame]; // array to store the values of the offset 

            if (!File.Exists(PATH))
            {
                Console.Write("File problem, exiting program....");
            }
            else
            {
                f = new StreamReader(PATH);
                while ((line = f.ReadLine()) != null)
                {
                    String[] strings = line.Split();
                    if (strings.Length == 2)
                    {
                        index = int.Parse(strings[0]);
                        value = int.Parse(strings[1]);
                        offSet[index] = value;
                    }
                }
                f.Close();
            }
            return offSet;

        }
        static String[] PlayerSetup(int x)
        {
            // This method assigns the names of each player into an array

            String[] players = new string[x];
            int[] currentPosition = new int[x];
            for (int j = 0; j < x; j++)
            {
                Console.Write("Enter the name of Player {0}: ", j + 1);
                players[j] = Console.ReadLine();
            }
            return players;
        }

        static int spin()
        {
            // This method is the spinner of the BoardGame

            const int MIN = 1;          // the minimum value the spin can be
            const int MAX = 6;        // the maximum value the spin can be
            int spinNum;                    // the spin number
            Random r = new Random();
            spinNum = r.Next(MIN, MAX + 1);
            return spinNum;
        }

        static void Goodbye()
        {
            // This method ends the program with a goodbye message

            Console.WriteLine("\n\nThank You for playing Chutes and Ladders. I hope it was");
            Console.Write("enjoyable. See you next time!");
            Console.ReadLine();
        }

        const string PATH = "p3input.txt"; // This is the file that containes the offset to the board game
        static void Main(string[] args)
        {

            int numberOfPlayers;        // the number of players to play the game
            int[] currentPosition;      // array to store the position of each player
            string[] player;            // an array to store the names of the players playing
            int[] boardGame;            // an array of the virtual board game

            int playerTurn = 0;         // counter to track of who's turn it is
            int squareLanded = 0;       // the square that the player has landed on after the spin
            int endPos = 0;             // the final position after checking for chutes and ladders
            int nowPos = 0;             // the position the player is at before the spin

            const char YES = 'y';
            char answer = 'y';

            Welcome();
            boardGame = BoardSetup();

            while (answer == YES)
            {
                Console.Write("\n\nHow many players will be playing Chutes and Ladders (2-6)? ");
                numberOfPlayers = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                player = PlayerSetup(numberOfPlayers);
                currentPosition = new int[numberOfPlayers];

                Console.WriteLine("\n\nGreat! Now Let's Begin!\n\n");

                playerTurn = 0;
                endPos = 0;
                nowPos = 0;

                while (endPos != 100)
                {
                    if (playerTurn > numberOfPlayers - 1)
                        playerTurn = 0;

                    Console.Write(" {0}, you're at position {1}, please hit enter to spin...", player[playerTurn], currentPosition[playerTurn]);
                    Console.ReadLine();
                    int spaceSpun = spin();
                    Console.WriteLine("{0} spun the number {1}!", player[playerTurn], spaceSpun);

                    nowPos = currentPosition[playerTurn];
                    squareLanded = nowPos + spaceSpun;

                    if (squareLanded <= 100)
                    {
                        if (boardGame[squareLanded] == 0)
                            endPos = squareLanded;
                        else
                            endPos = squareLanded + boardGame[squareLanded];

                        if (boardGame[squareLanded] > 0)
                            Console.WriteLine("Nice! The space you landed on has a ladder that moved you up to space {0}!", endPos);
                        else if (boardGame[squareLanded] < 0)
                            Console.WriteLine("Aww...The space you landed on had a chute that took you back to space {0}.", endPos);
                        else
                            Console.WriteLine(" After that spin, you're now at space {0}.", endPos);
                        currentPosition[playerTurn] = endPos;
                    }
                    else
                    {
                        Console.WriteLine("Sorry! You didn't move any spaces because you can't go pass 100.");
                        currentPosition[playerTurn] = nowPos;
                    }



                    Console.WriteLine(currentPosition[playerTurn]);
                    playerTurn++;

                    Console.ReadLine();
                }

                Console.WriteLine("Congratulations {0}! You are the winner!!!", player[--playerTurn]);
                Console.Write("Would you guys like to play again? (y/n)");
                answer = (char)Console.Read();
                Console.ReadLine();

            }
            Goodbye();
            Console.ReadKey();
        }
    }
}
