using System.Collections.Generic;

namespace DosCalculator.Core
{
    public static class GreekSymbols
    {
        public static readonly Dictionary<char, char> SymbolsDictionary = new()
        {
            { 'l', 'λ' },
            { 'L', 'Λ' },
            { 'm', 'μ' },
            { 'M', 'Μ' },
            { 'a', 'α' },
            { 'A', 'Α' },
            { 'b', 'β' },
            { 'B', 'Β' },
        };

        public static readonly Dictionary<char, string> SymbolToLatex = new()
        {
            { 'λ', @"\lambda" },
            { 'Λ', @"\Lambda" },
            { 'μ', @"\mu" },
            { 'Μ', @"\M" },
            { 'α', @"\alpha" },
            { 'Α', @"\A" },
            { 'β', @"\beta" },
            { 'Β', @"\B" },
        };
    }
}