using System;
class Dikdrtgen
{
    static int Alan(int x, int y)
    {
        int alan = x * y;
        return alan;
    }
    static int Cevre(int x, int y)
    {
        int cevre = 2 * (x + y);
        return cevre;
    }
    static void Main()
    {
        Console.WriteLine("Kısa kenar:");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzunkenar:");
        int u = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Alanı {0}", Alan(k, u));
        Console.WriteLine("Dikdörtgenin Çevresi {0}", Cevre(k, u));
        Console.ReadKey();
    }
}
