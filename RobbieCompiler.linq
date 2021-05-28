<Query Kind="Program" />

void Main()
{
	string code = "if (x == y) { return true; } else { return false; }";
	
	LexicalAnalysis.Analyze(code);
}

// Lexical Analysis
// 1. Partition a string
// 2. Classify a string
// 

public static class LexicalAnalysis
{
	public static Token[] Analyze(string s)
	{
		Partition(s).Dump();
		
		return new Token[] { new Token() };
	}
	
	private static string[] Partition(string s)
	{
		// Define a regular expression for repeated words.
		// Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b");
		Regex rx = new Regex(@"if|else");

		// Find matches.
		MatchCollection matches = rx.Matches(s);

		// Report the number of matches found.
		Console.WriteLine("{0} matches found in:\n   {1}",
						  matches.Count,
						  s);
						  
		return rx.Split(s);
	}

}

public class Token
{
	public TokenClasses Type;
	public string Value;
}

public enum TokenClasses
{
	Keyword, // if, void, etc
	// if|else
	Identifier, // numbers and char starting with char
	// 
	Whitespace, // " ", \n, \t, etc
	String, // char surrounded by " or '
	Operator, // =, ==, ;, (, ), etc
	Error // anything else
}