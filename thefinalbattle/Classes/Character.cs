using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle.Classes;
internal abstract class Character
{
	public string? Name;
	public List<Action>? Moves;
	public abstract void Turn();
}
