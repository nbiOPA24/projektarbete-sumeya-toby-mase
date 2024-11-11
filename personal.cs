namespace Bilfirma
{

public class Personal
{
public string Namn {get; set}
public string Roll {get; set;}
public int behörighetsnivå {get; set;}

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




}
}
}