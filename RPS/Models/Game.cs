using System;

namespace RPS.Models
{
  public class Game
  {
    public string PlayerOne {get; set;}
    public string PlayerTwo {get; set;}
    public Game(string playerOne, string playerTwo)
    {
      PlayerOne = playerOne;
      PlayerTwo = playerTwo;
    }
    public string TieCheck()
    {
      if (PlayerOne == PlayerTwo)
      {
        return "Game is a Tie";
      }
      else 
      {
       return GameCheck();
      }
    }
    public string GameCheck()
    {
      if ( PlayerOne == "rock")
      {
        if(PlayerTwo == "paper")
        {
          return PlayerTwoWins();
        }
        else
        {
          return PlayerOneWins();
        }
      }
      else if (PlayerOne == "paper")
      {
        if(PlayerTwo == "rock")
        {
          return PlayerOneWins();
        }
        return PlayerTwoWins();
      }
      else if (PlayerOne == "scissors")
      {
        if(PlayerTwo == "rock")
        {
          return PlayerTwoWins();
        }
        return PlayerOneWins();
      }
      else
      {
        return "Please enter rock, paper, or scissors";
      }
    }

    public string PlayerOneWins()
    {
      string response = String.Format("Player 1 chooses {0}. Player 2 chooses {1}. Player 1 wins!", PlayerOne, PlayerTwo);
      return response;
    }
    public string PlayerTwoWins()
    {
      return $"Player 1 chooses {PlayerOne}. Player 2 chooses {PlayerTwo}. Player 2 wins!";
    }
  }
}