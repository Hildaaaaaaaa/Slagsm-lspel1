Slagskämpe emelina = new Slagskämpe();
Slagskämpe du = new Slagskämpe();

Console.WriteLine("Emelinas hitpoint: " + emelina.hitpoint);
Console.WriteLine("Dina hitpoints: " + du.hitpoint);
Console.WriteLine("Klara färdiga gå..");
Console.WriteLine("-----------------");



while (emelina.hitpoint > 0 && du.hitpoint > 0)
{
    Console.Clear();
    Console.WriteLine("Emelinas hitpoint: " + emelina.hitpoint);
    Console.WriteLine("Dina hitpoints: " + du.hitpoint);
    Console.WriteLine("-----------------");

    emelina.hitpoint -= du.vapen.skadevärde();
    du.hitpoint -= emelina.vapen.skadevärde();

    Console.WriteLine("!!Tryck 'enter' för att komma vidare!!");
    Console.ReadLine();

    Console.WriteLine("-----------------");
    Console.WriteLine("Vill du använda healing?");


    string val = "";
    Console.WriteLine("ja");
    Console.WriteLine("nej");
    Console.WriteLine("-----------------");

    val = Console.ReadLine();

    if (val == "ja")
    {
        Console.Clear();
        du.hitpoint += 20;
        Console.WriteLine($"Efter din healing har du {du.hitpoint} hitpoints");
    }

    else if (val == "nej")
    {


    }

    else if (val != "ja" && val != "nej")
    {
        Console.WriteLine("Svara 'ja' eller 'nej'");

        Console.WriteLine("-----------------");
        Console.WriteLine("Vill du använda healing?");

        Console.WriteLine("ja");
        Console.WriteLine("nej");
        Console.WriteLine("-----------------");
    }

    Console.ReadLine();
}


if (du.hitpoint > 0)
{
    Console.WriteLine("-----------------");

    Console.WriteLine("Du vann!");
}
if (emelina.hitpoint > 0)
{
    Console.WriteLine("-----------------");

    Console.WriteLine("Emelina vann!");
}

Console.ReadLine();
