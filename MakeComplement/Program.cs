using System.Linq;
using System.Collections.Generic;

Dictionary<char, char> DNA = new Dictionary<char, char>
        {
          {'A','T'},
          {'T','A'},
          {'C','G'},
          {'G','C'},
        };

Console.WriteLine(MakeComplement("ATTGC"));

string MakeComplement(string dna) => string.Join("", dna.Select(i => $"{DNA[i]}"));
