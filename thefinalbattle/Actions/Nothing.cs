﻿using Action = TheFinalBattle.Classes.Action;

namespace TheFinalBattle.Actions;

public class Nothing : Action
{
	public Nothing()
	{
		MoveName = "NOTHING";
		Effects = ["None"];
	}

}

