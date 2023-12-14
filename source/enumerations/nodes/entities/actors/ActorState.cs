using System;

namespace Reoria.Enumerations.Nodes.Entities.Actors;

[Flags]
public enum ActorState
{
    Idle = 1 << 0,
    Moving = 1 << 1,

    None = 0,
    All = Idle | Moving
}