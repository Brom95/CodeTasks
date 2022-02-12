using System;
using System.Collections.Generic;

public static class MissingLettersFinder
{

    public static char FindMissingLetter(char[] array)
    {
        var hs = new HashSet<char>(array);
        char missingLetter = array[0];
        while (!hs.Add(missingLetter))
        {
            missingLetter++;
        }
        return missingLetter;
    }
}
