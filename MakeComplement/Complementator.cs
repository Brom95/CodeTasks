
public static class Complementator
{

    public static Dictionary<char, char> DNA = new Dictionary<char, char>
        {
          {'A','T'},
          {'T','A'},
          {'C','G'},
          {'G','C'},
        };
    public static string MakeComplement(string dna) => string.Join("", dna.Select(i => $"{DNA[i]}"));
}




