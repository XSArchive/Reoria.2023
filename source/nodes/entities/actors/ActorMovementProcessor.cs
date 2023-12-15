using Godot;
using Reoria.Enumerations.Nodes.Entities.Actors;
using static Reoria.Extensions.Enumerations.DirectionExtensions;

namespace Reoria.Nodes.Entities.Actors;

public partial class ActorMovementProcessor : Node2D
{
    [Export]
    public new Actor Owner { get; private set; }
    [Export]
    public Vector2 Input = Vector2.Zero;

    public override void _Ready()
    {
        this.Owner = this.GetOwner<Actor>();
        this.Input = Vector2.Zero;

        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        this.Owner.Velocity = this.Input * this.Owner.Data.MovementSpeed;

        this.Owner.State = ActorState.Idle;

        if (this.Owner.Velocity != Vector2.Zero)
        {
            this.Owner.State = ActorState.Moving;
            this.Owner.Direction = CalculateDirectionFromVector2(this.Owner.Velocity);

            _ = this.Owner.MoveAndSlide();
        }

        this.Owner.AnimationPlayer.Play($"actor_animations/{this.Owner.State}_{this.Owner.Direction}".ToLower(), 0, this.Owner.Data.MovementSpeed / 16f * 2);

        base._PhysicsProcess(delta);
    }
}