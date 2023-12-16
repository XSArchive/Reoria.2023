using System;

namespace Reoria.Enumerations.Nodes.Entities.Actors;

[Flags]
public enum ActorStateFlags
{
    None = 0,
    
    Idle = ActorState.Idle,
    Moving = ActorState.Moving,

    All = Idle | Moving
}