using System.Text;
using System.Linq;

Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));

string AlphabetPosition(string text)
{
    return string.Join(
      " ",
      text
      .ToLower()
      .Where(i => (i - 96) < 27 && (i - 96) > 0)
      .Select(i => i - 96));
}