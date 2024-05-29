using System.Numerics;
using _2048Console.Application;
using _2048Console.Classes;

namespace _2048Console.Managers;

public class GameManager
{
    public void ManageGame()
    {
        var random = new Random();

        IntSquareMatrix gameState = IntSquareMatrix.Zeros(4);

        var initialElementXIndex = random.Next(0, 4);
        var initialElementYIndex = random.Next(0, 4);
        var initialElement = 2;

        gameState[initialElementXIndex, initialElementYIndex] = initialElement;
        
        Console.WriteLine("Press any key to start the game...");
        Console.ReadKey(true);

        Console.WriteLine("Game started");
        Console.WriteLine("Use arrows to play");
        Console.WriteLine("Press Z to exit");

        IntSquareMatrix nextGameState;
        ConsoleKey lastUsedKey;
        List<Vector2> zerosCoordinates;
        Vector2 randomlyPickedZeroCoordinates;

        do
        {
            Console.Clear();
    
            Console.WriteLine(gameState.ToString());

            var possibleNextGameStates = new List<IntSquareMatrix>()
            {
                IntSquareMatrixTransformer.ShiftLeft(gameState),
                IntSquareMatrixTransformer.ShiftRight(gameState),
                IntSquareMatrixTransformer.ShiftUp(gameState),
                IntSquareMatrixTransformer.ShiftDown(gameState),
            };

            if (possibleNextGameStates.All(x => x == gameState))
            {
                break;
            }

            lastUsedKey = Console.ReadKey(true).Key;

            nextGameState = lastUsedKey switch
            {
                ConsoleKey.LeftArrow => IntSquareMatrixTransformer.ShiftLeft(gameState),
                ConsoleKey.RightArrow => IntSquareMatrixTransformer.ShiftRight(gameState),
                ConsoleKey.UpArrow => IntSquareMatrixTransformer.ShiftUp(gameState),
                ConsoleKey.DownArrow => IntSquareMatrixTransformer.ShiftDown(gameState),
                _ => gameState
            };

            if (gameState == nextGameState)
            {
                continue;
            }

            gameState = nextGameState;
            zerosCoordinates = gameState.ZerosCoordinates();
            randomlyPickedZeroCoordinates = zerosCoordinates[random.Next(0, zerosCoordinates.Count() - 1)];
    
            gameState[(int)randomlyPickedZeroCoordinates.X, (int)randomlyPickedZeroCoordinates.Y] = 2;
        } while (lastUsedKey != ConsoleKey.Z);

        Console.WriteLine("Game over!");
    }
}