namespace Reoria.Enumerations.Flags;

[Flags]
public enum StatFlags
{
    None = 0,

    Strength = Stats.Strength,
    Endurance = Stats.Endurance,
    Dexterity = Stats.Dexterity,
    Agility = Stats.Agility,
    Intelligence = Stats.Intelligence,
    Spirit = Stats.Spirit,
    Luck = Stats.Luck,

    All = Strength | Endurance | Dexterity | Agility| Intelligence | Spirit | Luck
}