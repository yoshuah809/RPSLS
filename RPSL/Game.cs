using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPSL
{
    public class Game
    {


        Player player1;
        Player player2;
        PlayerHuman playerHuman;
        Robot Robot;
      
        int player1Score=0;
        int player2Score=0;
        string Scissors;
        Player PlayersChoice;





        public Game()
        {
            playerHuman = new PlayerHuman();
            Robot = new Robot();
            player1Score = 0;
            player2Score = 0;

        }


        public void PlayerTurn()
        {
            player1.ChooseGesture();

            player2.ChooseGesture();

        }
        public string GetNumberOfPlayers()
        {
            Console.WriteLine("1 or 2 Players");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void SetPlayers(string numberPlayers)
        {
            if (numberPlayers == "1")
            {
                player1 = new PlayerHuman();
                player2 = new Robot();
            }
            if (numberPlayers == "2")
            {
                player1 = new PlayerHuman();
                player2 = new PlayerHuman();

            }
        }
        public void CompareGestures()
        {
            if (player2.gestureChoosen == player1.gestureChoosen)
            {
                Console.WriteLine("No Score this is a tie");
            }

            else if (player1.gestureChoosen == "Scissors" && player2.gestureChoosen == "Paper")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Paper" && player2.gestureChoosen == "Rock")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player1.gestureChoosen == "Rock" && player2.gestureChoosen == "Lizard")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Lizard" && player2.gestureChoosen == "Spock")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player1.gestureChoosen == "Spock" && player2.gestureChoosen == "Scissors")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Scissors" && player2.gestureChoosen == "Lizard")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Lizard" && player2.gestureChoosen == "Paper")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Paper" && player2.gestureChoosen == "Spock")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player1.gestureChoosen == "Spock" && player2.gestureChoosen == "Rock")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player2.gestureChoosen == "Scissors" && player1.gestureChoosen == "Paper")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Paper" && player1.gestureChoosen == "Rock")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Rock" && player1.gestureChoosen == "Lizard")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Lizard" && player1.gestureChoosen == "Spock")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player2.gestureChoosen == "Spock" && player1.gestureChoosen == "Scissors")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Scissors" && player1.gestureChoosen == "Lizard")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Lizard" && player1.gestureChoosen == "Paper")
            {
                player2Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 2  wins round");
            }
            else if (player2.gestureChoosen == "Paper" && player1.gestureChoosen == "Spock")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            else if (player2.gestureChoosen == "Spock" && player1.gestureChoosen == "Rock")
            {
                player1Score++;
                Console.WriteLine($"Player 1 selected {player1.gestureChoosen} and Robot Selected {player2.gestureChoosen}");
                Console.WriteLine("player 1  wins round");
            }
            Console.WriteLine(" player 1 score is " + player1Score);
            Console.WriteLine(" player 2 score is " + player2Score);




        }
        public void RoundWinner()
        {
            if (player1Score > player2Score)
            {
                Console.WriteLine("Player One is Winner!");
                Console.ReadLine();
            }
            else if (player2Score > player1Score)
            {
                Console.WriteLine("Player Two is Winner!");
                Console.ReadLine();
            }
        }

        // Method RunGame occurs within class when called out by program class "new game".
        public void RunGame()
        {


            string players = GetNumberOfPlayers();
            SetPlayers(players);
            while (player1Score < 3 && player2Score < 3)
            {

                PlayerTurn();
                CompareGestures();
            }



            RoundWinner();


        }

    }
}




