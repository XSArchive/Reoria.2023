using Godot;
using Reoria.Godot.Nodes.Entities.Logic;

namespace Reoria.Godot.Nodes.Entities.Actors.Logic;

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