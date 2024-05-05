public interface IKawa
{
    string Opis();
    double Cena();
}

public class ZwyklaKawa : IKawa
{
    public IKawa IKawa
    {
        get => default;
        set
        {
        }
    }

    public string Opis()
    {
        return "Kawa klasyczna";
    }

    public double Cena()
    {
        return 7;
    }
}

public class KawaZMlekiem : IKawa
{
    private readonly IKawa _kawa;

    public KawaZMlekiem(IKawa kawa)
    {
        _kawa = kawa;
    }

    public IKawa IKawa
    {
        get => default;
        set
        {
        }
    }

    public string Opis()
    {
        return _kawa.Opis() + ", mleko";
    }

    public double Cena()
    {
        return _kawa.Cena() + 2;
    }

}

public class KawaZLodem : IKawa
{
    private readonly IKawa _kawa;

    public KawaZLodem(IKawa kawa)
    {
        _kawa = kawa;
    }

    public IKawa IKawa
    {
        get => default;
        set
        {
        }
    }

    public string Opis()
    {
        return _kawa.Opis() + ", lód";
    }

    public double Cena()
    {
        return _kawa.Cena() + 2;
    }

}

public class KawaZKrememCzekoladowym : IKawa
{
    private readonly IKawa _kawa;

    public KawaZKrememCzekoladowym(IKawa kawa)
    {
        _kawa = kawa;
    }

    public IKawa IKawa
    {
        get => default;
        set
        {
        }
    }

    public string Opis()
    {
        return _kawa.Opis() + ", krem czekoladowy";
    }

    public double Cena()
    {
        return _kawa.Cena() + 2.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Zamówienie zwykłej czarnej kawy
        IKawa KawaZwykla = new ZwyklaKawa();
        Console.WriteLine("Zamówienie numer 1: " + KawaZwykla.Opis());
        Console.WriteLine("Cena: $" + KawaZwykla.Cena());

        // Zamówienie kawy z wszystkimi dodatkami
        IKawa KawaNajdrozsza = new KawaZMlekiem(new KawaZLodem(new KawaZKrememCzekoladowym(new ZwyklaKawa())));
        Console.WriteLine("Zamówienie numer 2: " + KawaNajdrozsza.Opis());
        Console.WriteLine("Cena: $" + KawaNajdrozsza.Cena());
        Console.WriteLine("Wysokość rachunku do zapłacenia: $" + (KawaNajdrozsza.Cena() + KawaZwykla.Cena()));

    }

}


