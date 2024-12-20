using System.Text;

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
            //int Number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    //Number = int.Parse(Console.ReadLine());
            //    //int.TryParse(Console.ReadLine(), out Number);
            //    flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !flag);

            //Console.WriteLine($"{Number} Is Even");

            #endregion

            #region String

            //string Name;
            //Name = new string("Ahmed");
            //Name = "Ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"name01 HC : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"name01 HC : {Name02.GetHashCode()}");


            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"name01 HC : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"name01 HC : {Name02.GetHashCode()}");

            //Name02 = Name01;

            //Console.WriteLine(" ********************** ");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"name01 HC : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"name01 HC : {Name02.GetHashCode()}");

            //Name01="mostafa";

            //Console.WriteLine(" ************* Mostafa ************* ");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"name01 HC : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"name01 HC : {Name02.GetHashCode()}");

            #endregion

            #region Styring Builder
            //StringBuilder Massage;
            //Massage = new StringBuilder("Ahmed");

            //Console.WriteLine(Massage);
            //Console.WriteLine(Massage.GetHashCode());

            //Console.WriteLine(" ");
            //Massage.Append(" Route");
            //Console.WriteLine(Massage);
            //Console.WriteLine(Massage.GetHashCode());

            #endregion

            #region Styring Builder Methods
            //StringBuilder Massage = new StringBuilder("Welcome");

            //Massage.Append("TO Route ");
            //Massage.AppendLine(" Mostafa");
            //Massage.Append("Hany");

            //Massage.Remove(0, 7);

            //Massage.Insert(0,"Hello ");
            //Console.WriteLine(Massage);

            //int Age = 10;
            //string Name = "ALi";

            //Massage.AppendFormat("name : {0} ,Age :{1}", Name, Age);
            //Massage.AppendJoin("/","Mosatfa","Hany","Mohamed",2);
            //Console.WriteLine(Massage);
            #endregion

            #region  Array 1 D
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] numbers = new int[] { 1, 2, 3 };
            //int[] number = { 1, 2, 3 };

            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);

            //int[] number = new int[3];

            //for (int i=0; i < number.Length; i++)
            //{
            //    number[i] = i + 1;

            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);

            //}

            #endregion
        }
    }
}
