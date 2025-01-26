using Godot;
using System;
using System.Collections.Generic;

public partial class Main : Node2D
{
	public static Dictionary<string, double> VariableRegistry = new Dictionary<string, double> {
		{"Xvariable", double.NaN}
	};
	//Distributive property example (should evaluate to 42): 3 * (6 + 8)
	Expression testExpression = new Expression(Expression.Operation.Multiplication, new NW(3), new Expression(Expression.Operation.Addition, new NW(6), new NW(8)));
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print(testExpression.Stringify());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
