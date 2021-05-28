<Query Kind="Program" />

void Main()
{
	
}

// Lexical Analysis
// 1. Partition a string
// 2. Classify a string
// 

public static class LexicalAnalysis
{
	public static Token[] Analyze(string s)
	{
		return new Token[] { new Token() };
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
	Identifier, // numbers and char starting with char
	Whitespace, // " ", \n, \t, etc
	String, // char surrounded by " or '
	Operator, // =, ==, ;, (, ), etc
	Error // anything else
}