using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Models.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void GetWinner_GetWinner_void()
    {
      //Arrange
      Game newGame = new Game("Rock", "Scissors");
      string TestWinner = "";

      //Act
      string winner = newGame.GetResult();

      //Assert
      Assert.AreEqual(winner,TestWinner);
    }
    [TestMethod]
    public void GetWinner_Player1RockWins_void()
    {
      //Arrange
      Game newGame = new Game("Rock" ,"Paper");
      string Winner = "Player 2 wins";
      //Act
      newGame.GetWinner("Rock", "Paper");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
    [TestMethod]
    public void GetWinner_Player1RockNScissorsWins_void()
    {
      //Arrange
      Game newGame = new Game("Rock" ,"Scissors");
      string Winner = "Player 1 wins";
      //Act
      newGame.GetWinner("Rock", "Scissors");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
    [TestMethod]
    public void GetWinner_Player1PaperNScissorsWins_void()
    {
      //Arrange
      Game newGame = new Game("Paper" ,"Scissors");
      string Winner = "Player 2 wins";
      //Act
      newGame.GetWinner("Paper", "Scissors");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
    [TestMethod]
    public void GetWinner_Player2PaperNRockWins_void()
    {
      //Arrange
      Game newGame = new Game("Paper" ,"Rock");
      string Winner = "Player 1 wins";
      //Act
      newGame.GetWinner("Paper", "Rock");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
    [TestMethod]
    public void GetWinner_Player2ScissorsNPaperWins_void()
    {
      //Arrange
      Game newGame = new Game("Scissors" ,"Paper");
      string Winner = "Player 1 wins";
      //Act
      newGame.GetWinner("Scissors", "Paper");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
    [TestMethod]
    public void GetWinner_Player2ScissorsNRockWins_void()
    {
      //Arrange
      Game newGame = new Game("Scissors" ,"Rock");
      string Winner = "Player 2 wins";
      //Act
      newGame.GetWinner("Scissors", "Rock");
      //Assert
      Assert.AreEqual(Winner, newGame.GetResult());
    }
  }
}
