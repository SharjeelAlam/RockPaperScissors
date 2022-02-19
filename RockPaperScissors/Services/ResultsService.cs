using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Services
{
    public static class ResultsService
    {
        public static void PrintMatchResult(Player winner, int matchNumber, Player playerOne, MovesEnum playerOneMove , Player playerTwo, MovesEnum playerTwoMove)
        {
            Console.WriteLine("\nMatch Number: {0}", matchNumber);
            Console.WriteLine("Player {0} Move: {1}", playerOne.Name, playerOneMove);
            Console.WriteLine("Player {0} Move: {1}", playerTwo.Name, playerTwoMove);
            if (winner == null)
            {
                Console.WriteLine("Result: Draw");
            }
            else
            {
                Console.WriteLine("Result: Player {0} won", winner.Name);
            }
        }
        public static void PrintGamesSummary(GamesSummary gamesSummary, Player playerOne, Player playerTwo)
        {
            Console.WriteLine("\n----Games Summary----");
            Console.WriteLine("Total Games Played: {0}",gamesSummary.TotalGamesPlayed);
            Console.WriteLine("Total Games Won By Player {0}: {1}", playerOne.Name, gamesSummary.PlayerOneWinTotal);
            Console.WriteLine("Total Games Won By Player {0}: {1}", playerTwo.Name, gamesSummary.PlayerTwoWinTotal);
            Console.WriteLine("Total Games Ended In Draw: {0}", gamesSummary.DrawTotal);
            Console.ReadKey();
        }
    }
}
