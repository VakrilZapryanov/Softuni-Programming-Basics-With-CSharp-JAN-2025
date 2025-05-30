﻿//Input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

//Calculations
int cakePieces = width * length;
string input = "";

while ((input = Console.ReadLine()) != "STOP")
{
    int takenPieces = int.Parse(input);
    cakePieces -= takenPieces;

    if (cakePieces < 0)
    {
        //Output
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
        break;
    }
}

//Output
if (cakePieces >= 0)
{
    Console.WriteLine($"{cakePieces} pieces are left.");
}