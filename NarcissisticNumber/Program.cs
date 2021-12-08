using System;
using System.Linq;
using System.Collections.Generic;

Console.WriteLine(Narcissistic(153));
Console.WriteLine(Narcissistic(1938));


bool Narcissistic(int value)
{
    int tmpValue = value;
    List<int> Digits = new List<int>();

    do
    {
        Digits.Add(tmpValue % 10);
        tmpValue /= 10;
    } while (tmpValue > 0);

    var sum = Digits.Select(i => Math.Pow(i, Digits.Count())).Sum();
    return sum == value;
}