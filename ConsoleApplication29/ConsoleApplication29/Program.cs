using System;
using System.Collections.Generic;
using System.Reflection;

public class Date
{
    private int Day = 7;
    

    private int day
    {
        get
        {
            return Day;

        }
        set
        {
            if (value > 0 && value < 8)
            {
                Day = value;
            }

        }

    }

}
