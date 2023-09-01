Gubbe gubbeson = new();
Hemlös hemlös = new();

gubbeson.name = "Gubbeson";
hemlös.name = "hemlös";

Console.WriteLine(
    $"{gubbeson.name} ska till Ica för att köpa sin vanliga dos av black tar heroin men när han försöker att \nkliva in till Ica så snubblar han över en hemlös person, {hemlös.name} blir arg för att han blev \nkrossad av {gubbeson.name}s enorma figur och förlorade {100 - hemlös.hp} hp.\n \n{gubbeson.name} vs {hemlös.name} \nMap: Ica entré \n{gubbeson.name}(Player) has {gubbeson.maxHp} hp and {hemlös.name} has {hemlös.hp} \n \nPlease type Attack or Defend"
    );

bool alive = true;
while (alive == true)
{
    Fight(gubbeson, hemlös, alive);
}

Console.ReadLine();

static bool Fight(Gubbe gubbeson, Hemlös hemlös, bool alive)
{
    Random generator = new Random();
    string action = Console.ReadLine().ToLower();
    Console.WriteLine();
    int enemyAction = generator.Next(1, 3);


    if (action == "attack")
    {
        if (enemyAction == 2)
        {
            Console.WriteLine($"{hemlös.name} blocked {gubbeson.name} attack");
        }
        else
        {
            int crit = generator.Next(1, 4);
            if (crit == 1)
            {
                hemlös.hp -= gubbeson.CaneKnife(gubbeson.name, hemlös.name);
            }
            else
            {
                hemlös.hp -= gubbeson.damage;
                Console.WriteLine($"{gubbeson.name} kicked {hemlös.name}");
            }
        }
    }
    else if (action != "defend")
    {
        Console.WriteLine($"{gubbeson.name} was idiot and just stood there");
    }

    if (enemyAction == 1)
    {
        if (action == "defend")
        {
            Console.WriteLine($"{gubbeson.name} blocked {hemlös.name} attack");
        }
        else
        {
            int enemyCrit = generator.Next(1, 3);
            if (enemyCrit == 1)
            {
                gubbeson.hp -= hemlös.BrokenBottle(hemlös.name, gubbeson.name);
            }
            else
            {
                gubbeson.hp -= hemlös.damage;
                Console.WriteLine($"{hemlös.name} punched {gubbeson.name}");
            }
        }
    }

    if (action == "defend" && enemyAction == 2)
    {
        Console.WriteLine("You both defended");
    }

    if (gubbeson.hp <= 0)
    {
        Console.WriteLine($" \n{gubbeson.name} died and {hemlös.name} sold his organs and became not hemlös");
        alive = false;
    }
    else if (hemlös.hp <= 0)
    {
        Console.WriteLine($" \n{hemlös.name} died and {gubbeson.name} entered Ica");
        alive = false;
    }
    else
    {
        Console.WriteLine($"{gubbeson.name} has {gubbeson.hp} Hp and {hemlös.name} has {hemlös.hp} Hp");
    }
    return alive;
}