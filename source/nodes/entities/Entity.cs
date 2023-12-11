using Godot;

namespace Reoria.Nodes.Entities;

public partial class Entity : CharacterBody2D
{
	[Export]
	public CollisionShape2D CollisionShape { get; private set; }

	public override void _Ready()
	{
		this.CollisionShape = this.GetNode<CollisionShape2D>("CollisionShape2D");

		base._Ready();
	}
}
