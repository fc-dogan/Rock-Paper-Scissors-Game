using System;
using RPS.Models;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Rock, Paper, Scissors");
      Console.Write("Player 1, choose: ");
      string playerOne = Console.ReadLine();
      Console.Clear();
      Console.Write("Player 2, choose: ");
      string playerTwo = Console.ReadLine();
      Console.Clear();
      Game newGame = new Game(playerOne, playerTwo);
      string output = newGame.TieCheck();
      Console.WriteLine(output);
    }
  }
}