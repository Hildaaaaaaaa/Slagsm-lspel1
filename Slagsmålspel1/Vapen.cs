using System;


public class Vapen
{
    public string name = "svärd";

    private Random generator = new Random();

    public int skadevärde()
    {
        int skadevärde = generator.Next(15, 30);
        return skadevärde;
    }
}



//Denna text är utöver basen