﻿using Godot;
using Reoria.Enumerations.Nodes.Entities.Actors;
using Reoria.Nodes.Entities.Actors;
using static Reoria.Extensions.Enumerations.DirectionExtensions;

namespace Reoria.Logic.Entities.Actors;

public partial class ActorMovementLogic : Node2D
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
        this.Owner.Velocity = this.Input * this.Owner.Data.Stats.Agility;

        this.Owner.Data.State = ActorState.Idle;

        if (this.Owner.Velocity != Vector2.Zero)
        {
            this.Owner.Data.State = ActorState.Moving;
            this.Owner.Data.Direction = CalculateDirectionFromVector2(this.Owner.Velocity);

            _ = this.Owner.MoveAndSlide();
        }

        this.Owner.AnimationPlayer.Play($"actor_animations/{this.Owner.Data.State}_{this.Owner.Data.Direction}".ToLower(), 0, this.Owner.Data.Stats.Agility / 16f * 2);

        base._PhysicsProcess(delta);
    }
}