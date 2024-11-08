public class Köpare : Användare 
{
    public Köpare(string namn) : base(namn, "Köpare") { }

    public void VisaLagerStatus(List<Bil> lager)
    {
        Console.WriteLine("Bilar i lager: "); 
        foreach (var Bil in lager)
        {
            // Car.VisaInfo();
        }
    }
}