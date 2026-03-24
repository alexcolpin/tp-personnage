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

    public virtual void Afficher()
    {
        Console.WriteLine("Nom : " + nom + ", PV : " + pointsDeVie);
    }

    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
    }

public void RecevoirDegats(int degats, int reduction)
    {
        pointsDeVie -= (degats - reduction);
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

    public override void Afficher()
    {
        Console.WriteLine("Guerrier : " + nom + ", PV : " + pointsDeVie + ", Armure : " + armure);
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

    public override void Afficher()
    {
        Console.WriteLine("Magicien : " + nom + ", PV : " + pointsDeVie + ", Puissance magique : " + puissanceMagique);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personnage p = new Personnage("Jean", 100);

        p.RecevoirDegats(20);
        p.Afficher();

        p.RecevoirDegats(20, 10);
        p.Afficher();
    }
}