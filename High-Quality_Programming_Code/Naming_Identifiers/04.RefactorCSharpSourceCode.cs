using System;
using System.Collections.Generic;

// A simple version of the minesweeper game.
namespace MineSweeper
{
    public class Mines
    {
        public class Player
        {
            private string playerName;
            private int playerPoints;

            public string Name
            {
                get { return playerName; }
                set { playerName = value; }
            }

            public int Points
            {
                get { return playerPoints; }
                set { playerPoints = value; }
            }

            public Player(string name, int points)
            {
                this.playerName = name;
                this.playerPoints = points;
            }
        }

        public static void Main()
        {
            string command = string.Empty;
            char[,] battlefield = createBattlefield();
            char[,] mines = putMines();
            int counter = 0;
            bool explosion = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isTrue = true;
            const int MAX = 35;
            bool isFalse = false;

            do
            {
                if (isTrue)
                {
                    Console.WriteLine("Let's play Minesweeper. Try your luck to uncover fields without mines. " +
                        "Command 'Top' shows the ranking, 'Restart' starts new game and 'Exit' leaves it and says Bye!");
                    Dump(battlefield);
                    isTrue = false;
                }

                Console.Write("Please give a row and a column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column) &&
                        row <= battlefield.GetLength(0) && column <= battlefield.GetLength(1))
                    {
                        command = "Turn";
                    }
                }

                switch (command)
                {
                    case "Top":
                        Ranking(champions);
                        break;
                    case "Restart":
                        battlefield = createBattlefield();
                        mines = putMines();
                        Dump(battlefield);
                        explosion = false;
                        isTrue = false;
                        break;
                    case "Exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "Turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                playerTurn(battlefield, mines, row, column);
                                counter++;
                            }

                            if (MAX == counter)
                            {
                                isFalse = true;
                            }
                            else
                            {
                                Dump(battlefield);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command.\n");
                        break;
                }

                if (explosion)
                {
                    Dump(mines);
                    Console.Write("\nHrrrrrr! You died with {0} points. " + "Please give a name:", counter);
                    string name = Console.ReadLine();
                    Player player = new Player(name, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(player);
                    }
                    else
                    {
                        for (int index = 0; index < champions.Count; index++)
                        {
                            if (champions[index].Points < player.Points)
                            {
                                champions.Insert(index, player);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player rowOne, Player rowTwo) => rowTwo.Name.CompareTo(rowOne.Name));
                    champions.Sort((Player rowOne, Player rowTwo) => rowTwo.Points.CompareTo(rowOne.Points));
                    Ranking(champions);

                    battlefield = createBattlefield();
                    mines = putMines();
                    counter = 0;
                    explosion = false;
                    isTrue = true;
                }

                if (isFalse)
                {
                    Console.WriteLine("\nBRAVOOO! You opened 35 cells without drop of blood.");
                    Dump(mines);
                    Console.WriteLine("Please give me your name: ");
                    string name = Console.ReadLine();
                    Player points = new Player(name, counter);
                    champions.Add(points);
                    Ranking(champions);
                    battlefield = createBattlefield();
                    mines = putMines();
                    counter = 0;
                    isFalse = false;
                    isTrue = true;
                }
            } while (command != "Exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("OYEEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Ranking(List<Player> points)
        {
            Console.WriteLine("\nPoints:");

            if (points.Count > 0)
            {
                for (int index = 0; index < points.Count; index++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", index + 1, points[index].Name, points[index].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranking!\n");
            }
        }

        private static void playerTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char bombsNumber = Amount(bombs, row, column);
            bombs[row, column] = bombsNumber;
            field[row, column] = bombsNumber;
        }

        private static void Dump(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int index = 0; index < rows; index++)
            {
                Console.Write("{0} | ", index);

                for (int innerIndex = 0; innerIndex < columns; innerIndex++)
                {
                    Console.Write(string.Format("{0} ", board[index, innerIndex]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createBattlefield()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int index = 0; index < boardRows; index++)
            {
                for (int innerIndex = 0; innerIndex < boardColumns; innerIndex++)
                {
                    board[index, innerIndex] = '?';
                }
            }

            return board;
        }

        private static char[,] putMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] battlefield = new char[rows, columns];

            for (int index = 0; index < rows; index++)
            {
                for (int innerIndex = 0; innerIndex < columns; innerIndex++)
                {
                    battlefield[index, innerIndex] = '-';
                }
            }

            List<int> baseList = new List<int>();

            while (baseList.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);

                if (!baseList.Contains(number))
                {
                    baseList.Add(number);
                }
            }

            foreach (int number in baseList)
            {
                int column = (number / columns);
                int row = (number % columns);

                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                battlefield[column, row - 1] = '*';
            }

            return battlefield;
        }

        private static void Calculate(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int index = 0; index < column; index++)
            {
                for (int innerIndex = 0; innerIndex < row; innerIndex++)
                {
                    if (field[index, innerIndex] != '*')
                    {
                        char quantity = Amount(field, index, innerIndex);
                        field[index, innerIndex] = quantity;
                    }
                }
            }
        }

        private static char Amount(char[,] field, int index, int innerIndex)
        {
            int amount = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if ((index - 1) >= 0)
            {
                if (field[index - 1, innerIndex] == '*')
                {
                    amount++;
                }
            }

            if ((index + 1) < rows)
            {
                if (field[index + 1, innerIndex] == '*')
                {
                    amount++;
                }
            }

            if ((innerIndex - 1) >= 0)
            {
                if (field[index, innerIndex - 1] == '*')
                {
                    amount++;
                }
            }

            if ((innerIndex + 1) < columns)
            {
                if (field[index, innerIndex + 1] == '*')
                {
                    amount++;
                }
            }

            if (((index - 1) >= 0) && ((innerIndex - 1) >= 0))
            {
                if (field[index - 1, innerIndex - 1] == '*')
                {
                    amount++;
                }
            }

            if (((index - 1) >= 0) && ((innerIndex + 1) < columns))
            {
                if (field[index - 1, innerIndex + 1] == '*')
                {
                    amount++;
                }
            }

            if (((index + 1) < rows) && ((innerIndex - 1) >= 0))
            {
                if (field[index + 1, innerIndex - 1] == '*')
                {
                    amount++;
                }
            }

            if (((index + 1) < rows) && ((innerIndex + 1) < columns))
            {
                if (field[index + 1, innerIndex + 1] == '*')
                {
                    amount++;
                }
            }

            return char.Parse(amount.ToString());
        }
    }
}
