using TheFinalBattle.Classes;
using TheFinalBattle.Monsters;

namespace TheFinalBattle;

internal class Program
{
    private static void Main(string[] args)
    {
	    Skeleton skelly = new Skeleton();
		Party heroes = new Party
		{
			PartyName = "Heroes",
			PartyMembers = [skelly]
		};
		Party monsters = new Party
		{
			PartyName = "Monster",
			PartyMembers = [skelly]
		};

		for (int i = 0; i < 10; i++)
	    {
		    Thread.Sleep(500);
			heroes.TakeTurn();
			Thread.Sleep(500);

			monsters.TakeTurn();
			Thread.Sleep(500);
	    }
    }
}

