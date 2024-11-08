public class Säljare : Användare 
{
    public Säljare(string namn) : base(namn, "Säljare") { }

    public Bil LäggTillBil(string märkte, int årsmodell, int miltal, string växellåda)
    {
        return new Bil(märkte, årsmodell, miltal, växellåda, "Tillgänglig");
    }
}