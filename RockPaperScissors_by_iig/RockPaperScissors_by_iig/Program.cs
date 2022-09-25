using System;

namespace RockPaperScissors_by_iig
{
    class Program
    {
        static void Main(string[] args)
        {


            var random = new Random();
            int randomNumber = random.Next(1, 3);
            char ch = ' ';
            string computerChose = "";
            string yourChose = "";

            Console.WriteLine("Let's play a game?");
            Console.WriteLine("The game is \"Rock – Paper – Scissors\"");
            Console.WriteLine("It is easy, Just choose one of the three.");
            Console.WriteLine("Let's play?");
            Console.WriteLine();

            while(true)
            {
                Console.Write("Choose [R]ock, [P]aper or [S]cissors: ");
                ch = char.Parse(Console.ReadLine());

                if ((ch != 'r') && (ch != 'R') && (ch != 'p') && (ch != 'P') && (ch != 's') && (ch != 'S'))
                    Console.WriteLine("Invalid choose. Please try again!");
                else
                    break;
            }

            switch (ch)
            {
                case 'R':
                case 'r':
                    yourChose = "Rock";
                    break;

                case 'P':
                case 'p':
                    yourChose = "Paper";
                    break;

                case 'S':
                case 's':
                    yourChose = "Scissors";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    computerChose = "Rock";
                    break;

                case 2:
                    computerChose = "Paper";
                    break;

                case 3:
                    computerChose = "Scissors";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine($"Your chose {yourChose}.");
            Console.WriteLine($"The computer chose {computerChose}.");
            Console.WriteLine();

            if ((computerChose == "Rock") && (yourChose == "Rock"))
                Console.WriteLine("This game was a draw.");

            if ((computerChose == "Rock") && (yourChose == "Paper"))
                Console.WriteLine("Congrats, You win!!!");

            if ((computerChose == "Rock") && (yourChose == "Scissors"))
                Console.WriteLine("Sorry, You lose.");

            if ((computerChose == "Paper") && (yourChose == "Paper"))
                Console.WriteLine("This game was a draw.");

            if ((computerChose == "Paper") && (yourChose == "Rock"))
                Console.WriteLine("Sorry, You lose.");

            if ((computerChose == "Paper") && (yourChose == "Scissors"))
                Console.WriteLine("Congrats, You win!!!");

            if ((computerChose == "Scissors") && (yourChose == "Scissors"))
                Console.WriteLine("This game was a draw.");

            if ((computerChose == "Scissors") && (yourChose == "Rock"))
                Console.WriteLine("Congrats, You win!!!");

            if ((computerChose == "Scissors") && (yourChose == "Paper"))
                Console.WriteLine("Sorry, You lose.");

        }

    }
}
