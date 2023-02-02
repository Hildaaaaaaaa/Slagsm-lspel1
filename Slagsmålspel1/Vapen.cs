using System;


public class Vapen
{
    public string name = "";
    public int minDamage = 12;


    private Random generator = new Random();

    public int skadevärde()
    {
        int skadevärde = generator.Next(minDamage, 37);
        return skadevärde;
    }

}



//Denna text är utöver basen