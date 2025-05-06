namespace TheFinalBattle.Classes;

internal class Party
{
	public string? PartyName { get; set; }
	public List<Character>? PartyMembers { get; set; }

	public void TakeTurn()
	{

		foreach (var member in PartyMembers!)
		{
			member.Turn();
			Console.WriteLine();
		}
		
	}
}

