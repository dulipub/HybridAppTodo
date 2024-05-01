namespace SpreadSheet.Test;

[TestClass]
public class ParserTests
{
	[TestMethod]
	public void BasicFunctionCapitalLetters()
	{
		var formula = "A1+B1";
		var result = Parser.ParseFormula(formula);
		Assert.AreEqual("A1", result.ElementAt(0));
		Assert.AreEqual("+", result.ElementAt(1));
		Assert.AreEqual("B1", result.ElementAt(2));
	}

	[TestMethod]
	public void BasicFunctionSimpleLetters()
	{
		var formula = "a1-b1";
		var result = Parser.ParseFormula(formula);
		Assert.AreEqual("a1", result.ElementAt(0));
		Assert.AreEqual("-", result.ElementAt(1));
		Assert.AreEqual("b1", result.ElementAt(2));
	}

	[TestMethod]
	public void BasicFunctionMixedLetters()
	{
		var formula = "a1*B1";
		var result = Parser.ParseFormula(formula);
		Assert.AreEqual("a1", result.ElementAt(0));
		Assert.AreEqual("*", result.ElementAt(1));
		Assert.AreEqual("B1", result.ElementAt(2));
	}

	[TestMethod]
	public void SumFunction()
	{
		var formula = "sum(a1:a100)";
		var result = Parser.ParseFormula(formula);
		Assert.AreEqual("sum", result.ElementAt(0));
		Assert.AreEqual("(", result.ElementAt(1));
		Assert.AreEqual("a1", result.ElementAt(2));
		Assert.AreEqual(":", result.ElementAt(3));
		Assert.AreEqual("a100", result.ElementAt(4));
		Assert.AreEqual(")", result.ElementAt(5));
	}
}