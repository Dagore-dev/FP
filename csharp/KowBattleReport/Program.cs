using System;

namespace KowBattleReport
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner, playerOneStatus, playerTwoStatus, mostKiller;
            int playerOneLiveUnits, playerTwoLiveUnits, pointsDiff, playerOneScore, playerTwoScore;


            Console.Write("Dime el ganador (playerOne / playerTwo / none): ");
            winner = Console.ReadLine();
            while (winner != "playerOne" && winner != "playerTwo" && winner != "none")
            {
                Console.WriteLine("No has introducido bien el ganador. Si se trata de un empate teclea \"none\".");
                winner = Console.ReadLine();
            }

            Console.Write("Dime los puntos vivos del playerOne: ");
            playerOneLiveUnits = int.Parse(Console.ReadLine());
            Console.Write("Dime los puntos vivos del playerTwo: ");
            playerTwoLiveUnits = int.Parse(Console.ReadLine());

            if (winner.Equals("playerOne"))
            {
                playerOneStatus = "win";
                playerTwoStatus = "lose";
            }
            else
            {
                if (winner.Equals("playerTwo"))
                {
                    playerOneStatus = "lose";
                    playerTwoStatus = "win";
                }
                else
                {
                    playerOneStatus = "draw";
                    playerTwoStatus = "draw";
                }
            }

            mostKiller = MostKiller(playerOneLiveUnits, playerTwoLiveUnits);
            pointsDiff = Math.Abs(playerOneLiveUnits - playerTwoLiveUnits);

            playerOneScore = PlayerScore("playerOne", playerOneStatus, mostKiller, pointsDiff);
            playerTwoScore = PlayerScore("playerTwo", playerTwoStatus, mostKiller, pointsDiff);

            Console.WriteLine($"El playerOne obtiene {playerOneScore} puntos y el playerTwo obtine {playerTwoScore} puntos.");

        }

        static string MostKiller (int playerOneLiveUnits, int playerTwoLiveUnits)
        {
            string mostKiller;
            
            if (playerOneLiveUnits > playerTwoLiveUnits)
            {
                mostKiller = "playerOne";
            }
            else
            {
                mostKiller = "playerTwo";
            }

            return mostKiller;
        }

        static int DefineModifier(int pointsDiff)
        {
            int modifier;

            if (pointsDiff < 100)
            {
                modifier = 0;
            }
            else if (pointsDiff < 400)
            {
                modifier = 1;
            }
            else if (pointsDiff < 800)
            {
                modifier = 2;
            }
            else if (pointsDiff < 1200)
            {
                modifier = 3;
            }
            else if (pointsDiff < 1600)
            {
                modifier = 4;
            }
            else
            {
                modifier = 5;
            }

            return modifier;
        }

        static int PlayerScore (string player, string playerStatus, string mostKiller, int pointsDiff)
        {
            int initialScore, modifier, finalScore;

            switch (playerStatus)
            {
                case "win": initialScore = 15; break;
                case "draw": initialScore = 10; break;
                case "lose": initialScore = 5; break;
                default: throw new Exception("Invalid player status");
            }

            finalScore = initialScore;

            modifier = DefineModifier(pointsDiff);

            if (player.Equals(mostKiller))
            {
                finalScore += modifier;
            }
            else
            {
                finalScore -= modifier;
            }

            return finalScore;
        }


    }
}
