Gubbe gubbeson = new();
Hemlös hemlös = new();

Console.WriteLine(
    $"Gubbeson ska till Ica för att köpa sin vanliga dos av black tar heroin men när han försöker att \nkliva in till Ica så snubblar han över en hemlös person, hemlös blir arg för att han blev \nkrossad av Gubbesons enorma figur och förlorade {100 - hemlös.hp} hp.\n \nGubbeson vs hemlös \nMap: Ica entré \nGubbeson(Player) has {gubbeson.maxHp} hp and hemlös has {hemlös.hp} \n \nPlease type Attack or Defend"
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
            Console.WriteLine("hemlös blocked Gubbesons attack");
        }
        else
        {
            int crit = generator.Next(1, 4);
            if (crit == 1)
            {
                hemlös.hp -= gubbeson.CaneKnife("Gubbeson", "hemlös");
            }
            else
            {
                hemlös.hp -= gubbeson.damage;
                Console.WriteLine("Gubbeson kicked hemlös");
            }
        }
    }
    else if (action != "defend")
    {
        Console.WriteLine("Gubbeson was idiot and just stood there");
    }

    if (enemyAction == 1)
    {
        if (action == "defend")
        {
            Console.WriteLine("Gubbeson blocked hemlös attack");
        }
        else
        {
            int enemyCrit = generator.Next(1, 3);
            if (enemyCrit == 1)
            {
                gubbeson.hp -= hemlös.BrokenBottle("hemlös", "Gubbeson");
            }
            else
            {
                gubbeson.hp -= hemlös.damage;
                Console.WriteLine("hemlös punched Gubbeson");
            }
        }
    }

    if (action == "defend" && enemyAction == 2)
    {
        Console.WriteLine("You both defended");
    }

    if (gubbeson.hp <= 0)
    {
        Console.WriteLine(" \nGubbeson died and hemlös sold his organs and became not hemlös");
        alive = false;
    }
    else if (hemlös.hp <= 0)
    {
        Console.WriteLine(" \nhemlös died and Gubbeson entered Ica");
        alive = false;
    }
    else
    {
        Console.WriteLine($"Gubbeson has {gubbeson.hp} Hp and hemlös has {hemlös.hp} Hp");
    }
    return alive;
}