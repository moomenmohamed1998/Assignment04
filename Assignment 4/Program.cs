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

            Console.Write("Enter a Number: ");
            string NumberInput = Console.ReadLine();

            // Parse the input into an integer
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
            #endregion

        }
    }
}
