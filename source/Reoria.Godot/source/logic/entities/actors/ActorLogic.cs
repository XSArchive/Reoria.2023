using Godot;

namespace Reoria.Logic.Entities.Actors;

public partial class ActorLogic : EntityLogic
{
    [Export]
    public ActorMovementLogic Movement { get; protected set; }

    public override void _Ready()
    {
        this.Movement ??= this.GetNode<ActorMovementLogic>("Movement");

        base._Ready();
    }
}