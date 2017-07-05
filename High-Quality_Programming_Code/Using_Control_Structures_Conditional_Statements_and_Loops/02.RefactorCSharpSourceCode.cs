using System;

class IfStatements
{
    // The first if statement.
    Potato potato;

    if (potato != null)
	{
	    if (potato.IsPeeled && potato.IsNotRotten)
	    {
            Cook(potato);
	    }	 
	}

    // The second if statement.
    bool xInRange = MIN_X <= x && x <= MAX_X;
    bool yInRange = MIN_Y <= y && y <= MAX_Y;

    if (xInRange && yInRange && shouldVisitCell)
    {
        VisitCell();
    }
}
