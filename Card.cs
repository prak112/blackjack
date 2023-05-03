using System;
namespace CardGame;

public class Card
{
	public enum Symbols		// to check about ENUM (similar to class)
	{
		Hearts,
		Diamonds,
		Spades,
		Clubs
	}

	// Attributes/Properties
	public int Value { get; set; }		// between 1 - 13
	public Symbols Symbol { get; set; }

	// Constructor
	public Card(int aValue, Symbols aSymbol)
	{
		Value = aValue;
		Symbol = aSymbol;
	}

	// Methods



}
