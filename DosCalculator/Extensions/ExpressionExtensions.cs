using System.Linq;
using MathNet.Symbolics;

namespace DosCalculator.Extensions
{
    public static class ExpressionExtensions
    {
        public static string AsLatex(this Expression expression)
        {
            var result = LaTeX.Format(expression);
            result = GreekSymbols.SymbolToLatex.Aggregate(result, (current, latexKv) => current.Replace(latexKv.Key.ToString(), latexKv.Value));

            return result;
        }
    }
}