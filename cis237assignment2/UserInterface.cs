﻿//Jeffrey Martin
//CIS 237 Advanced C#
//Due 10-4-2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    class UserInterface
    {
        /// <summary>
        /// Prints Complete Maze
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
        /// Starts the console and increase the verticle buffer.
        /// </summary>
        public void StartConsole()
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.WriteLine("Maze Bot");
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
