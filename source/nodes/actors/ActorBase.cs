using Godot;

namespace Reoria.Nodes.Actors;

public partial class ActorBase : CharacterBody2D
{
	[Export]
	public float MovementSpeed = 16.0f;
	[Export]
	public Vector2 MovementInput = Vector2.Zero;
	[Export]
	public Vector2 DirectionInput = Vector2.Zero;

	public override void _PhysicsProcess(double delta)
	{
		this.Velocity = this.MovementInput * this.MovementSpeed;

		if (this.Velocity != Vector2.Zero) { _ = this.MoveAndSlide(); }

		base._PhysicsProcess(delta);
	}
}
