using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Cars> carList = new List<Cars>
        {
            new Cars("Volvo", 2020, "Red", 250000),
            new Cars("Toyota", 2018, "Blue", 180000),
            new Cars("Ford", 2022, "Black", 300000),
            new Cars("BMW", 2021, "White", 350000),
            new Cars("Audi", 2019, "Gray", 320000),
            new Cars("Mercedes", 2022, "Silver", 450000),
            new Cars("Honda", 2017, "Green", 170000),
            new Cars("Nissan", 2023, "Blue", 280000),
            new Cars("Tesla", 2022, "Black", 500000)
        };

    
        bool running = true;
        while (running)
        {
            Console.WriteLine("Välkommen till Bilfirman! Välj ett alternativ:");
            Console.WriteLine("1. Köpare");
            Console.WriteLine("2. Säljare");
            Console.WriteLine("3. Personal");
            Console.WriteLine("4. Avsluta");
            Console.Write("Ange ditt val (1-4): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowCars(carList); 
                    break;
                case "2":
                    Console.WriteLine("Säljare är under utveckling.");
                    break;
                case "3":
                    Console.WriteLine("Personal är under utveckling.");
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Tack för besöket!");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
            
            Console.WriteLine(); 
        }
    }

   
    static void ShowCars(List<Cars> carList)
    {
        Console.WriteLine("\nLista på bilar:");
        foreach (Cars car in carList)
        {
            car.DisplayInfo();
        }
    }
}
