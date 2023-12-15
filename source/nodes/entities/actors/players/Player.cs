using Godot;
using Reoria.Data.Entities.Actors.Players;

namespace Reoria.Nodes.Entities.Actors.Players;

public partial class Player : Actor
{
    [Export]
    public new PlayerData Data { get; private set; }

    public override void _Ready()
    {
        this.Data ??= this.GetNode<PlayerData>("Data");

        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
	{
		this.MovementProcessor.Input = Input.GetVector(
			Constants.Input.MOVEMENT_LEFT, Constants.Input.MOVEMENT_RIGHT,
			Constants.Input.MOVEMENT_UP, Constants.Input.MOVEMENT_DOWN);

		base._PhysicsProcess(delta);
	}
}
