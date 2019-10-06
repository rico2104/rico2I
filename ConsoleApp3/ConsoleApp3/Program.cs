using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int decade = 10;


       

            Console.WriteLine("Please enter a number");


            long DateEntryAndConvertToLong()
            {
                long inputNumber;
                String inputDate = Console.ReadLine();

                bool result = false;
                do
                {
                    result = Int64.TryParse(inputDate, out inputNumber);
                    if (!result)
                    {
                        Console.WriteLine("You have entered incorrect date. Try again");
                        inputDate = Console.ReadLine();
                      
                    }
                    if (inputNumber < 0)
                    {
                        Console.WriteLine("You have entered incorrect date. Try again");
                        inputDate = Console.ReadLine();
                        result = false;
                    }
                } while (!result);

                return inputNumber;
            }

            long inputDigit = DateEntryAndConvertToLong();




            //пункт 1
            int HowMuchNumbers()
            {
             
                int numberOfDigits = 0;
                if (inputDigit == 1 || inputDigit == 0)
                {
                    numberOfDigits = 1;
                }
                else
                {
                    for (long i = 1; i < inputDigit; i = i * decade)
                    {
                        numberOfDigits = numberOfDigits + 1;
                    }
                }
                return numberOfDigits;
            }
           

            //підрахувати степінь
            long CalculateDegree()
            {
                long degree = decade;
                for (int i = 1; i < HowMuchNumbers()-1; i++)
                {
                    degree = degree * decade;
                }
                return degree;
            }
            // повертає число  потрібного індексу
            int ReturnINumber(long numeric, int neededNumber)
            {
                
                int digitWithNeededNumber=0;
                long degree = CalculateDegree();
                for (int i = 0; i < HowMuchNumbers(); ++i)
                {
                    digitWithNeededNumber = (int)(numeric / degree);
                    if(i== neededNumber - 1)
                    {
                        break;
                    }
                    numeric = numeric - (digitWithNeededNumber * degree);
                    degree = degree / decade;
                }
                return digitWithNeededNumber;

            }

            //пункт 2
            void АrrayOfNumbers(long numeric)
            {
                int[] elementOfInput = new int[HowMuchNumbers()];
                int needeNumber = 1;

               for(int i=0;i< elementOfInput.Length; i++)
                {
                    elementOfInput[i] = ReturnINumber(numeric, needeNumber);
                    needeNumber = needeNumber + 1;
                  
                }

                for (int i = 0; i < elementOfInput.Length; i++)
                {
                    Console.Write($" { elementOfInput[i]}");
                }

            }

            // пункт 3
            float ArithmeticMean(long numeric)
            {
                float arithmeticMean=0;
                int sum= 0;
                for(int i = 1; i <= HowMuchNumbers(); i++)
                {
                    sum = sum + ReturnINumber(numeric, i);

                }
                arithmeticMean = (float)sum / HowMuchNumbers();


                return arithmeticMean;

            }
           
            // пункт 4
            double GeometricMean(long numeric)
            {
                double geometricMean = 0;
                double product = 1;
                for (int i = 1; i <= HowMuchNumbers(); i++)
                {
                    product = product * ReturnINumber(numeric, i);

                }

                geometricMean = Math.Pow(product, (double)1 / HowMuchNumbers());

                return geometricMean;
               

            }

            // пункт 5
            long Factorial(long numeric)
            {
                long factorial = 1;
                
                while (numeric > 0)
                {

                    factorial = factorial * numeric ;
                    
                    numeric = numeric - 1;
                }

                return factorial;
            }

            // пункт 6 
            long SumEvenNumbers(long numeric)
            {
                long sum = 0;
                for (int i = 1; i <= numeric; i++)
                {
                    if(i % 2 == 0) 
                    {
                        sum = sum + i;

                    }

                }
                return sum;
            }

            // пункт 7
            long SumOddNumbers(long numeric)
            {
                long sum = 0;
                for (int i = 1; i <= numeric; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum = sum + i;

                    }

                }
                return sum;
            }

            //пункт 8
            long OverloadedSumEvenNumbers(long startOfReference , long numeric)
            {
                long sum = 0;
                while (startOfReference<= numeric) {
                    if (startOfReference % 2 == 0)
                    {
                        sum = sum + startOfReference;

                    }
                    startOfReference++;
                }
                
                return sum;
            }
            //пункт 9
            long OverloadedSumOddNumbers(long startOfReference, long numeric)
            {
                long sum = 0;
                while (startOfReference <= numeric)
                {
                    if (startOfReference % 2 == 1)
                    {
                        sum = sum + startOfReference;

                    }
                    startOfReference++;
                }

                return sum;
            }

            Console.WriteLine($"Number of digits in the entered number  = {HowMuchNumbers()}");
            Console.Write($"Array of digits of the entered number - ");
            АrrayOfNumbers(inputDigit);
            Console.WriteLine();
            Console.WriteLine($"The arithmetic mean of the entered number = {ArithmeticMean(inputDigit)}");
            Console.WriteLine($"The geometric mean of the entered number = {GeometricMean(inputDigit)}");
            Console.WriteLine($"Factorial of the entered number = {Factorial(inputDigit)}");
            Console.WriteLine($"The sum of all even numbers from 1 to the entered number = {SumEvenNumbers(inputDigit)}");
            Console.WriteLine($"The sum of all odd numbers from 1 to the entered number = {SumOddNumbers(inputDigit)}");
            Console.WriteLine("Please enter a range of numbers (by two numbers)");
            Console.WriteLine($"enter first number");
            long n = DateEntryAndConvertToLong();
            Console.WriteLine($"enter second number");
            long m = DateEntryAndConvertToLong();

            Console.WriteLine($"The sum of all even numbers in range of numbers = {OverloadedSumEvenNumbers(n,m)}");
            Console.WriteLine($"The sum of all odd numbers in range of numbers = {OverloadedSumOddNumbers(n, m)}");
            Console.ReadKey();
        }
    }
}
