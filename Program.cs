using System.Runtime.CompilerServices;

namespace Bilfirma;

class Program
{
    static List<Car> lager = new List<Car>
        {
           
            // Lista över bilar som finns nu i lagret
            
        };
    static int maxAntalBilar = 20;
    static void Main() 
    {
         

        while(true)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till våran Bilfirma!"); 
            Console.WriteLine("Välj din roll:"); 
            Console.WriteLine("1. Köpare");
            Console.WriteLine("2. Säljare"); 
            Console.WriteLine("3. Personal"); 
            Console.WriteLine("4. Avsluta"); 

            var choice = Console.ReadLine(); 

            switch (choice) 
            {
                case "1":
                    KöpareMeny(); 
                    break;
                case "2":
                    SäljareMeny(); 
                    break; 
                case "3": 
                    PersonalMeny(); 
                    break; 
                case "4": 
                    Console.WriteLine("Avslutar programmet..."); 
                    return; 
                default: 
                    Console.WriteLine("Ogiltigt val. Försök igen."); 
                    break; 
            }
        } 
    }

    
    
    


    static void KöpareMeny() 
    {
        Köpare köpare = new Köpare("Kund")
        Console.Clear(); 
        Console.WriteLine("Köpare Meny:");  
        köpare.VisaLagerStatus(lager); 
        Console.Readkey(); 

        // Funktion för att köpa bilar
        // ( Ta bort bilar från lager lista )
        // ( Lägg till bil i såldaBilar lista )
    }



    static void SäljareMeny()
    {
        Säljare säljare = new Säljare("Säljare"); 
        Console.Clear(); 
        Console.WriteLine("Säljare Meny:");  
        Console.WriteLine("Lägg till din bil för att säljas!"); 
        Console.Write("Märke: "); 
        
        // Funktion för att sälja sin bil 
        // ( Lägg till bil i lager lista )
        // 
            
        
    }

    static void PersonalMeny() 
    {
        Personal personal = new Personal("Admin"); 
        Console.Clear(); 
        Console.WriteLine("Personal Meny:");  
        Console.WriteLine("1. Visa lagerstatus"); 
        Console.WriteLine("2. Uppdatera bilstatus"); 
        Console.WriteLine("3. Visa försäljningshistorik"); 
        Console.WriteLine("4. Gå tilbaka till huvudmenyn");

        string choice = Console.ReadLine(); 
        switch (choice) 
        {
            case "1" 
                // kalla på personal klassen -> KontrolleraLagerStatus

            case "2"
                

            case "3" 


            case "4"

            
            default: 
                Console.WriteLine("Ogiltligt val."); 
                break; 

        }
        

        

    }

    
}