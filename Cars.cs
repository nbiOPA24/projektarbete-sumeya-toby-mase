using System;

class Cars
{
  
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }

    public Cars(string model, int year, string color, int price)
    {
        Model = model;
        Year = year;
        Color = color;
        Price = price;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Year: {Year}, Color: {Color}, Price: {Price} SEK");
    }
}