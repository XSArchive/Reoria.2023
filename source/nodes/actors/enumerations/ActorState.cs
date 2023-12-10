using System;

namespace Reoria.Nodes.Actors.Enumerations;

[Flags]
public enum ActorState
{
    Idle = 1 << 0,
    Moving = 1 << 1
}