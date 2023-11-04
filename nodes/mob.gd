extends CharacterBody2D

@export var movement_speed: float = 200
@onready var animation_player: AnimationPlayer = $AnimationPlayer
@export var state: String = "Idle"
@export var direction: String = "Down"
@export var input: Vector2 = Vector2.ZERO
@export var is_sprinting: bool = false

var target: Vector2 = Vector2.ZERO
var target_tick: float = 0

func update_animation() -> void:
	state = "Idle"
	
	if(input.y != 0): 
		state = "Walking" 
		direction = "Up" if input.y < 0 else "Down"
	elif(input.x != 0): 
		state = "Walking" 
		direction = "Left" if input.x < 0 else "Right"
	
	animation_player.play(state + "_" + direction, -1, (2 if is_sprinting else 1) )

func _process(_delta):
	pass

func _physics_process(_delta):
	velocity = input * (movement_speed / (1 if is_sprinting else 2))
	
	update_animation()
	move_and_slide()
