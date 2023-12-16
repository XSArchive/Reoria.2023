using Godot;
using Reoria.Enumerations;
using Reoria.Enumerations.Nodes.Entities.Actors;

namespace Reoria.Data.Entities.Actors;

public partial class ActorData : EntityData
{
    [Export]
    public ActorState State = ActorState.Idle;
    [Export]
    public Direction Direction = Direction.Down;

    [Export]
    public ActorStats Stats { get; protected set; }

    public override void _Ready()
    {
        this.Stats = this.GetNode<ActorStats>("Stats");

        base._Ready();
    }
}