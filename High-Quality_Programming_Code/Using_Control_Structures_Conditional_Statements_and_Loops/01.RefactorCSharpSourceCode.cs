using System;

public class Chef
{
    private int potato;

    public int GetPotato
    {
        get
        {
            return potato;
        }
    }

    private int carrot;

    public int GetCarrot
    {
        get
        {
            return carrot;
        }
    }

    private int bowl;

    public int GetBowl
    {
        get
        {
            return bowl;
        }
    }

    private void Peel()
    {
        //...
    }

    private void Cut()
    {
        //...
    }

    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        Peel(potato);
        Peel(carrot);

        Cut(potato);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(potato);
        bowl.Add(carrot);
    }
}
