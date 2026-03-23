namespace tp_personnages;

using System;

class Personnage
{
    protected string nom;
    protected int pointsDeVie;

    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }

    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
    }

    public void Afficher()
    {
        Console.WriteLine("Nom : " + nom + ", PV : " + pointsDeVie);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personnage p = new Personnage("Jean", 100);
        p.Afficher();

        p.RecevoirDegats(20);
        p.Afficher();
    }
}