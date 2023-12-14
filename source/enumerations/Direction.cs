using System;

namespace Reoria.Enumerations;

[Flags]
public enum Direction
{
    Up = 1 << 0,
    Down = 1 << 1,
    Left = 1 << 2,
    Right = 1 << 3,

    None = 0,
    All = Up | Down | Left | Right
}