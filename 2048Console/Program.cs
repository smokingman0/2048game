﻿using System.Numerics;
using _2048Console.Application;
using _2048Console.Classes;

var random = new Random();

var gameState = IntSquareMatrix.Zeros(4);

var initialElementXIndex = random.Next(0, 4);
var initialElementYIndex = random.Next(0, 4);
var initialElement = 2;

gameState[initialElementXIndex, initialElementYIndex] = initialElement;


Console.WriteLine("Press any key to start the game...");
Console.ReadKey(true);

Console.WriteLine("Game started");
Console.WriteLine("Use arrows to play");
Console.WriteLine("Press Z to exit");

ConsoleKey lastUsedKey;
List<Vector2> zerosCoordinates;
Vector2 randomlyPickedZeroCoordinates;

do
{
    Console.WriteLine(gameState.ToString());

    lastUsedKey = Console.ReadKey(true).Key;

    gameState = lastUsedKey switch
    {
        ConsoleKey.LeftArrow => IntSquareMatrixTransformer.ShiftLeft(gameState),
        ConsoleKey.RightArrow => IntSquareMatrixTransformer.ShiftRight(gameState),
        ConsoleKey.UpArrow => IntSquareMatrixTransformer.ShiftUp(gameState),
        ConsoleKey.DownArrow => IntSquareMatrixTransformer.ShiftDown(gameState),
        _ => gameState
    };

    zerosCoordinates = gameState.ZerosCoordinates();
    randomlyPickedZeroCoordinates = zerosCoordinates[random.Next(0, zerosCoordinates.Count() - 1)];

    gameState[(int)randomlyPickedZeroCoordinates.X, (int)randomlyPickedZeroCoordinates.Y] = 2;
} while (lastUsedKey != ConsoleKey.Z);

Console.WriteLine("Game over!");