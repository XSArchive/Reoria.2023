using Godot;
using Reoria.Data.Types;
using Reoria.Enumerations;

namespace Reoria.Data.Entities.Actors;

public partial class StatsType : EnumeratedType<Stats, int>
{
    [Export]
    public int Strength { get => this.GetValue(Stats.Strength); set => this.SetValue(Stats.Strength, value); }
    [Export]
    public int Endurance { get => this.GetValue(Stats.Endurance); set => this.SetValue(Stats.Endurance, value); }
    [Export]
    public int Dexterity { get => this.GetValue(Stats.Dexterity); set => this.SetValue(Stats.Dexterity, value); }
    [Export]
    public int Agility { get => this.GetValue(Stats.Agility); set => this.SetValue(Stats.Agility, value); }
    [Export]
    public int Intelligence { get => this.GetValue(Stats.Intelligence); set => this.SetValue(Stats.Intelligence, value); }
    [Export]
    public int Spirit { get => this.GetValue(Stats.Spirit); set => this.SetValue(Stats.Spirit, value); }
    [Export]
    public int Luck { get => this.GetValue(Stats.Luck); set => this.SetValue(Stats.Luck, value); }

    public StatsType() => _ = this.Populate();
}