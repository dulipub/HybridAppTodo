namespace SpreadSheet.Models;

internal class Cell
{
	public string Id { get; set; }
	public string? Formula { get; set; }
	public string? Value { get; set; }
	public DataType? DataType { get; set; }
}
