Wizard wizardA = new Wizard("Putri", 5);
Wizard wizardB = new Wizard("Goblin", 10);

Console.WriteLine("Permainan dimulai...");
Console.WriteLine("Statistik awal");
wizardA.ShowStats();
wizardB.ShowStats();

string pilihan;

while (true)
{
    Console.Clear();
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nPilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.Attack(wizardB);
    else if (pilihan == "2") wizardB.Attack(wizardA);
    else if (pilihan == "3") wizardA.Heal();
    else if (pilihan == "4") wizardB.Heal();
    else Console.WriteLine("!!! Pilihanmu tidak valid !!!");

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("!!! Pertandingan Berakhir !!!");
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} berhasil dikalahkan");
            Console.WriteLine($"{wizardA.Name} keluar sebagai pemenangnya!");
        }
        else
        {
            Console.WriteLine($"{wizardA.Name} berhasil dikalahkan");
            Console.WriteLine($"{wizardB.Name} keluar sebagai pemenangnya!");
        }
        break;
    }
    Console.ReadLine();
}

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);
//wizardB.Heal();

Console.WriteLine("Permainan Selesai...\n");
Console.WriteLine("Statistik Akhir");
wizardA.ShowStats();
wizardB.ShowStats();
public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }
    public void ShowStats()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Energy : {Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} Menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energi {enemyObj.Name}: {enemyObj.Energy}");
    }

    public void Heal()
    {
        if (Energy >= 100)
        {
            Console.WriteLine("Gagal melakukan heal. Energy sudah mencapai maksimum");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy += 5;
            }
            Console.WriteLine($"{Name} berhasil melakukan heal. Energy meningkat menjadi {Energy}");
        }
    }
}