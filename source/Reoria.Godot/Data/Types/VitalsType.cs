using Godot;
using Reoria.Enumerations;

namespace Reoria.Godot.Data.Types;

public partial class VitalsType : EnumeratedType<Vitals, int>
{
    [Export]
    public int Health { get => this.GetValue(Vitals.Health); set => this.SetValue(Vitals.Health, value); }
    [Export]
    public int Mana { get => this.GetValue(Vitals.Mana); set => this.SetValue(Vitals.Mana, value); }
    [Export]
    public int Stamina { get => this.GetValue(Vitals.Stamina); set => this.SetValue(Vitals.Stamina, value); }

    public VitalsType() => _ = this.Populate();
}