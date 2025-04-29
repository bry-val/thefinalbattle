using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFinalBattle.Actions;
using TheFinalBattle.Classes;
using Action = TheFinalBattle.Classes.Action;

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
		Console.WriteLine($"{Name} did {Moves![0].MoveName}.\n");
	}


}

