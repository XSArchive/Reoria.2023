using Godot;

namespace Reoria.Nodes.Actors.Player;

public partial class Player : ActorBase
{
	public override void _Process(double delta)
	{
		this.MovementInput = Input.GetVector(Constants.Input.MOVEMENT_LEFT, Constants.Input.MOVEMENT_RIGHT, Constants.Input.MOVEMENT_UP, Constants.Input.MOVEMENT_DOWN);
		this.DirectionInput = Input.GetVector(Constants.Input.DIRECTION_LEFT, Constants.Input.DIRECTION_RIGHT, Constants.Input.DIRECTION_UP, Constants.Input.DIRECTION_DOWN);

		base._Process(delta);
	}
}
