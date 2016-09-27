//Jeffrey Martin
//CIS 237 Advanced C#
//Due 10-4-2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// Takes the printChoice and prints out the Maze format chosen.
    /// </summary>
    class UserInterface
    {
        public void PrintMaze(char[,] Maze, int PrintChoice)
        {
            if (PrintChoice == 1)
            {
                PrintCompleteMaze(Maze);
            }
            else
            {
                PrintMazeOverwrite(Maze);
            }
        }

        /// <summary>
        /// Prints Complete Maze List
        /// </summary>
        /// <param name="Maze"></param>
        public void PrintCompleteMaze(char[,] Maze)
        {
            // Loops through the X,Y index of the Array and outputs its data.
            for ( int x = 0; x < Maze.GetLength(0); x++ )
            {
                for (int y = 0; y < Maze.GetLength(1); y++)
                {
                    //Colorizes the maze based on thetype of character.
                    char tempChar = Maze[x, y];
                    switch (tempChar)
                    {
                        case 'X':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 'O':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                    Console.Write(tempChar + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prints Overwrite of the Maze
        /// </summary>
        /// <param name="Maze"></param>
        public void PrintMazeOverwrite(char[,] Maze)
        {
            Console.Clear();
            PrintCompleteMaze(Maze);
            System.Threading.Thread.Sleep(500);

        }
        /// <summary>
        /// Prints a start menu and gets input
        /// </summary>
        public int StartConsole()
        {
            Console.BufferHeight = Int16.MaxValue /20;
            Console.WriteLine("Maze Bot");
            Console.WriteLine();
            string startMenu = "Start Menu" + Environment.NewLine + "1) Print the mazes as a list of step." +
                                Environment.NewLine + "2) Print a single maze following the progress inside." +
                                Environment.NewLine + "Enter the number of the item you wish to do.";
            Console.Write(startMenu);
            ConsoleKeyInfo inputChar = Console.ReadKey();
            Console.WriteLine();
            while (inputChar.KeyChar !='1' && inputChar.KeyChar !='2')
            {
                Console.WriteLine("Invalid Entry please try again");
                Console.Write(startMenu);
                inputChar = Console.ReadKey();
                Console.WriteLine();
            }
            return int.Parse(inputChar.KeyChar.ToString());
        }


        /// <summary>
        /// Gives Exit Found message and pauses the program.
        /// </summary>
        public void ExitFound()
        {
            Console.WriteLine("Exit found!");
            Console.WriteLine("Press any key to continue. . .");
            ConsoleKeyInfo inputChar = Console.ReadKey();

        }
    }
}
