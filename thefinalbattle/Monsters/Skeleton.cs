using TheFinalBattle.Actions;
using TheFinalBattle.Classes;

namespace TheFinalBattle.Monsters;
internal class Skeleton : Character
{
	public Skeleton()
	{
		Name = "SKELETONG";
		Moves = [new Nothing()];
	}

	public override void Turn()
	{
		Console.WriteLine($"It is {Name}'s turn...");
		Console.WriteLine($"{Name} did {Moves![0].MoveName}.");
	}


}

