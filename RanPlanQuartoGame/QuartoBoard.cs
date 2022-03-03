using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanPlanQuartoGame
{
    class QuartoBoard
    {
        // Create two dimensional array for Board with 4X4
        public String[,] board = new String[4, 4]; 
        public String[,] pieces = new string[16, 4]
        {
                // 16 Pieces of coins
                // L-Light, R-Round, T-Tall, H-Hollow, S-Short, D-Dark, S-Square, S-Solid
                {"LIGHT","ROUND","TALL", "HALLOW"},    // 1
                {"LIGHT","ROUND","TALL", "SOLID"},     // 2
                {"LIGHT","ROUND","SHORT", "HALLOW"},   // 3
                {"LIGHT","ROUND","SHORT", "SOLID"},    // 4
                {"LIGHT","SQUARE","TALL", "HALLOW"},   // 5
                {"LIGHT","SQUARE","TALL", "SOLID"},    // 6
                {"LIGHT","SQUARE","SHORT", "HALLOW"},  // 7
                {"LIGHT","SQUARE","SHORT", "SOLID"},   // 8
                {"DARK","ROUND","TALL", "HALLOW"},     // 9
                {"DARK","ROUND","TALL", "SOLID"},      // 10
                {"DARK","ROUND","SHORT", "HALLOW"},    // 11
                {"DARK","ROUND","SHORT", "SOLID"},     // 12
                {"DARK","SQUARE","TALL", "HALLOW"},    // 13
                {"DARK","SQUARE","TALL", "SOLID"},     // 14
                {"DARK","SQUARE","SHORT", "HALLOW"},   // 15
                {"DARK","SQUARE","SHORT", "SOLID"}     // 16
        };

        public void playGame_PlayPosition()
        {
            // Link code to UI where the coins are placed on the board.
            // for every movement by each player the Quarto Winner condition is checked.
            // for every movement make sure no pieces and board places are duplicated.


            bool playstatus = checkQuartoCondition();

            if(playstatus == true)
            {
                Console.WriteLine("Game Finished. Thanks for playing.");
            } else
            {
                Console.WriteLine("Please play next move");
                // Player has to make next move.
            }
        }

        //This function purpose is to check all the possible quarto condition in the Board and returns status.
        public bool checkQuartoCondition()
        {

            // Check for row Condition on every row on the Board pieces
            Console.WriteLine();
            Console.WriteLine("Row Check started...");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                String[] checkBoard = new String[4];
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //Console.Write("|" + board[i, j]);
                    checkBoard[j] = board[i, j];
                }
                bool winnerstatus = checkQuartoWinner(checkBoard);
                Console.WriteLine();
                if(winnerstatus == true)
                {
                    Console.WriteLine("Congrats Winner! Row QUARTO !!");
                    return true;
                }
            }


            // Check for column Condition
            Console.WriteLine();
            Console.WriteLine("Column Check started...");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                String[] checkBoard = new String[4];
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //Console.Write("|" + board[j, i]);
                    checkBoard[j] = board[j, i];
                }
                bool winnerstatus = checkQuartoWinner(checkBoard);
                Console.WriteLine();
                if (winnerstatus == true)
                {
                    Console.WriteLine("Congrats Winner! Column QUARTO !!");
                    return true;
                }
            }

            // Check for Diagonal1 Condition
                Console.WriteLine();
                Console.WriteLine("Diagonal1 Check started...");
                String[] checkBoard1 = new String[4];
                checkBoard1[0] = board[0, 0];
                checkBoard1[1] = board[1, 1];
                checkBoard1[2] = board[2, 2];
                checkBoard1[3] = board[3, 3];

                bool winnerstatus1 = checkQuartoWinner(checkBoard1);
                Console.WriteLine();
                if (winnerstatus1 == true)
                {
                    Console.WriteLine("Congrats Winner! Diagnol / QUARTO !!");
                    return true;
                }

            // Check for Diagonal2 Condition
                Console.WriteLine();
                Console.WriteLine("Diagonal2 Check started...");
                checkBoard1[0] = board[0, 3];
                checkBoard1[1] = board[1, 2];
                checkBoard1[2] = board[2, 1];
                checkBoard1[3] = board[3, 0];

            winnerstatus1 = checkQuartoWinner(checkBoard1);
            Console.WriteLine();
            if (winnerstatus1 == true)
            {
                Console.WriteLine("Congrats Winner! Diagonal \\ QUARTO !!");
                return true;
            }


            return false;

        }

        // This function check for board positions passed with all the four attributes of pieces Matches or not
        // If Mathces, return true else false
        // Tall or Short, Round or Square, Light or Dark, Hollow or Solid conditions checked for the array passed.
        public bool checkQuartoWinner(String[] boardrows)
        {
            Console.Write(boardrows[0] + "|" + boardrows[1] + "|" + boardrows[2] + "|" + boardrows[3]);
            // Check if any single field is empty, then return false. No need to check the attributes.
            if (boardrows[0]==null || boardrows[1]==null || boardrows[2]==null || boardrows[3]==null)
            {
                return false;
            }

            // Check if current record has same Tall or Short 
            //Console.Write(pieces[Int32.Parse(boardrows[0])-1, 0] + ":" + pieces[Int32.Parse(boardrows[1])-1, 0] + ":" + pieces[Int32.Parse(boardrows[2])-1, 0] + ":" + pieces[Int32.Parse(boardrows[3])-1, 0]);
            for (int i = 0; i < pieces.GetLength(1); i++)
            {
                //Console.Write(".... " + pieces[Int32.Parse(boardrows[0])-1, i] + ":" + pieces[Int32.Parse(boardrows[1])-1, i] + ":" + pieces[Int32.Parse(boardrows[2])-1, i] + ":" + pieces[Int32.Parse(boardrows[3])-1, i]);
                if (pieces[Int32.Parse(boardrows[0]) - 1, i] == pieces[Int32.Parse(boardrows[1]) - 1, i] && pieces[Int32.Parse(boardrows[1]) - 1, i] == pieces[Int32.Parse(boardrows[2]) - 1, i] && pieces[Int32.Parse(boardrows[2]) - 1, i] == pieces[Int32.Parse(boardrows[3]) - 1, i])
                {                    
                    Console.WriteLine("...." + pieces[Int32.Parse(boardrows[0]) - 1, i] + ":" + pieces[Int32.Parse(boardrows[1]) - 1, i] + ":" + pieces[Int32.Parse(boardrows[2]) - 1, i] + ":" + pieces[Int32.Parse(boardrows[3]) - 1, i]);
                    return true;
                }
            }
            return false;
        }



    }
}
