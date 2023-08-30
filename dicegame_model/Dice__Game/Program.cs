using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dice__Game
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int playerRandomNumber1;
                int playerRandomNumber2;
                int enemyRandomNumber1;
                int enemyRandomNumber2;
                int playerPoint = 0;
                int enemyPoint = 0;
                int playerTotalScore = 0;
                int enemyTotalScore = 0;

                Random random = new Random();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Press enter key to roll the dice...");
                    Console.ReadKey();

                    if (playerTotalScore >= 100)
                    {
                        Console.WriteLine("....Player A has won the game!!!.....");
                        break;
                    }
                    if (enemyTotalScore >= 100)
                    {
                        Console.WriteLine("....Player B has won the game!!!.....");
                        break;
                    }


                    playerRandomNumber1 = random.Next(1, 7);
                    playerRandomNumber2 = random.Next(1, 7);
                    playerPoint = playerRandomNumber1 + playerRandomNumber2;
                    playerTotalScore = playerTotalScore + playerPoint;




                    if (playerRandomNumber1 == playerRandomNumber2)
                    {
                        if (playerRandomNumber1 > 1 && playerRandomNumber2 > 1)
                        {
                            Console.WriteLine("Dice 1 is : " + playerRandomNumber1);
                            Console.WriteLine("Dice 2 is : " + playerRandomNumber2);
                            Console.WriteLine("Score of player A is : " + playerTotalScore);
                            Console.WriteLine();


                            

                            do
                            {
                                playerRandomNumber1 = random.Next(1, 7);
                                playerRandomNumber2 = random.Next(1, 7);
                                playerPoint = playerRandomNumber1 + playerRandomNumber2;
                                playerTotalScore = playerTotalScore + playerPoint;

                                Console.WriteLine("Dice 1 is : " + playerRandomNumber1);
                                Console.WriteLine("Dice 2 is : " + playerRandomNumber2);

                                if (playerRandomNumber1 == 1 && playerRandomNumber2 == 1)
                                {
                                    playerTotalScore = 0;
                                    Console.WriteLine("Score of player A is : " + playerTotalScore);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Score of player A is : " + playerTotalScore);
                                    Console.WriteLine();
                                }



                            }
                            while (playerRandomNumber1 == playerRandomNumber2);





                        }

                        else
                        {
                            Console.WriteLine("Dice 1 is : " + playerRandomNumber1);
                            Console.WriteLine("Dice 2 is : " + playerRandomNumber2);
                            playerTotalScore = 0;
                            Console.WriteLine("Score of player A is : " + playerTotalScore);
                            Console.WriteLine();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Dice 1 is : " + playerRandomNumber1);
                        Console.WriteLine("Dice 2 is : " + playerRandomNumber2);
                        Console.WriteLine("Score of player A is : " + playerTotalScore);
                        Console.WriteLine();
                    }

                    enemyRandomNumber1 = random.Next(1, 7);
                    enemyRandomNumber2 = random.Next(1, 7);
                    enemyPoint = enemyRandomNumber1 + enemyRandomNumber2;
                    enemyTotalScore = enemyTotalScore + enemyPoint;

                    if (enemyRandomNumber1 == enemyRandomNumber2)
                    {
                        if (enemyRandomNumber1 > 1 && enemyRandomNumber2 > 1)
                        {
                            Console.WriteLine("Dice 1 is : " + enemyRandomNumber1);
                            Console.WriteLine("Dice 2 is : " + enemyRandomNumber2);
                            Console.WriteLine("Score of player B is : " + enemyTotalScore);
                            Console.WriteLine();

                            do
                            {
                                enemyRandomNumber1 = random.Next(1, 7);
                                enemyRandomNumber2 = random.Next(1, 7);
                                enemyPoint = enemyRandomNumber1 + enemyRandomNumber2;
                                enemyTotalScore = enemyTotalScore + enemyPoint;

                                Console.WriteLine("Dice 1 is : " + enemyRandomNumber1);
                                Console.WriteLine("Dice 2 is : " + enemyRandomNumber2);

                                if (enemyRandomNumber1 == 1 && enemyRandomNumber2 == 1)
                                {
                                    enemyTotalScore = 0;
                                    Console.WriteLine("Score of player B is : " + enemyTotalScore);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Score of player B is : " + enemyTotalScore);
                                    Console.WriteLine();
                                }



                            }
                            while (enemyRandomNumber1 == enemyRandomNumber2);



                        }

                        else
                        {
                            Console.WriteLine("Dice 1 is : " + enemyRandomNumber1);
                            Console.WriteLine("Dice 2 is : " + enemyRandomNumber2);
                            enemyTotalScore = 0;
                            Console.WriteLine("Score of player B is : " + enemyTotalScore);
                            Console.WriteLine();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Dice 1 is : " + enemyRandomNumber1);
                        Console.WriteLine("Dice 2 is : " + enemyRandomNumber2);
                        Console.WriteLine("Score of player B is : " + enemyTotalScore);
                        Console.WriteLine();
                    }




                }
                Console.ReadKey();
            }
        }
    }


    

