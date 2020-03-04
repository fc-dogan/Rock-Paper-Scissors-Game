using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void GameConstructor_CreatesInstancesOfGame_Game()
    {
      Game newgame = new Game("test", "test2");
      Assert.AreEqual(typeof(Game), newgame.GetType());
    }

    [TestMethod]
    public void GameConstructor_SetValues_Game()
    {
      Game newGame =new Game("test", "test2");
      Assert.AreEqual("test", newGame.PlayerOne);
    }
    [TestMethod]
    public void TieCheck_PlayerOneEqualsPlayerTwo_StringIsATie()
    {
      Game newGame = new Game("rock", "rock");
      string result = "Game is a Tie";
      Assert.AreEqual(result, newGame.TieCheck());
    }

    [TestMethod]
    public void GameCheck_PlayerOneRock_StringForPaperWinner()
    {
      Game newGame = new Game("rock", "paper");
      Assert.AreEqual(newGame.PlayerTwoWins(), newGame.GameCheck());
    }
    [TestMethod]
    public void GameCheck_PlayerOneRock_StringForRockWinner()
    {
      Game newGame = new Game("rock", "scissors");
      Assert.AreEqual(newGame.PlayerOneWins(), newGame.GameCheck());
    }
    [TestMethod]
    public void GameCheck_PlayerOnePaper_StringForPaperWinner()
    {
      Game newGame = new Game("paper", "rock");
      Assert.AreEqual(newGame.PlayerOneWins(), newGame.GameCheck());
    }
    [TestMethod]
    public void GameCheck_PlayerOnePaper_StringForScissorsWinner()
    {
      Game newGame = new Game("paper", "scissors");
      Assert.AreEqual(newGame.PlayerTwoWins(), newGame.GameCheck());
    }
    [TestMethod]
    public void GameCheck_PlayerOneScissors_StringForRockWiner()
    {
      Game newGame = new Game("scissors","rock");
      Assert.AreEqual(newGame.PlayerTwoWins(), newGame.GameCheck());
    }
    [TestMethod]
    public void GameCheck_PlayerOneScissors_StringForScissorsWiner()
    {
      Game newGame = new Game("scissors","paper");
      Assert.AreEqual(newGame.PlayerOneWins(), newGame.GameCheck());
    }
  }
}