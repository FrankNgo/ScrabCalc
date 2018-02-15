# Anagram

#### By Frank Ngo

## Description

A program to test if a set of words are anagrams of another word.

## Specifications
-Draw-

* If both Users enter the same Inputs the game will end as a draw
  * Example Input: P1: Rock P2: Rock
  * Example Output: "It's a draw!"
  
* If both Users enter the same Inputs the game will end as a draw
  * Example Input: P1: Scissors P2: Scissors
  * Example Output: "It's a draw!"

* If both Users enter the same Inputs the game will end as a draw
  * Example Input: P1: Paper P2: Paper
  * Example Output: "It's a draw!"

-User 1 wins-

* If User1 enters Paper and User2 enters Rock, User 1 will win
  * Example Input: P1: Paper P2: Rock
  * Example Output: "User 1 wins"

* If User1 enters Scissors and User2 enters Paper, User 1 will win
  * Example Inputs: P1:Scissors P2: Paper
  * Example Output: "User 1 wins"

* If User1 enters Rock and User2 enters Scissors, User 1 will win
  * Example Input: P1:Rock P2:Scissors
  * Example Output: "User 1 wins"

-User 2 wins-

* If User1 enters Rock and User2 enters Paper, User 2 will win
  * Example Input: P1: Rock P2: Paper
  * Example Output: "User 2 wins"

* If User1 enters Paper and User2 enters Scissors, User 2 will win
  * Example Inputs: P1:Paper P2: Scissors
  * Example Output: "User 2 wins"

* If User1 enters Scissors and User2 enters Rock, User 2 will win
  * Example Input: P1:Scissors P2:Rock
  * Example Output: "User 2 wins"


### Installing

  * Open Terminal
  * Cd to desktop or where user would like to store directory by typing in: cd Desktop
  * Copy application contents by typing in your Terminal: git clone https://github.com/FrankNgo/Address-Book.git
  * Navigate to the application directory by typing in: cd Address-Book
  * Restore the applications dependencies by typing in: dotnet restore
  * Build the application by typing in: dotnet build
  * Run and open the application by typing in: dotnet run
  * Open any browser
  * Type in the browser URL http://localhost:5000/ to access the application

### Bugs and Tests

No known bugs

## Built With

* HTML - The web framework used
* C# - The programming language used
* CSS - Style Library
* Javascript
* Asp .NET Core MVC
* [bootstrap](https://getbootstrap.com/docs/3.3/) - Style Library
* [jquery](https://jquery.com/download/) - Javascript Library


## Author and contact details

* Frank Ngo https://github.com/FrankNgo
* Contact the author at frankngomusic@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
