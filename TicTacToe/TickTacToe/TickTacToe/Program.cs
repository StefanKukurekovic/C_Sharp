using System;

namespace TickTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;

            string[,] ticTacToeInterface =
            {
                {" ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ","|", " ", " ", " ", " ", " "},
                {" ", " ", "1", " ", " ", "|", " ", " ", "2", " ", " ","|", " ", " ", "3", " ", " "},
                {"_","_","_", "_", "_", "|", "_", "_", "_", "_", "_","|", "_", "_", "_","_", "_"},
                {" ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ","|", " ", " ", " ", " ", " "},
                {" ", " ", "4", " ", " ", "|", " ", " ", "5", " ", " ","|", " ", " ", "6", " ", " "},
                {"_", "_", "_", "_", "_", "|", "_", "_", "_", "_", "_","|", "_", "_", "_", "_", "_"},
                {" ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ","|", " ", " ", " ", " ", " "},
                {" ", " ", "7", " ", " ", "|", " ", " ", "8", " ", " ","|", " ", " ", "9", " ", " "},
                {" ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ","|", " ", " ", " ", " ", " "}
            };
            /*
            string one = ticTacToeInterface[1, 2];
            string two = ticTacToeInterface[1, 8];
            string three = ticTacToeInterface[1, 14];
            string four = ticTacToeInterface[4, 2];
            string five = ticTacToeInterface[4, 8];
            string six = ticTacToeInterface[4, 14];
            string seven = ticTacToeInterface[7, 2];
            string eight = ticTacToeInterface[7, 8];
            string nine = ticTacToeInterface[7, 14];*/




            bool checkIfEnd = false;
            int count = 1;
            do
            {

                /*if ((one == two && one == three) || (one == four && one == seven) || (one == five && one == nine) ||
                    (three == six && three == nine) || (two == five && two == eight) ||
                    (four == five && four == six) || (seven == eight && seven == nine))
                {
                    if ((count - 1) % 2 != 0)
                    {
                        Console.WriteLine("Congratulations! Player 1 won.");
                        Console.WriteLine("End game!");
                        checkIfEnd = true;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! Player 2 won.");
                        Console.WriteLine("End game!");
                        checkIfEnd = true;
                    }
                }
                else if (count == 11)
                {
                    Console.WriteLine("Unfortunaly no winner in this game. Try again!");
                    Console.WriteLine("End game!");
                    checkIfEnd = true;

                }*/




                PrintTable(ticTacToeInterface);
                if (count%2 != 0)
                {
                    bool check = false;
                    do
                    {
                        Console.WriteLine("Player 1: Choose your field!");
                        player1 = Console.ReadLine();
                        check = Validation(player1);
                    } while (!check);

                    switch (player1)
                    {
                        case "1":
                            if (ticTacToeInterface[1, 2] != "1")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 2] = "X";
                            count++;
                            break;
                        case "2":
                            if (ticTacToeInterface[1, 8] != "2")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 8] = "X";
                            count++;
                            break;
                        case "3":
                            if (ticTacToeInterface[1, 14] != "3")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 14] = "X";
                            count++;
                            break;
                        case "4":
                            if (ticTacToeInterface[4, 2] != "4")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 2] = "X";
                            count++;
                            break;
                        case "5":
                            if (ticTacToeInterface[4, 8] != "5")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 8] = "X";
                            count++;
                            break;
                        case "6":
                            if (ticTacToeInterface[4, 14] != "6")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 14] = "X";
                            count++;
                            break;
                        case "7":
                            if (ticTacToeInterface[7, 2] != "7")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 2] = "X";
                            count++;
                            break;
                        case "8":
                            if (ticTacToeInterface[7, 8] != "8")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 8] = "X";
                            count++;
                            break;
                        case "9":
                            if (ticTacToeInterface[7, 14] != "9")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 14] = "X";
                            count++;
                            break;
                        default:
                            Console.WriteLine("Please only enter numbers 1,2,3,4,5,6,7,8 or 9.");
                            break;
                    }


                }
                else
                {
                    bool check = false;
                    do
                    {
                        Console.WriteLine("Player 2: Choose your field!");
                        player2 = Console.ReadLine();
                        check = Validation(player2);
                    } while (!check);

                    switch (player2)
                    {
                        case "1":
                            if (ticTacToeInterface[1, 2] != "1")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 2] = "O";
                            count++;
                            break;
                        case "2":
                            if (ticTacToeInterface[1, 8] != "2")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 8] = "O";
                            count++;
                            break;
                        case "3":
                            if (ticTacToeInterface[1, 14] != "3")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[1, 14] = "O";
                            count++;
                            break;
                        case "4":
                            if (ticTacToeInterface[4, 2] != "4")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 2] = "O";
                            count++;
                            break;
                        case "5":
                            if (ticTacToeInterface[4, 8] != "5")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 8] = "O";
                            count++;
                            break;
                        case "6":
                            if (ticTacToeInterface[4, 14] != "6")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[4, 14] = "O";
                            count++;
                            break;
                        case "7":
                            if (ticTacToeInterface[7, 2] != "7")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 2] = "O";
                            count++;
                            break;
                        case "8":
                            if (ticTacToeInterface[7, 8] != "8")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 8] = "O";
                            count++;
                            break;
                        case "9":
                            if (ticTacToeInterface[7, 14] != "9")
                            {
                                Console.WriteLine("That field has already been filled. Please enter another one");
                                break;
                            }
                            ticTacToeInterface[7, 14] = "O";
                            count++;
                            break;
                        default:
                            Console.WriteLine("Please only enter numbers 1,2,3,4,5,6,7,8 or 9.");
                            break;
                    }
                }
                
                
            } while (!checkIfEnd);



        }

        public static bool Validation(string userInput)
        {
            int value;
            if (!Int32.TryParse(userInput, out value))
            {
                Console.WriteLine("Please enter a number!\n");
                return false;
            }
            return true;
        }

        public static void PrintTable(string[,] ticTacToe)
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Console.Write(ticTacToe[i, j]);
                }
                Console.WriteLine();
            }
        }



    }
}
