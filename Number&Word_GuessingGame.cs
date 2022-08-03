using System;
using System.Collections.Generic;

namespace Practice_Alnick2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //program that will ask user (number or word)
            //user will enter the size
            //user will input the data
            //user will guess the data that is choosen by the program randomly
            //user will have 3 tries

            Console.WriteLine("Choose between Number and Word");
            Console.WriteLine("1. Number \n2. Word");
            Console.Write("\nChoose: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch(choose)
            {
                case 1:
                    Console.Write("Enter size: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the {size} numbers: ");

                    var numbers = new List<int>();
                    for(int i=0; i<size; i++)
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(input);
                    }

                    Console.WriteLine("\nContent of List: ");
                    foreach(var i in numbers)
                    {
                        Console.WriteLine(i);
                    }

                    Random kleyo = new Random();
                    var kleyoRandom = kleyo.Next(numbers.Count);

                    int lifePoint = 3;

                    while (lifePoint != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Guesses left: {lifePoint}");
                        Console.Write("\nGuess a number: ");
                        int guess = Convert.ToInt32(Console.ReadLine());

                        if (guess == numbers[kleyoRandom])
                        {
                            Console.WriteLine("Correct!");
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Wrong!");
                            lifePoint--;
                            
                        }
                    }
                    if (lifePoint == 0)
                    {
                        Console.WriteLine("\n\nGame Over!");
                        Console.WriteLine($"The Correct Answer is: {numbers[kleyoRandom]}");
                    }
                    break;

                case 2:
                    Console.Write("Enter size: ");
                    int size2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Enter the {size2} words: ");
                    var words = new List<string>();

                    for(int i=0; i<size2; i++)
                    {
                        string inputtedWords = Console.ReadLine();
                        words.Add(inputtedWords);
                    }

                    Console.WriteLine("\nContent of List: ");
                    foreach(var i in words)
                    {
                        Console.WriteLine(i);
                    }

                    Random alnick = new Random();
                    var alnickRandom = alnick.Next(words.Count);

                    int lifePoints = 3;

                    while(lifePoints != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Guesses left: {lifePoints}");
                        Console.Write("Guess a word: ");
                        string guessedWord = Console.ReadLine();

                        if (guessedWord == words[alnickRandom])
                        {
                            Console.Write("Correct!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            lifePoints--;
                        }
                    }
                    if(lifePoints == 0)
                    {
                        Console.WriteLine("\n\nGame Over!");
                        Console.WriteLine($"The Correct Answer is: {words[alnickRandom]}");
                    }
                    break;
            }
        }
    }
}
