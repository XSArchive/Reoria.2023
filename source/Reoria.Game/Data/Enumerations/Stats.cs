namespace Reoria.Game.Data.Enumerations;

/// <summary>
/// Defines flag values for <see cref="Stats"/>.
/// </summary>
[Flags]
public enum Stats
{
    /// <summary>
    /// Defines the flag value for <see cref="Strength"/>.
    /// </summary>
    Strength = 1 << 0,
    /// <summary>
    /// Defines the flag value for <see cref="Endurance"/>.
    /// </summary>
    Endurance = 1 << 1,
    /// <summary>
    /// Defines the flag value for <see cref="Dexterity"/>.
    /// </summary>
    Dexterity = 1 << 2,
    /// <summary>
    /// Defines the flag value for <see cref="Agility"/>.
    /// </summary>
    Agility = 1 << 3,
    /// <summary>
    /// Defines the flag value for <see cref="Intelligence"/>.
    /// </summary>
    Intelligence = 1 << 4,
    /// <summary>
    /// Defines the flag value for <see cref="Spirit"/>.
    /// </summary>
    Spirit = 1 << 5,
    /// <summary>
    /// Defines the flag value for <see cref="Luck"/>.
    /// </summary>
    Luck = 1 << 6
}
