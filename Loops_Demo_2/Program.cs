using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int counter = 0;

        //while (counter < 10)
        //{
        //    Console.WriteLine("Hello");

        //    counter++;
        //}

        //Console.WriteLine("End of counting");

        //for (int i = 1; i <= 50; i *= 2)
        //{
        //    Console.Write(i + " ");
        //}

        //for (int i = 0, y = 0; i < 10 && y < 20; i++, y+=i)
        //{
        //    Console.WriteLine($"i = {i} y = {y}");
        //}
        //int n = int.Parse(Console.ReadLine());


        //int sum = 0;

        //for (int i = 1; i < n; i += 2)
        //{
        //    Console.WriteLine("----------------------------------");
        //    Console.WriteLine($"i = {i}");

        //    if (i % 7 == 0)
        //    {
        //        Console.WriteLine("Това число се дели на 7 без остаттък");
        //        break;
        //    }

        //    sum += i;
        //    Console.WriteLine($"sum = {sum}");
        //}

        //Console.WriteLine();
        //Console.WriteLine("------FINAL-------");
        //Console.WriteLine(sum);

        //var car1 = new Car() { HP = 100, Make = "Opel", Model = "Astra" };
        //var car2 = new Car() { HP = 200, Make = "VW", Model = "Golf" };
        //var car3 = new Car() { HP = 250, Make = "BMW", Model = "335xi" };

        //List<Car> cars = new List<Car>() { car1, car2, car3 };
        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 , 8 , 9, 10};

        //foreach (Car car in cars)
        //{
        //    Console.WriteLine($"Make: {car.Make}; Model: {car.Model}; HP: {car.HP}");
        //    car.StartEngine();
        //}

        //for (int i = 0; i < cars.Count; i++)
        //{
        //    Console.WriteLine($"Make: {cars[i].Make}; Model: {cars[i].Model}; HP: {cars[i].HP}");
        //    cars[i].StartEngine();
        //}


        string[] towns = { "Sofia", "Plovdiv", "Varna", "Burgas" };

        foreach (var town in towns)
        {
            Console.WriteLine(town);
        }

        var car1 = new Car()
        {
            HP = 100,
            Make = "Opel",
            Model = "Astra",
            BrokenParts = new List<Part>()
            {
                new Part()
                {
                    Name = "калинк",
                    Shops = new List<string>() {"Автохит", "Интеркас"}
                },
                 new Part()
                {
                    Name = "Капак",
                    Shops = new List<string>() {"Тех-ко", "Авто плюс"}
                }
            }
        };

        var car2 = new Car()
        {
            HP = 200,
            Make = "VW",
            Model = "Golf",
            BrokenParts = new List<Part>()
            {
                new Part()
                {
                    Name = "броня",
                    Shops = new List<string>() {"Ауто партнърс", "Ауто про"}
                },
                 new Part()
                {
                    Name = "врата",
                    Shops = new List<string>() {"Аугсбутг", "Елит кар"}
                }
            }
        };

        var car3 = new Car()
        {
            HP = 250,
            Make = "BMW",
            Model = "335xi",
            BrokenParts = new List<Part>()
            {
                new Part()
                {
                    Name = "полуоска",
                    Shops = new List<string>() {"Автохит", "Ауто Бавария"}
                },
                 new Part()
                {
                    Name = "кардан",
                    Shops = new List<string>() {"Авто Плюс", "Интеркас"}
                }
            }
        };

        List<Car> cars = new List<Car>() { car1, car2, car3 };

        Console.WriteLine("Г-н Управител....");

        foreach (var car in cars)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Кола с марка: {car.Make} {car.Model} влезе в сервиза на дата {DateTime.Now.Date}");
            Console.WriteLine($"Колата е с мощност {car.HP}");

            Console.WriteLine("Трябва да се сменят следните части:");
            Console.WriteLine();

            foreach (var part in car.BrokenParts)
            {
                Console.WriteLine($"--{part.Name}");
                Console.WriteLine("Частта може да бъде намерна в магазин");
                Console.WriteLine();

                foreach (var shop in part.Shops)
                {
                    Console.WriteLine($"----{shop}");
                }
            }

            Console.WriteLine("--------------------------------");
        }




    }
}
public class Car
{
    public int HP { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine($"{Make} {Model} started the engine");
    }

    public List<Part> BrokenParts { get; set; } = new List<Part>();


}

public class Part
{
    public string Name { get; set; }

    public List<string> Shops { get; set; } = new List<string>();
}
