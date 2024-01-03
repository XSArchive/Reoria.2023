using Godot;
using Reoria.Enumerations;
using Reoria.Enumerations.Nodes.Entities.Actors;
using Reoria.Godot.Data.Types;
using Reoria.Godot.Nodes.Entities.Data;

namespace Reoria.Godot.Nodes.Entities.Actors.Data;

public partial class ActorData : EntityData
{
    [Export]
    public ActorState State = ActorState.Idle;
    [Export]
    public Direction Direction = Direction.Down;

    [Export]
    public VitalsType Vitals { get; protected set; }
    [Export]
    public StatsType Stats { get; protected set; }

    public override void _Ready()
    {
        this.Vitals = this.GetNode<VitalsType>("Vitals");
        this.Stats = this.GetNode<StatsType>("Stats");

        base._Ready();
    }
}