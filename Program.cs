class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen1 = new Dikdortgen();
        dikdortgen1.kisaKenar = 3;
        dikdortgen1.uzunKenar = 4;
        Console.WriteLine("Alan Hesabı : {0}",dikdortgen1.AlanHesabi());
        Dikdortgen_struct dikdortgen;
        dikdortgen.kisaKenar = 4;
        dikdortgen.uzunKenar = 5;
        Console.WriteLine("Alan Hesabı : {0}",dikdortgen.AlanHesabi());
    }
}
class Dikdortgen
{
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesabi()
    {
        return kisaKenar * uzunKenar;
    }
}
struct Dikdortgen_struct
{
    public int kisaKenar;
    public int uzunKenar;
    public long AlanHesabi()
    {
        return kisaKenar * uzunKenar;
    }
}