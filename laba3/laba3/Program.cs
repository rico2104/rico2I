using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();


            bool FirstHalfOfMainDiagonale(int i, int j, int length)
            {
                bool result = false;
                if (i == j && i < length / 2)
                {
                    result = true;
                }

                return result;

            }
            bool FirstHalfOfLateralDiagonale(int i, int j, int length)
            {
                bool result = false;
                if (length % 2 == 0)
                {
                    if (i == length - j - 1 && i + 1 <= length / 2)
                    {
                        result = true;
                    }
                }
                else
                {
                    if (i == length - j - 1 && i <= length / 2)
                        result = true;
                }
                return result;

            }
            bool SecondHalfOfMainDiagonale(int i, int j, int length)
            {
                bool result = false;
                if (length % 2 == 0)
                {
                    if (i == j && i + 1 > length / 2)
                    {
                        result = true;
                    }
                }
                else
                {
                    if ((i == j && i > length / 2))
                    {
                        result = true;
                    }
                }
                return result;

            }
            bool SecondHalfOfLateralDiagonale(int i, int j, int length)
            {
                bool result = false;
                if (length % 2 == 0)
                {
                    if (i == length - j - 1 && i >= length / 2)
                    {
                        result = true;
                    }
                }
                else
                {
                    if (i == length - j - 1 && i >= length / 2)
                        result = true;
                }
                return result;

            }

            bool Area1(int i, int j, int length)
            {
                bool result = false;
                if (j <= i)
                {
                    result = true;
                }
                return result;
            }
            bool Area2(int i, int j, int length)
            {
                bool result = false;
                if (j >= i)
                {
                    result = true;
                }
                return result;
            }
            bool Area3(int i, int j, int length)
            {
                bool result = false;
                if (j < length - i)
                {
                    result = true;
                }
                return result;
            }
            bool Area4(int i, int j, int length)
            {
                bool result = false;
                if (j >= length - i - 1)
                {
                    result = true;
                }
                return result;
            }
            bool Area7(int i, int j, int length)
            {
                bool result = false;
                if (Area2(i, j, length))
                {
                    result = false;
                }
                else
                {
                    if (Area4(i, j, length))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area8(int i, int j, int length)
            {
                bool result = false;
                if (Area1(i, j, length))
                {
                    result = false;
                }
                else
                {
                    if (Area3(i, j, length))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area9(int i, int j, int length)
            {
                bool result = false;
                if (Area3(i, j, length))
                {
                    result = false;
                }
                else
                {
                    if (Area2(i, j, length))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area10(int i, int j, int length)
            {
                bool result = false;
                if (Area1(i, j, length))
                {
                    result = false;
                }
                else
                {
                    if (Area4(i, j, length))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area11(int i, int j, int length)
            {
                bool result = false;
                if (!Area8(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area12(int i, int j, int length)
            {
                bool result = false;
                if (!Area7(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area13(int i, int j, int length)
            {
                bool result = false;
                if (!Area9(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area14(int i, int j, int length)
            {
                bool result = false;
                if (!Area10(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area5(int i, int j, int length)
            {
                bool result = false;
                if (!Area11(i, j, length))
                {
                    result = true;
                }
                else
                {
                    if (!Area12(i, j, length))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }
            bool Area6(int i, int j, int length)
            {
                bool result = false;
                if (!Area13(i, j, length))
                {
                    result = true;
                }
                else
                {
                    if (!Area14(i, j, length))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                if (FirstHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                if (FirstHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfLateralDiagonale(i, j, length))
                {
                    result = true;
                }
                if (SecondHalfOfMainDiagonale(i, j, length))
                {
                    result = true;
                }
                return result;
            }

            int ConvertToInt()
            {
                int inputNumber;

                String inputDate = Console.ReadLine();

                bool result = false;
                do
                {
                    result = Int32.TryParse(inputDate, out inputNumber);
                    if (!result)
                    {
                        Console.WriteLine("You have entered incorrect date. Try again");
                        inputDate = Console.ReadLine();

                    }
                    
                } while (!result);

                return inputNumber;
            }

            Console.WriteLine("Specify the length of the side of the area ");
            int arraySize = ConvertToInt();


            int[,] array = new int[arraySize, arraySize];
            char[,] arrayChar = new char[arraySize, arraySize];
            char[,] arrayEnglishChar = new char[arraySize, arraySize];



            int SelectNumberArea()
            {
                Console.WriteLine("Select an area number (form 1 to 14)");
                int numberArea = 0;
                numberArea = ConvertToInt();
                while(numberArea < 1 || numberArea > 14)
                {
                    Console.WriteLine("You have entered incorrect date. Try again");
                    numberArea = ConvertToInt();
                }

                return numberArea;
            }
    
            int nubmerArea = SelectNumberArea();
            bool SelectedArea(int nubmer, int i, int j, int length)
            {
                bool result = false;
                  
                switch (nubmerArea)
                {
                    case 1:
                        result = Area1(i, j, length);
                        break;
                    case 2:
                        result = Area2(i, j, length);
                        break;
                    case 3:
                        result = Area3(i, j, length);
                        break;
                    case 4:
                        result = Area4(i, j, length);
                        break;
                    case 5:
                        result = Area5(i, j, length);
                        break;
                    case 6:
                        result = Area6(i, j, length);
                        break;
                    case 7:
                        result = Area7(i, j, length);
                        break;
                    case 8:
                        result = Area8(i, j, length);
                        break;
                    case 9:
                        result = Area9(i, j, length);
                        break;
                    case 10:
                        result = Area10(i, j, length);
                        break;
                    case 11:
                        result = Area11(i, j, length);
                        break;
                    case 12:
                        result = Area12(i, j, length);
                        break;
                    case 13:
                        result = Area13(i, j, length);
                        break;
                    case 14:
                        result = Area14(i, j, length);
                        break;
                }

                return result;

            }

            void FillRandom()
            {
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                      
                        if (SelectedArea(nubmerArea , i, j, arraySize) == true)
                        {
                            array[i, j] = rnd.Next(1, 10);
                        }
                        else
                        {
                            array[i, j] = 0;
                        }
                        
                            Console.Write($"{array[i, j]}   ");
                        
                    }
                    
                    Console.WriteLine();
                }
            }
            void FillEven()
            {
                Console.WriteLine("Enter numbers ( n, m ) to determine range ");
                Console.Write(" n = ");
                int n = ConvertToInt();
                Console.Write(" m = ");
                int m = ConvertToInt(); ;
                int evenDigit;
                int firstEvenDigit;
                while ((n == m && n % 2 == 1)||(n>m))
                {
                    Console.WriteLine("You have entered incorrect date. Try again");
                    Console.Write(" n = ");
                    n = ConvertToInt();
                    Console.Write(" m = ");
                    m = ConvertToInt();
                }

                if (n%2 == 0)
                {
                    firstEvenDigit = n;
                }
                else
                {
                    firstEvenDigit = n + 1;
                }
                evenDigit = firstEvenDigit;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            array[i, j] = evenDigit;
                            evenDigit = evenDigit + 2;
                            if(evenDigit >= m || evenDigit == m - 1  )
                            {
                                evenDigit = firstEvenDigit;
                            }
                        }
                        else
                        {
                            array[i, j] = 0;
                        }                    
                            Console.Write($"{array[i, j]}   ");
                       
                    }
                    Console.WriteLine();
                }
            }
            void FillOdd()
            {
                Console.WriteLine("Enter numbers ( n, m ) to determine range ");
                Console.Write(" n = ");
                int n = ConvertToInt();
                Console.Write(" m = ");
                int m = ConvertToInt(); 
                int evenDigit;
                int firstOddDigit;
                while ((n == m && n % 2 == 0) || (n > m))
                {
                    Console.WriteLine("You have entered incorrect date. Try again");
                    Console.Write(" n = ");
                     n = ConvertToInt();
                    Console.Write(" m = ");
                     m = ConvertToInt();
                }
                if (n % 2 == 1)
                {
                    firstOddDigit = n;
                }
                else
                {
                    firstOddDigit = n + 1;
                }
                evenDigit = firstOddDigit;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            array[i, j] = evenDigit;
                            evenDigit = evenDigit + 2;
                            if (evenDigit >= m || evenDigit == m - 1)
                            {

                                evenDigit = firstOddDigit;
                            }
                        }
                        else
                        {
                            array[i, j] = 0;
                        }
                        
                            Console.Write($"{array[i, j]}   ");
                        
                    }
                    Console.WriteLine();
                }
            }
            void FillEnglish()
            {
                string alphabet = "abcdefghijklmnopqrstuvwxyz";
                int randIndex;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            randIndex = rnd.Next(alphabet.Length - 1);
                            arrayEnglishChar[i, j] = alphabet[randIndex];

                        }
                      
                        Console.Write($"{arrayEnglishChar[i, j]}   ");
                        
                    }
                    Console.WriteLine();
                }
            }
            void FillSymbol()
            {
               
               
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {

                            arrayChar[i, j] = Convert.ToChar(rnd.Next(0, 255));

                        }
                      
                            Console.Write($"{arrayChar[i, j]}   ");
                        
                    }
                    Console.WriteLine();
                }
            }

            int FindMax()
            {
               int max = 0 ;

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            max = array[i, j];
                            i = arraySize;
                            break;
                        }

                    }
                }

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                           if( max < array[i, j])
                           {
                                max = array[i, j];
                           } 
                        }                   
                    }
                }
                return max; 
            }
            int FindMin()
            {
                int min = 0;

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            min = array[i, j];
                            i = arraySize;
                            break;
                        }

                    }
                }

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            if (min > array[i, j])
                            {
                                min = array[i, j];
                            }
                        }
                    }
                }
                return min;
            }
            void FindSymbol()
            {
                Console.WriteLine("Enter a character");
                String neededSymbol;
                neededSymbol = Console.ReadLine();
                while(neededSymbol.Length != 1)
                {
                    Console.WriteLine("You have entered incorrect date. Try again");
                    neededSymbol = Console.ReadLine();
                }

                char findedSymbol = neededSymbol[0];

                int counter = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            if (findedSymbol == arrayChar[i, j])
                            {
                                Console.WriteLine($"({i}, {j}) indexes of the desired character");
                                counter = counter + 1;
                            }
                        }
                    }
                }
                if(counter == 0)
                {
                    Console.WriteLine($"{findedSymbol}  does not exist in this array ");
                }
               
            }

            void Transpose(int[,] originalArray)
            {
                int[,] temp = new int[arraySize, arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                           temp[j,i] = array[i, j];
                        }
                    }
                }
                Console.WriteLine("Transpose array");
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                       
                            Console.Write($" {temp[i, j]} ");
                        
                    }
                    Console.WriteLine();
                }
            }
            void Rewrite(int[,] originalArray)
            {
                List<int> numbers = new List<int>();
                int listSize = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            numbers.Add(array[i, j]);
                            listSize = listSize + 1;
                        }
                    }
                }

                Console.WriteLine("Enter the area where you want to move the data ");
                Console.WriteLine("WARNING!!! New data may be added automatically, or some data may not be added to the new area. Due to the different sizes of areas.");
                
                nubmerArea = SelectNumberArea();
                int counter = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = 0; j < arraySize; j++)
                    {

                        if (SelectedArea(nubmerArea, i, j, arraySize) == true)
                        {
                            if (counter < listSize)
                            {
                                array[i, j] = numbers[counter];
                                counter = counter + 1;
                            }
                            else
                            {
                                array[i, j] = rnd.Next(1, 10);
                            }
                        }
                        else
                        {
                            array[i, j] = 0;
                        }

                        Console.Write($"{array[i, j]}   ");

                    }

                    Console.WriteLine();
                }
            }



            Console.WriteLine("Random Fill ");
            FillRandom();
            Console.WriteLine();
            Console.WriteLine("Fill Even ");
            FillEven();
            Console.WriteLine();
            Console.WriteLine("Fill Odd ");
            FillOdd();
            Console.WriteLine();
            Console.WriteLine("Fill Symbols ");
            FillSymbol();
            Console.WriteLine();
            Console.WriteLine("Fill English symbols ");
            FillEnglish();
            Console.WriteLine($" Max = {FindMax()}  ");
            Console.WriteLine();
            Console.WriteLine($" Min = {FindMin()}  ");
            Console.WriteLine();
            FindSymbol();
            Console.WriteLine();
            Transpose(array);
            Console.WriteLine();
            Rewrite(array);
            Console.ReadKey();
        }
    }
}
