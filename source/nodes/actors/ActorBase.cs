using Godot;
using Reoria.Enumerations;
using Reoria.Nodes.Actors.Enumerations;

namespace Reoria.Nodes.Actors;

public partial class ActorBase : CharacterBody2D
{
	[Export]
	public ActorState State = ActorState.Idle;
	[Export]
	public Direction Direction = Direction.Down;
	[Export]
	public float MovementSpeed = 16.0f;
	[Export]
	public Vector2 MovementInput = Vector2.Zero;
	[Export]
	public Vector2 DirectionInput = Vector2.Zero;

	protected Sprite2D Sprite2D;

	public override void _Ready()
	{
		this.Sprite2D = this.GetNode<Sprite2D>("Sprite2D");

		base._Ready();
	}

	public override void _PhysicsProcess(double delta)
	{
		this.Velocity = this.MovementInput * this.MovementSpeed;
		this.State = (this.Velocity != Vector2.Zero) ? ActorState.Moving : ActorState.Idle;

		if (this.State == ActorState.Moving)
		{
			if (this.MovementInput.X <= -0.1f) { this.Direction = Direction.Left; }
			if (this.MovementInput.X >= 0.1f) { this.Direction = Direction.Right; }
			if (this.MovementInput.Y <= -0.1f) { this.Direction = Direction.Up; }
			if (this.MovementInput.Y >= 0.1f) { this.Direction = Direction.Down; }

			_ = this.MoveAndSlide();
		}

		if (this.DirectionInput != Vector2.Zero)
		{
			if (this.DirectionInput.X <= -0.1f) { this.Direction = Direction.Left; }
			if (this.DirectionInput.X >= 0.1f) { this.Direction = Direction.Right; }
			if (this.DirectionInput.Y <= -0.1f) { this.Direction = Direction.Up; }
			if (this.DirectionInput.Y >= 0.1f) { this.Direction = Direction.Down; }
		}

		switch (this.Direction)
		{
			case Direction.Left:
				this.Sprite2D.FrameCoords = new Vector2I(1, 1);
				break;
			case Direction.Right:
				this.Sprite2D.FrameCoords = new Vector2I(1, 2);
				break;
			case Direction.Up:
				this.Sprite2D.FrameCoords = new Vector2I(1, 3);
				break;
			case Direction.None:
				break;
			case Direction.All:
				break;
			case Direction.Down:
			default:
				this.Sprite2D.FrameCoords = new Vector2I(1, 0);
				break;
		}

		base._PhysicsProcess(delta);
	}
}
