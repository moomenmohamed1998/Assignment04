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
         
            #endregion

        }
    }
}
