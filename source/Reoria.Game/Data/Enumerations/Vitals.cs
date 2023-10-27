namespace Reoria.Game.Data.Enumerations;

/// <summary>
/// Defines flag values for <see cref="Vitals"/>.
/// </summary>
[Flags]
public enum Vitals
{
    /// <summary>
    /// Defines the flag value for <see cref="Health"/>.
    /// </summary>
    Health = 1 << 0,
    /// <summary>
    /// Defines the flag value for <see cref="Mana"/>.
    /// </summary>
    Mana = 1 << 1,
    /// <summary>
    /// Defines the flag value for <see cref="Stamina"/>.
    /// </summary>
    Stamina = 1 << 2
}
