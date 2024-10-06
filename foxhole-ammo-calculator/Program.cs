namespace foxhole_ammo_calculator;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("=====FOXHOLE AMMO CALCULATOR=====");
        System.Console.WriteLine("Podaj ilosc amunicji 150mm: ");
        int ammoCount = int.Parse(Console.ReadLine());

        int cmatCount = ammoCount * 3;
        int hematCount = ammoCount * 8;
        System.Console.WriteLine($"Do produkcji {ammoCount} amunicji 150mm porzebne bedzie: ");
        System.Console.WriteLine($" - {cmatCount} Construction Materials");
        System.Console.WriteLine($" - {hematCount} High Explosive Materials");
        System.Console.WriteLine("Czyli: ");
        int salvageCount = cmatCount * 10;
        int sulfurCount = hematCount * 5;
        System.Console.WriteLine($" - {salvageCount} Salvage");
        System.Console.WriteLine($" - {sulfurCount} Sulfur");


    }
}
