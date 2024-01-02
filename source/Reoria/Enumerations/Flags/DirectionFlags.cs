using System;

namespace Reoria.Enumerations.Flags;

[Flags]
public enum DirectionFlags
{
    None = 0,

    Up = Direction.Up,
    Down = Direction.Down,
    Left = Direction.Left,
    Right = Direction.Right,

    All = Up | Down | Left | Right
}