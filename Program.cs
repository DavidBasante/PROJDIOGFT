using PROJDIOGFT.Entities;

Knight Arus = new Knight("Arus", 23, "Knight");
Wizard Hades = new Wizard("Hades", 40, "Dark Star");
Hunter FacelessVoid = new Hunter("Varus", 30, "Spectro");


Console.WriteLine(Hades.Attack(6));
Console.WriteLine(Arus.Attack());
Console.WriteLine(FacelessVoid.Attack());


 