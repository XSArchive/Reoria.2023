using System;

namespace Reoria.Enumerations;

[Flags]
public enum VitalFlags
{
    None = 0,

    Health = Vitals.Health,
    Mana = Vitals.Mana,
    Stamina = Vitals.Stamina,

    All = Health | Mana | Stamina
}