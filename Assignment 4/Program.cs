namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            /* Console.Write("Enter an Number: ");
              string NumberInput = Console.ReadLine();

              if (int.TryParse(NumberInput, out int Num) && Num > 0)
              {
                  Console.WriteLine("Output:");
                  for (int i = 1; i <= Num; i++)
                  {
                      Console.Write(i);
                      if (i < Num)
                      {
                          Console.Write(",");
                      }
                  }
              }
            */
            #endregion

            #region 2-Write a program that allows the user to insert an integer then print a multiplication table up to 12
            /*
            Console.Write("Enter a Number: ");
            string NumberInput = Console.ReadLine();

            if (int.TryParse(NumberInput, out int number))
            {
                Console.WriteLine($"Number is {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(number * i);
                    if (i < 12)
                    {
                        Console.Write(" , ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Number");
            }
            */
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
             Console.Write("Enter a Number: ");
             string NumberInput = Console.ReadLine();

             if (int.TryParse(NumberInput, out int Num) && Num > 1)
             {
                 Console.WriteLine($"Even numbers between 1 and {Num} :");
                 for (int i = 2; i <= Num; i += 2) 
                 {
                     Console.Write(i);
                     if (i + 2 <= Num)
                     {
                         Console.Write(" , "); 
                     }
                 }
             }
            */
            #endregion

            #region 4-Write a program that takes two integers then prints the power
            /*
            Console.Write("Enter Num01: ");
            string Num01 = Console.ReadLine();

            Console.Write("Enter Num02: ");
            string Num02 = Console.ReadLine();

            if (int.TryParse(Num01, out int baseNumber) && int.TryParse(Num02, out int exponent))
            {
                int result = 1;
                for (int i = 1; i <= exponent; i++)
                {
                    result *= baseNumber;
                }

                Console.WriteLine($"{result}");
            }
         */
            #endregion

            #region 5- Write a program to allow the user to enter a string and print the REVERSE of it.
            /*
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumber = new string(charArray);

            Console.WriteLine($"Reversed Number: {reversedNumber}");
            */
            #endregion

            #region 6- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
            Console.Write("Input starting number of range: ");
            string startInput = Console.ReadLine();
            Console.Write("Input ending number of range: ");
            string endInput = Console.ReadLine();

            if (int.TryParse(startInput, out int start) && int.TryParse(endInput, out int end) && start > 0 && end > 0 && start <= end)
            {
                Console.WriteLine($"The prime numbers between {start} and {end} are:");
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
           
        }
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
            */
            #endregion

            #region 8- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            /*
              Console.Write("Enter the size of the matrix (n): ");
              int N = int.Parse(Console.ReadLine());

              for (int i = 0; i < N; i++)
              {
                  for (int j = 0; j < N; j++)
                  {
                      if (i == j)
                      {
                          Console.Write("1 ");
                      }
                      else
                      {
                          Console.Write("0 ");
                      }
                  }

                  Console.WriteLine();
              }
            */
            #endregion

            #region 10- Write C# program that take two string variables and print them as one variable 
            /*
             Console.Write("Enter the first string: ");
             string first = Console.ReadLine();

             Console.Write("Enter the Last string: ");
             string Last = Console.ReadLine();

             string Total = first + Last;

             Console.WriteLine(Total);
            */
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            /*
              Console.Write("Enter the size of the matrix (n): ");
              int N = int.Parse(Console.ReadLine());

              for (int i = 0; i < N; i++)
              {
                  for (int j = 0; j < N; j++)
                  {
                      if (i == j)
                      {
                          Console.Write("1 ");
                      }
                      else
                      {
                          Console.Write("0 ");
                      }
                  }

                  Console.WriteLine();
              }
            */
            #endregion

            #region  12- Write a program in C# Sharp to find the sum of all elements of the array.
            /*
            Console.Write("Enter the number of elements in the array: ");
            int X = int.Parse(Console.ReadLine());

            int[] array = new int[X];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < X; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");
        }
            */

            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            /*
            Console.Write("Enter the number of elements in the array: ");
            int X = int.Parse(Console.ReadLine());

            int[] array = new int[X];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < X; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < X; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"The max: {max}");
            Console.WriteLine($"The min: {min}");
        */
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            /*
            Console.Write("Enter the number of elements in the array: ");
            int X = int.Parse(Console.ReadLine());

            if (X < 2)
            {
                Console.WriteLine("Array must contain at least two elements.");
                return;
            }

            int[] array = new int[X];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < X; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < X; i++)
            {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                else if (array[i] > secondLargest && array[i] != largest)
                {
                    secondLargest = array[i];
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no second largest element (all elements may be equal).");
            }
            else
            {
                Console.WriteLine($"The second largest element is: {secondLargest}");
            }

            */
            #endregion

            #region 19- Write a Program to Print One Dimensional Array in Reverse Order
            /*
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"NUM {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            */
            #endregion

        }
    }
}

