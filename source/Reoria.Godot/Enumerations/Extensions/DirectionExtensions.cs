using Godot;
using Reoria.Enumerations;

namespace Reoria.Godot.Enumerations.Extensions;

public static class DirectionExtensions
{
    public static Direction CalculateDirectionFromVector2(Vector2 vector)
    {
        return Mathf.Abs(vector.X) > Mathf.Abs(vector.Y)
            ? vector.X < 0 ? Direction.Left : Direction.Right
            : vector.Y < 0 ? Direction.Up : Direction.Down;
    }
    public static Direction CalculateDirectionFromVector2I(Vector2I vector)
    {
        return Mathf.Abs(vector.X) > Mathf.Abs(vector.Y)
            ? vector.X < 0 ? Direction.Left : Direction.Right
            : vector.Y < 0 ? Direction.Up : Direction.Down;
    }
}