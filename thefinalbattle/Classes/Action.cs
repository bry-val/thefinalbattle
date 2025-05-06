using System.Diagnostics;

namespace TheFinalBattle.Classes;

public abstract class Action
{
	public string? MoveName { get; set; }
	public List<string>? Effects { get; set; }

	private string EffectsString()
	{
		var effectString = "";
		for (int i = 0; i < Effects!.Count; i++)
		{
			effectString += $"\n{i+1}: {Effects[i]}\n";
		}
		return effectString;
	}

	public void UseAction()
	{
		Console.WriteLine($"{MoveName} has the following effects: {EffectsString()}");
	}
}
