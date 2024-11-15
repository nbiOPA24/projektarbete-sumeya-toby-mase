namespace Bilfirma
{

public class Personal
{
public string Namn {get; set}
public string Roll {get; set;}
public int Behörighetsnivå {get; set;}

public Personal(string namn, string roll, int behörighetsnivå)
{
Namn=namn
Roll=roll
Behörighetsnivå=behörighetsnivå
}
public void VisaPersonalInfo()
{
Console.Writeline($"Namn: {personal.namn}, Roll: {personal.roll}, Behörighetsnivå: {personal.behörighetsnivå}");

Public static void Main (string[] args)
{
Personal personal1 = new Personal{Mase,Lagerchef, 2} //Namnet,rollen och vilken behörighet man har då där "1" är lägsta och "2" högsta
personal1.VisaPersonalInfo();
}

public void LäggTillBil(List<cars> lager, Cars bil)
{
  if (Behörighetsnivå >=2)
  {
  lager.Add(bil);
  Console.Writeline($"{bil.model} har lagts till i lagret.");
}
else
{
    Console.Writeline("Du saknar behörighet till att lägga till bilar.");
}

public void SäljBil(List<cars> lager, List<cars> saldaBilar, Cars bil)
{
    if (behörighetsnivå >= 1)
    {
    if (lager.Contains(Bil))
    {
    lager.Remove(Bil);
    saldaBilar.Insert(0,bil);

    if (saldaBilar.Count > 5)
    {
        saldaBilar.RemoveAt(saldaBilar.Count-1);
    }

Console.Writeline($"{bil.mMdel} har sålts och tagits bort från lagret.");
    }
    else
    {
        Console.Writeline("Bilen finns inte i lagret.");
    }
}
else
{
    Console.Writeline("Du har inte behörighet att sälja bilar.");
}

public void VisaFörsäljningshistorik(List<Cars> saldaBilar)
{
    Console.Writeline("De senaste fem sålda bilarna:");
    foreach (var bil in saldaBilar)
    {
        bil.DisplayInfo();
    }
}



}
}

}


}
}
}