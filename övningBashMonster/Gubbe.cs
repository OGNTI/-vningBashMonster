public class Gubbe
{
    public float maxHp = 100;
    public float hp;
    public float damage = 10;

    public Gubbe()
    {
        ResetHp();
    }

    public void ResetHp()
    {
        hp = maxHp;
    }

    public int CaneKnife(string name, string enemyName)
    {
        int knifeDMG = 40;
        Console.WriteLine($"{name} has a secret knife in their cane and stabs {enemyName}");
        return knifeDMG;
    }
}


