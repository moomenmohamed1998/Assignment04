namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loop statment
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}
            #endregion

            #region for-foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}


            //foreach (int Number in Numbers)
            //{
            //    Console.WriteLine(Number);
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    //Numbers[i] += 10;
            //    if (Numbers[i] == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(Numbers[i]);
            //}
            #endregion

            #region While - Do While
            int Number;
            bool flag;
            do
            {
                Console.WriteLine("Enter Even Number");
                //Number = int.Parse(Console.ReadLine());
                //int.TryParse(Console.ReadLine(), out Number);
                flag = int.TryParse(Console.ReadLine(), out Number);
            } while (Number % 2 == 1 || !flag);

            Console.WriteLine($"{Number} Is Even");

            #endregion
        }
    }
}
