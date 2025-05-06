using TheFinalBattle.Actions;

namespace TheFinalBattle.Classes;
public class Player : Character
{
	
	public Player()
	{
		Moves = [new Nothing()];
		GetName();
	}

	public void GetName()
	{
		Console.Write("Enter the name of THE ONE TRUE PROGRAMMER... ");
		Name = Console.ReadLine();
	}

	public string ListMoves()
	{
		string movesString = "";
		foreach (var move in Moves!)
		{
			movesString += $"1: {move.MoveName}";
		}

		return movesString;
	}

	public override void Turn()
	{
		Console.WriteLine("What would you like to do? (Enter the number)");
		Console.WriteLine($"{ListMoves()}");
		string? action = Console.ReadLine();
		int.TryParse(action, out var result);
		switch (result)
		{
			case 1:
				Console.WriteLine($"{Name} did {Moves![result - 1].MoveName}");
				break;
			default:
				break;
		}
	}
}
