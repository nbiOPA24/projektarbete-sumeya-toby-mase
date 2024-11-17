public class Säljare : Användare 
{
    public Säljare(string namn) : base(namn, "Säljare") { }

    public void VisaLagerStatus(List<Bil> lager)
    {
        Console.WriteLine("Detta är våra bilar i lager just nu"); 
        foreach (var Bil in lager)
        {
            Console.WriteLine($"ID: {Bil.Id} Status: {Bil.Status} - Pris: {Bil.Pris} {Bil.Märke} {Bil.Modell} - Miltal: {Bil.Miltal} Växellåda: {Bil.Växellåda} År: {Bil.Årsmodell}");
        }
    }

    public void Säljbil(List<Bil> lager)
    {
        Console.WriteLine("Här kan du sälja din bil:");

        while (true)
        {
            Random random = new Random(); 
            int id = random.Next(1,101); 
            
            Console.WriteLine("--------------------------------------");

            // Märke
            Console.Write("Välj märke"); 
            string? märke = Console.ReadLine(); 
            if (string.IsNullOrWhiteSpace(märke))
            {
                Console.WriteLine("Error - Märket kan inte vara tomt"); 
                continue;
            } 

            // Modell
            Console.Write("Välj modell");  
            string? modell = Console.ReadLine(); 
            if (string.IsNullOrWhiteSpace(modell))
            {
                Console.WriteLine("Error - Ange en giltig Modell");
                continue;
            }

            // Miltal
            Console.Write("Ange miltal"); 
            if (!int.TryParse(Console.ReadLine(), out int miltal))
            {
                Console.WriteLine("Error - Ange ett giltigt nummer för Miltal"); 
                continue;
            }

            // Växellåda
            Console.Write("Automat/Manual?"); 
            string? växellåda = Console.ReadLine(); 
            if (string.IsNullOrWhiteSpace(växellåda))
            {
                Console.WriteLine("Error - Växellådan kan bara vara Automat eller Manual");
                continue;
            } 

            // Årsmodell
            Console.Write("Ange årsmodell"); 
            if (!int.TryParse(Console.ReadLine(), out int årsmodell))
            {
                Console.WriteLine("Error - Årsmodell måste vara ett giltigt nummer"); 
                continue;
            } 

            // Skapa och lägg till bilen
            string status = "Tillgänglig"; 
            
            Bil nyBil = new Bil(id, märke, modell, årsmodell, miltal, växellåda, null, status);
            lager.Add(nyBil);

            Console.WriteLine($"Din bil har nu lagts till i lagret med ID: {nyBil.Id}");
            break; // Avsluta loopen när allt är giltigt och bilen har lagts till
        }
    }
}
