Arena a = new Arena();

// variabel som kommer ihåg ifall vi ska spela
string spela = "ja";
while (spela == "ja")
{
    a.match();
    // Spela igen?
    Console.WriteLine("-----------------");
    Console.WriteLine("Vill du spela igen?");
    string val = "";
    Console.WriteLine("ja");
    Console.WriteLine("nej");
    Console.WriteLine("-----------------");

    val = Console.ReadLine();

    if (val == "ja")
    {
        a.match();
    }

    else if (val == "nej")
    {


    }
    spela = Console.ReadLine();

}
// while variabeln == "ja"

