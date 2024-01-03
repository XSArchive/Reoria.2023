using Godot;
using Reoria.Godot.Nodes.Entities.Actors.Data;
using Reoria.Godot.Nodes.Entities.Actors.Logic;

namespace Reoria.Godot.Nodes.Entities.Actors;

public partial class Actor : Entity
{
	[Export]
	public new ActorData Data { get; private set; }
	[Export]
	public new ActorLogic Logic { get; private set; }
	[Export]
	public Sprite2D Sprite { get; private set; }
	[Export]
	public AnimationPlayer AnimationPlayer { get; private set; }

	public override void _Ready()
	{
		this.Data ??= this.GetNode<ActorData>("Data");
		this.Logic ??= this.GetNode<ActorLogic>("Logic");
		this.Sprite = this.GetNode<Sprite2D>("Sprite2D");
		this.AnimationPlayer = this.GetNode<AnimationPlayer>("AnimationPlayer");

		base._Ready();
	}
}
