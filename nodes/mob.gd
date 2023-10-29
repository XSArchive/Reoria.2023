extends CharacterBody2D

@export var movement_speed: int = 200
@onready var animation_player: AnimationPlayer = $AnimationPlayer
@export var state = "Idle"
@export var direction = "Down"

