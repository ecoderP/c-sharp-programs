using System;

public class NumberGuessProgram
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int randNum = rand.Next(1,51);
        int userGuess = Convert.ToInt32(Console.ReadLine());

    }
}
