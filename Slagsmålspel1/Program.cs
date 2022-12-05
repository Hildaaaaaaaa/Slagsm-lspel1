Slagskämpe emelina = new Slagskämpe();
Slagskämpe hilda = new Slagskämpe();

while (emelina.hitpoint > 0 && hilda.hitpoint > 0)
{
    Console.WriteLine("Emelinas hitpoint: " + emelina.hitpoint);
    Console.WriteLine("Hildas hitpoints: " + hilda.hitpoint);

    emelina.hitpoint -= hilda.vapen.skadevärde();
    hilda.hitpoint -= emelina.vapen.skadevärde();

    Console.ReadLine();

    Console.WriteLine("-----------------");
    Console.WriteLine("Vill du använda healing?");


    Console.WriteLine("Ja");
    Console.WriteLine("Nej");
    Console.WriteLine("-----------------");
    Console.ReadLine();

}

if (hilda.hitpoint > 0)
{
    Console.WriteLine("-----------------");

    Console.WriteLine("Emelina vann!");
}
if (emelina.hitpoint > 0)
{
    Console.WriteLine("-----------------");

    Console.WriteLine("Hilda vann!");
}

Console.ReadLine();
