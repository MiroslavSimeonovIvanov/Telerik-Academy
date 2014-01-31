using System;
using System.Threading;

class Garden
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double tomatoSeedsAmount = Convert.ToDouble(Console.ReadLine());
        double tomatoArea = Convert.ToDouble(Console.ReadLine());

        double cucumberSeedsAmount = Convert.ToDouble(Console.ReadLine());
        double cucumberArea = Convert.ToDouble(Console.ReadLine());

        double potatoSeedsAmount = Convert.ToDouble(Console.ReadLine());
        double potatoArea = Convert.ToDouble(Console.ReadLine());

        double carrotSeedsAmount = Convert.ToDouble(Console.ReadLine());
        double carrotArea = Convert.ToDouble(Console.ReadLine());
        
        double cabbageSeedsAmount = Convert.ToDouble(Console.ReadLine());
        double cabbageArea = Convert.ToDouble(Console.ReadLine());
        
        double beansSeedsAmount = Convert.ToDouble(Console.ReadLine());
        
        double tomatoCost = tomatoSeedsAmount * 0.5;
        double cucumberCost = cucumberSeedsAmount * 0.4;
        double potatoCost = potatoSeedsAmount * 0.25;
        double carrotCost = carrotSeedsAmount * 0.6;
        double cabbageCost = cabbageSeedsAmount * 0.3;
        double beansCost = beansSeedsAmount * 0.4;

        double totalCost = tomatoCost + cucumberCost + potatoCost + carrotCost + cabbageCost + beansCost;

        ushort totalArea = 250;
        ushort areaOfAllVegWithoutBeans = (ushort)(tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
        double beansArea = totalArea - areaOfAllVegWithoutBeans;

        Console.WriteLine("Total costs: {0:f2}", totalCost);

        if (areaOfAllVegWithoutBeans < totalArea)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (areaOfAllVegWithoutBeans == totalArea)
        {
            Console.WriteLine("No area for beans");
        }
        else if (areaOfAllVegWithoutBeans > totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
