using Mathos.Parser;
using System;

namespace SpreadSheet;

public static class Parser
{
	public static IReadOnlyCollection<string> ParseFormula(string formula)
	{
		var cleanFormula = RemoveWhitespace(formula);

		var parser = new MathParser(false, true, false);
		return parser.GetTokens(formula);
	}

	public static string RemoveWhitespace(this string str)
	{
		return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
	}
}