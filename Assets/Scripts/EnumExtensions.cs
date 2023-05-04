using System;
using System.Collections.Generic;
using System.Linq;

public static class EnumExtensions
{
    public static int GetSetBitCount(this int pEnumVal)
    {

        int iCount = 0;

        //Loop the value while there are still bits
        while (pEnumVal != 0)
        {
            //Remove the end bit
            pEnumVal &= (pEnumVal - 1);

            //Increment the count
            iCount++;
        }

        //Return the count
        return iCount;
    }

    public static IEnumerable<Enum> GetFlags(this Enum e)
    {
        return Enum.GetValues(e.GetType()).Cast<Enum>().Where(e.HasFlag);
    }
}

