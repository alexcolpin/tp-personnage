using System;

using System;
using System.Collections.Generic;


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
}


class Guerrier : Personnage
{
    private int armure;

    public Guerrier(string nom, int pointsDeVie, int armure)
        : base(nom, pointsDeVie)
    {
        this.armure = armure;
    }

    public void Attaquer() 
    {
        Console.WriteLine("Le guerrier attaque !");
    }

    public override void Afficher()
    {
        Console.WriteLine("Guerrier : " + nom + ", PV : " + pointsDeVie + ", Armure : " + armure);
    }
}


class Magicien : Personnage
{
    private int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int puissanceMagique)
        : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

    public void LancerSort() 
    {
        Console.WriteLine("Le magicien lance un sort !");
    }

    public override void Afficher()
    {
        Console.WriteLine("Magicien : " + nom + ", PV : " + pointsDeVie + ", Puissance magique : " + puissanceMagique);
    }

    public override string ToString()
    {
        return "Nom : " + nom + ", PV : " + pointsDeVie;
    }
}

class Archer : Personnage
{
    private int precision;

    public Archer(string nom, int pointsDeVie, int precision)
        : base(nom, pointsDeVie)
    {
        this.precision = precision;
    }

    public void Tirer()
    {
        Console.WriteLine("L'archer tire avec une précision de " + precision);
    }

    public override void Afficher()
    {
        Console.WriteLine("Archer : " + nom + ", PV : " + pointsDeVie + ", Précision : " + precision);
    }
}

class Program
{
    static void Main(string[] args)
{
    List<Personnage> personnages = new List<Personnage>();

    personnages.Add(new Guerrier("Arthur", 100, 20));
    personnages.Add(new Magicien("Merlin", 80, 50));
    personnages.Add(new Archer("Robin", 90, 75));

    foreach (Personnage p in personnages)
    {
        p.Afficher();

        if (p is Guerrier g)
            g.Attaquer();
        else if (p is Magicien m)
            m.LancerSort();
        else if (p is Archer a)
            a.Tirer();
    }
}
}