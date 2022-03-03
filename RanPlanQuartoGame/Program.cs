using System;
using RanPlanQuartoGame;

namespace RanplanQuartoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! from RanPlan wireless!");

            // Create a Board to initialize the Game Board
            QuartoBoard myGameBoard = new QuartoBoard();

            // ------------------------------------ Scenario 1 ------------------------------------
            // Feed the data input starting from 1 to 16 based on the Piece Number's property.
            // Board is 2 dimension 4x4 array. starts from 0 to 3 for the placement of the coins
            // Update the data and click run button to see the Quatro validation.
            // Refer Readme file for more details.
            //--------------------------------------------------------------------------------------

                myGameBoard.board[0, 0] = "1";
                myGameBoard.board[0, 1] = "6";
                myGameBoard.board[3, 0] = "2";
                myGameBoard.board[0, 3] = "9";
                myGameBoard.board[1, 1] = "3";
                myGameBoard.board[2, 2] = "4";
                myGameBoard.board[1, 2] = "5";
                myGameBoard.board[2, 1] = "10";

            // -------------------------------- End of Scenario 1 -----------------------------------

            // call the playGame_PlayPosition to start play
            myGameBoard.playGame_PlayPosition();


        }
    }
}