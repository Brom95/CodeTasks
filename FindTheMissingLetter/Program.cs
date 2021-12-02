using System;
using System.Collections.Generic;

Console.WriteLine(FindMissingLetter(new char[]{'a', 'b', 'c', 'd', 'f'}));
Console.WriteLine(FindMissingLetter(new char[] { 'O', 'Q', 'R', 'S' }));

char FindMissingLetter(char[] array)
{
    var hs = new HashSet<char>(array);
    char missingLetter = array[0];
    while (!hs.Add(missingLetter))
    {
        missingLetter++;
    }
    return missingLetter;
}