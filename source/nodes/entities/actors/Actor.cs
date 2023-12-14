using Godot;

namespace Reoria.Nodes.Entities.Actors;

public partial class Actor : Entity
{
	[Export]
	public Sprite2D Sprite { get; private set; }
	[Export]
	public AnimationPlayer AnimationPlayer { get; private set; }
	[Export]
	public ActorMovementProcessor MovementProcessor { get; private set; }

	public override void _Ready()
	{
		this.Sprite = this.GetNode<Sprite2D>("Sprite2D");
		this.AnimationPlayer = this.GetNode<AnimationPlayer>("AnimationPlayer"); 
		this.MovementProcessor = this.GetNode<ActorMovementProcessor>("MovementProcessor");

		base._Ready();
	}
}
