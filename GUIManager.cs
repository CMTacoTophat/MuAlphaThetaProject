using Godot;
using System;
using System.Collections.Generic;

public partial class GUIManager : Node
{
	[Export]
	public Node canvas;
	public List<CharacterWrapper> characters = new List<CharacterWrapper>();
	CharacterWrapper testCW;
	string[] test1 = new string[] {"sin", "cos", "tan", "csc", "sec", "cot"};
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//testCW = new CharacterWrapper("1", new Vector2(64, 64), canvas);
		for (int i = 0; i < test1.Length; i++) {
			characters.Add(new CharacterWrapper(test1[i], new Vector2(64 + 34*i, 64), canvas));
		}
	}

	public void DrawExpression(Expression e, Vector2 p) {
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
