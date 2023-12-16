using Godot;
using Reoria.Data.Entities.Actors;
using Reoria.Data.Entities.Actors.Mobs;

namespace Reoria.Nodes.Entities.Actors.Mobs;

public partial class Mob : Actor
{
	[Export]
	public new MobData Data { get; private set; }

	public override void _Ready()
	{
		this.Data ??= this.GetNode<MobData>("Data");

		base._Ready();
	}

	public override void _PhysicsProcess(double delta)
	{
		this.Logic.Movement.Input = Input.GetVector(
			Constants.Input.MOVEMENT_LEFT, Constants.Input.MOVEMENT_RIGHT,
			Constants.Input.MOVEMENT_UP, Constants.Input.MOVEMENT_DOWN) * -1;

		base._PhysicsProcess(delta);
	}
}
