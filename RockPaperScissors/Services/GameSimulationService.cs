using System;
using RockPaperScissors.Models;
using RockPaperScissors.Enums;
using RockPaperScissors;

namespace RockPaperScissors.Services
{
    public class GameSimulationService
    {
        public Player playerOne;
        public Player playerTwo;
        public const int totalGamesToSimulate = 100;
        GamesSummary gamesSummary;
        public GameSimulationService()
        {
            playerOne = new Player("A");
            playerTwo = new Player("B");
            gamesSummary = new GamesSummary();
        }
        public void SimulateGames()
        {
            int gameNumber = 1;
            while (gameNumber <= totalGamesToSimulate)
            {
                MovesEnum playerOneMove = GetPlayerMove(playerOne);
                MovesEnum playerTwoMove = GetPlayerMove(playerTwo);
                Player winner = CalculateGameWinner(playerOne, playerOneMove, playerTwo, playerTwoMove);
                ResultsService.PrintMatchResult(winner, gameNumber, playerOne, playerOneMove, playerTwo, playerTwoMove);
                UpdateGameSummary(winner);
                gameNumber++;
            }
            ResultsService.PrintGamesSummary(gamesSummary, playerOne, playerTwo);
        }

        // Private Methods
        private MovesEnum GetPlayerMove(Player player)
        {
            if (player.Name.Equals("A"))
            {
                return MovesEnum.Rock;
            }
            else
            {
                return CalculatePlayerMove();
            }
        }
        private MovesEnum CalculatePlayerMove()
        {
            int totalPlayerMovesCount = Enum.GetNames(typeof(MovesEnum)).Length;
            int randomNumber = new Random().Next(totalPlayerMovesCount);
            return (MovesEnum)randomNumber;
        }
        private void UpdateGameSummary(Player winner)
        {
            gamesSummary.TotalGamesPlayed++;
            if (winner == null)
            {
                gamesSummary.DrawTotal++;
            }
            else if (winner == playerOne)
            {
                gamesSummary.PlayerOneWinTotal++;
            }
            else if (winner == playerTwo)
            {
                gamesSummary.PlayerTwoWinTotal++;
            }
        }
        private Player CalculateGameWinner(Player playerOne, MovesEnum playerOneMove, Player playerTwo, MovesEnum playerTwoMove)
        {
            if (playerOneMove == playerTwoMove)
            {
                return null;
            }
            else if (playerOneMove == MovesEnum.Rock && playerTwoMove == MovesEnum.Scissors)
            {
                return playerOne;
            }
            else if (playerOneMove == MovesEnum.Rock && playerTwoMove == MovesEnum.Paper)
            {
                return playerTwo;
            }
            else if (playerOneMove == MovesEnum.Paper && playerTwoMove == MovesEnum.Scissors)
            {
                return playerTwo;
            }
            else if (playerOneMove == MovesEnum.Paper && playerTwoMove == MovesEnum.Rock)
            {
                return playerOne;
            }
            else if (playerOneMove == MovesEnum.Scissors && playerTwoMove == MovesEnum.Paper)
            {
                return playerOne;
            }
            else if (playerOneMove == MovesEnum.Scissors && playerTwoMove == MovesEnum.Rock)
            {
                return playerTwo;
            }
            return null;
        }
    }
}
