public class Hemlös
{
    public float maxHp = 50;
    public float hp;
    public float damage = 20;

    public Hemlös()
    {
        ResetHp();
    }

    public void ResetHp()
    {
        hp = maxHp;
    }

    public int BrokenBottle(string name, string enemyName)
    {
        int bottleDMG = 35;
        Console.WriteLine($"{name} breaks a bottle and stabs {enemyName}");
        return bottleDMG;
    }
}
