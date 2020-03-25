using System;

namespace Practical_Exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int weight = int.Parse(Console.ReadLine());

            //Console.WriteLine( weight >= 500);

            //char gender = 'm';

            //Console.WriteLine(gender == 'f');

            //double lenght = 1.570;

            //Console.WriteLine(lenght > 1.621);

            //int a = 5;
            //int b = 7;

            //bool result = (b > a) && (a + b < a * b);

            //Console.WriteLine(result);

            //string str = "word";
            //string str2 = "word";

            //Console.WriteLine(str == str2); 
            //Console.WriteLine(str.Equals(str2));

            //string str = "beer";
            //string str2 = str;
            //string str3 = "bee";

            //Console.WriteLine($"str = {str}");
            //Console.WriteLine($"str2 = {str2}");
            //Console.WriteLine($"str3 = {str3}");

            //Console.WriteLine(str == str2);
            //Console.WriteLine(str == str3);

            //Console.WriteLine((object)str == (object)str2);
            //Console.WriteLine((object)str == (object)str3);

            //int ageOfBoy = int.Parse(Console.ReadLine());
            //int ageOfGirl = int.Parse(Console.ReadLine());

            //if (ageOfBoy > 18 && ageOfGirl > 18)
            //{
            //    Console.WriteLine("Enter");
            //}
            //else
            //{
            //    Console.WriteLine("Leave");
            //}

            //int x = int.Parse(Console.ReadLine());

            //if (x < 14)
            //{
            //    Console.WriteLine("Малолетен");
            //}
            //else if (x >= 14 && x < 18)
            //{
            //    Console.WriteLine("Непълнолетен");
            //}
            //else if (x >= 18 && x <= 65)
            //{
            //    Console.WriteLine("Икономчески активно население");
            //}
            //else
            //{
            //    Console.WriteLine("Пенсионер");
            //}


            //int ageOfBoy = int.Parse(Console.ReadLine());
            //int ageOfGirl = int.Parse(Console.ReadLine());

            //if (ageOfBoy < 18 && ageOfGirl < 18)
            //{
            //    Console.WriteLine("Leave");
            //}
            //else
            //{
            //    if (ageOfBoy >= 18)
            //    {
            //        Console.WriteLine("Enter");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Leave");
            //    }        
            //}

            //int x = int.Parse(Console.ReadLine());

            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Едно");
            //        break;
            //    case 2:
            //        Console.WriteLine("Две");
            //        break;
            //    case 3:
            //        Console.WriteLine("Три");
            //        break;
            //    case 4:
            //        Console.WriteLine("четири");
            //        break;
            //    case 5:
            //        Console.WriteLine("пет");
            //        break;
            //    case 6:
            //        Console.WriteLine("шест");
            //        break;
            //    case 7:
            //        Console.WriteLine("седем");
            //        break;
            //    case 8:
            //        Console.WriteLine("осем");
            //        break;
            //    case 9:
            //        Console.WriteLine("девет");
            //        break;
            //    default:
            //        Console.WriteLine("Моля въведете цяло число между 0 и 9");
            //        break;
            //}


            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            string result = "най-голямото число е {0}";

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine(result, x);
                }
                else
                {
                    Console.WriteLine(result, z);
                }
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine(result, y);
                }
                else
                {
                    Console.WriteLine(result, z);
                }

            }


            //if (x > y && x > z)
            //{
            //    Console.WriteLine(result, x);
            //}
            //else if (x < y && y > z)
            //{
            //    Console.WriteLine(result, y);
            //}
            //else if (x<y && y<z)
            //{
            //    Console.WriteLine(result, z);
            //}


        }
    }
}
