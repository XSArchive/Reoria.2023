using Godot;
using Reoria.Enumerations.Nodes.Entities.Actors;
using static Reoria.Extensions.Enumerations.DirectionExtensions;

namespace Reoria.Nodes.Entities.Actors;

public partial class ActorMovementProcessor : Node2D
{
    [Export]
    public Actor Parent { get; private set; }
    [Export]
    public Vector2 Input = Vector2.Zero;
    [Export]
    public float Speed = 16f;
    public override void _Ready()
    {
        this.Parent = this.GetOwner<Actor>();
        this.Input = Vector2.Zero;

        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        this.Parent.Velocity = this.Input * this.Speed;

        this.Parent.State = ActorState.Idle;

        if (this.Parent.Velocity != Vector2.Zero)
        {
            this.Parent.State = ActorState.Moving;
            this.Parent.Direction = CalculateDirectionFromVector2(this.Parent.Velocity);

            _ = this.Parent.MoveAndSlide();
        }

        this.Parent.AnimationPlayer.Play($"actor_animations/{this.Parent.State}_{this.Parent.Direction}".ToLower(), 0, this.Speed / 16f * 2);

        base._PhysicsProcess(delta);
    }
}