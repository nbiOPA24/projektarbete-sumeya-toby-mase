public class Köpare : Användare 
{
    public Köpare(string namn) : base(namn, "Köpare") { }

    public void VisaLagerStatus(List<Car> lager)
    {
        Console.WriteLine("Bilar i lager: "); 
        foreach (var Car in lager)
        {
            // Car.VisaInfo();
        }
    }
}