class Program
{
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
                // default: Console.WriteLine("Ogiltigt val. Försök igen."); break; 
            }
        } 
    }

    
    
    


    static void KöpareMeny() 
    {
        Console.Clear(); 
        Console.WriteLine("Köpare Meny"); 
        Console.WriteLine("1. Visa lagerstatus"); 
        Console.WriteLine("2. Gå tilbaka till huvudmenyn"); 
        
        var choice = Console.ReadLine(); 
        switch (choice)
        {
            case "1":
                VisaLagerstatus(); 
                break; 
            case "2": 
                return; 
        }
    }



    static void SäljareMeny()
    {
        Console.Clear(); 
        Console.WriteLine("Säljare Meny"); 
        Console.WriteLine("1. Visa lagerstatus"); 
        Console.WriteLine("2. Lägg til bil till lager"); 
        Console.WriteLine("3. Gå tillbaka till huvudmenyn"); 

        var choice = Console.ReadLine(); 
        switch (choice)
        {
            case "1":
                VisaLagerstatus(); 
                break; 
            
        }
    }

    static void PersonalMeny() 
    {
        Console.Clear(); 
        Console.WriteLine("Personal Meny:"); 
        Console.WriteLine("Säljare Meny"); 
        Console.WriteLine("1. Visa lagerstatus"); 
        Console.WriteLine("2. Uppdatera lager"); 
        Console.WriteLine("3. Visa försäljningshistorik"); 
        Console.WriteLine("4. Gå tilbaka till huvudmenyn"); 

        var choice = Console.ReadLine(); 
        switch (choice)
        {
            case "1":
                VisaLagerstatus(); 
                break; 
                
        }

    }

    static void VisaLagerstatus()
    {
        Console.Clear(); 
        Console.WriteLine("Lagerstatus:"); 
        foreach (var bil in lager)
        {
            // bil.Visainfo(); 
        }
    }
}