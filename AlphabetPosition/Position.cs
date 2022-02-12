
public static class Position
{
    public static string GetAlphabetPosition(string text)
    {
        return string.Join(
          " ",
          text
          .ToLower()
          .Where(i => (i - 96) < 27 && (i - 96) > 0)
          .Select(i => i - 96));
    }
}
