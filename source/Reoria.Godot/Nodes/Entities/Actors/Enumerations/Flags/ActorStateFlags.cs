namespace Reoria.Godot.Nodes.Entities.Actors.Enumerations.Flags;

[Flags]
public enum ActorStateFlags
{
    None = 0,
    
    Idle = ActorState.Idle,
    Moving = ActorState.Moving,

    All = Idle | Moving
}