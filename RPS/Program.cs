using System;
using RPS.Models;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      // try
      // {
        Console.WriteLine("Rock, Paper, Scissors");
        Console.Write("Enter player one's name: ");
        string nameOne = Console.ReadLine();
        Console.Write("Enter player two's name: ");
        string nameTwo = Console.ReadLine();
        string playerOne = PlayerTurn(nameOne);
        Console.Clear();
        string playerTwo = PlayerTurn(nameTwo);
        Console.Clear();
        Game newGame = new Game(playerOne, playerTwo);
        string output = newGame.TieCheck();
        Console.WriteLine(output);
      // }
      // catch (Exception ex)
      // {
      //   Console.WriteLine("Message = {0}", ex.Message);
      //   Console.WriteLine("Source = {0}", ex.Source);
      //   Console.WriteLine("StackTrace = {0}", ex.StackTrace);
      //   Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      // }
    }
    public static string PlayerTurn(string name)
    {
      bool playerChoice = false;
      while (playerChoice == false)
      {
        Console.Write($"Player {name} choose: ");
        string player = Console.ReadLine();
        if (player == "paper" || player == "rock" || player == "scissors")
        {
          playerChoice = true;
          return player;
        }
        else 
        {
          Console.WriteLine("Please enter a valid choice.");
        }
      }
      return null;
    }
  }
}