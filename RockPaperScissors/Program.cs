using RockPaperScissors.Services;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSimulationService gameSimulationService = new GameSimulationService();
            gameSimulationService.SimulateGames();
        }
    }
}
