using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
  public class Game
  {
    private string _player1;
    private string _player2;
    private string _results;

    public Game (string player1, string player2){
      _player1 = player1;
      _player2 = player2;
      _results = "";
    }
    public string GetPlayer1()
    {
      return _player1;
    }
    public string GetPlayer2()
    {
      return _player2;
    }
    public void SetPlayer1(string player1, string player2)
    {
       _player1 = player1;
       _player2 = player2;
    }
    public string GetResult()
    {
      return _results;
    }

    public void GetWinner(string player1, string player2)
    {
      if(player1 == "Rock" && player2 == "Paper")
      {
        _results = "Player 2 wins";
      }else if(player1 == "Rock" && player2 == "Scissors")
      {
        _results = "Player 1 wins";
      }else if(player1 == "Paper" && player2 == "Scissors")
      {
        _results = "Player 2 wins";
      }else if(player1 == "Paper" && player2 == "Rock")
      {
        _results = "Player 1 wins";
      }else if(player1 == "Scissors" && player2 == "Paper")
      {
        _results = "Player 1 wins";
      }else if(player1 == "Scissors" && player2 == "Rock")
      {
        _results = "Player 2 wins";
      }else{
        _results = "it's a draw!";
      }
    }
  }
}
