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
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        char[,] printMaze;
        int xStart;
        int yStart;
        UserInterface ui = new UserInterface();

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            ui.StartConsole();

            printMaze = this.maze;
            Console.WriteLine("Original Maze");
            ui.PrintCompleteMaze(this.maze);

            mazeTraversal(printMaze, this.xStart, this.xStart);
            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(char[,] maze, int xPosition, int yPosition)
        {
            bool exited = false;
            int xLength = maze.GetLength(0);
            int yLength = maze.GetLength(1);

            if (!exited)
            {
                if (maze[xPosition,yPosition] == '.' )
                {
                    maze[xPosition, yPosition] = 'X';

                    Console.WriteLine($"X Position = {xPosition}; Y Position = {yPosition}; ");
                    Console.WriteLine($"X Length = {xLength}; Y Length = {yLength};");
                    if (exited)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    ui.PrintCompleteMaze(maze);
                    if (xPosition == 0 || yPosition == 0 || xPosition == xLength - 1 || yPosition == yLength - 1)
                    {
                        Console.WriteLine("Complete");
                        exited = true;
                    }
                    else
                    {
                        mazeTraversal(maze, xPosition, yPosition + 1);
                        mazeTraversal(maze, xPosition, yPosition - 1);
                        mazeTraversal(maze, xPosition + 1, yPosition);
                        mazeTraversal(maze, xPosition - 1, yPosition);
                    }
                }
            }



            //Implement maze traversal recursive call
        }
    }
}
