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

    public void Afficher()
    {
        Console.WriteLine("Nom : " + nom + ", PV : " + pointsDeVie);
    }
}

class Guerrier : Personnage
{
    protected int armure;

    public Guerrier(string nom, int pointsDeVie, int armure)
        : base(nom, pointsDeVie)
    {
        this.armure = armure;
    }
}

class Magicien : Personnage
{
    protected int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int puissanceMagique)
        : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrier g = new Guerrier("Arthur", 100, 20);
        Magicien m = new Magicien("Merlin", 80, 50);

        g.Afficher();
        m.Afficher();
    }
}