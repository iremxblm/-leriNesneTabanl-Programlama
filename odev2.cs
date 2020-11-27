using System;
class Musteri
{
    private string Adsoyad;
    private int Yas;
    private string Meslek;
    private int Maas;

    public string adsoyad
    {
        get
        {
            return Adsoyad;
        }
        set
        {
            Adsoyad = value;
        }
    }

    public int yası
    {
        get
        {
            return yası;
        }
        set
        {
            yası = value;
        }
    }
    public string Meslegi
    {
        get
        {
            return Meslegi;
        }
        set
        {
           Meslegi = value;
        }
    }
    public int Maası
    {
        get
        {
            return Maası;
        }
        set
        {
            Maası = value;
        }
    }
}

class Program
{
    private static readonly string Mühendis;

    static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.adsoyad = "İrem Bulum"; 
        m1.yası = 20;
        m1.Meslegi = Mühendis;
        m1.Maası = 7500;
        Console.WriteLine("Ad/Soyad:{0} - Yaş:{1} - Meslek:{2} - Maaş:{3}", m1.adsoyad, m1.yası, m1.Meslegi,m1.Maası);
    }
}
