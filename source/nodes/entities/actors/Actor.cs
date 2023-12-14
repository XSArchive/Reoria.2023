using Godot;
using Reoria.Enumerations;
using Reoria.Enumerations.Nodes.Entities.Actors;

namespace Reoria.Nodes.Entities.Actors;

public partial class Actor : Entity
{
	[Export]
	public Sprite2D Sprite { get; private set; }
	[Export]
	public AnimationPlayer AnimationPlayer { get; private set; }
	[Export]
	public ActorMovementProcessor MovementProcessor { get; private set; }

	[Export]
	public ActorState State = ActorState.Idle;
	[Export]
	public Direction Direction = Direction.Down;

	public override void _Ready()
	{
		this.Sprite = this.GetNode<Sprite2D>("Sprite2D");
		this.AnimationPlayer = this.GetNode<AnimationPlayer>("AnimationPlayer"); 
		this.MovementProcessor = this.GetNode<ActorMovementProcessor>("MovementProcessor");

		base._Ready();
	}
}
