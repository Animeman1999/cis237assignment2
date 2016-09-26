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
    class UserInterface
    {
        /// <summary>
        /// Prints Complete Maze
        /// </summary>
        /// <param name="Maze"></param>
        public void PrintCompleteMaze(char[,] Maze)
        {
            string outputString = "";
            for ( int x = 0; x < Maze.GetLength(0); x++ )
            {
                for (int y = 0; y < Maze.GetLength(1); y++)
                {
                    outputString += Maze[x, y].ToString();
                }
                outputString += Environment.NewLine;
            }
            Console.WriteLine(outputString +Environment.NewLine);
        }

        public void StartConsole()
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.WriteLine("Maze Bot");
        }
    }
}
