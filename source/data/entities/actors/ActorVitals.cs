using Godot;
using Reoria.Data.Types;
using Reoria.Enumerations;

namespace Reoria.Data.Entities.Actors;

public partial class ActorVitals : EnumeratedType<Vitals, int>
{
    [Export]
    public int Health { get => this.GetValue(Vitals.Health); set => this.SetValue(Vitals.Health, value); }
    [Export]
    public int Mana { get => this.GetValue(Vitals.Mana); set => this.SetValue(Vitals.Mana, value); }
    [Export]
    public int Stamina { get => this.GetValue(Vitals.Stamina); set => this.SetValue(Vitals.Stamina, value); }

    public ActorVitals() => _ = this.Populate();
}