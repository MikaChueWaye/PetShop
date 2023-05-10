using System;
using System.Collections.Generic;
using System.Linq;

public static class EnumExtensions
{
    public static int GetSetBitCount(this Enum pEnum)
    {
        int lEnumVal = Convert.ToInt32(pEnum);
        int iCount = 0;

        //Loop the value while there are still bits
        while (lEnumVal != 0)
        {
            //Remove the end bit
            lEnumVal &= (lEnumVal - 1);

            //Increment the count
            iCount++;
        }

        //Return the count
        return iCount;
    }

    public static IEnumerable<Enum> GetFlags(this Enum pEnum)
    {
        return Enum.GetValues(pEnum.GetType()).Cast<Enum>().Where(pEnum.HasFlag);
    }

    public static bool HasFlag(this Enum pContainsEnum, Enum pEnum)
    {
        foreach (Enum lContainsEnum in GetFlags(pContainsEnum))
        {
            if (lContainsEnum == pEnum)
            {
                return true;
            }
        }
        return false;
    }
}

