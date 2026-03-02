Wizard wizardA = new Wizard("Putri", 5);
Wizard wizardB = new Wizard("Goblin", 10);

Console.WriteLine("Permainan dimulai...");
Console.WriteLine("Statistik awal");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

wizardB.Heal();

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