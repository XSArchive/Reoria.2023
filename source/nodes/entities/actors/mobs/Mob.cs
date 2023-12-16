using Godot;

namespace Reoria.Nodes.Entities.Actors.Mobs;

public partial class Mob : Actor
{
	public override void _PhysicsProcess(double delta)
	{
		this.Logic.Movement.Input = Input.GetVector(
			Constants.Input.MOVEMENT_LEFT, Constants.Input.MOVEMENT_RIGHT,
			Constants.Input.MOVEMENT_UP, Constants.Input.MOVEMENT_DOWN) * -1;

		base._PhysicsProcess(delta);
	}
}
