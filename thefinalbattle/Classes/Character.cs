namespace TheFinalBattle.Classes;
public abstract class Character
{
	public string? Name;
	public List<Action>? Moves;
	public abstract void Turn();
}
