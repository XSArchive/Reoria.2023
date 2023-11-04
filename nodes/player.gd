extends CharacterBody2D

@export var movement_speed: int = 200
@onready var animation_player: AnimationPlayer = $AnimationPlayer
@export var state = "Idle"
@export var direction = "Down"

func handle_player_input() -> Vector2:
	return Vector2(
		Input.get_axis("MOVEMENT_LEFT", "MOVEMENT_RIGHT"),
		Input.get_axis("MOVEMENT_UP", "MOVEMENT_DOWN")
	).normalized()

func update_animation(input_vector: Vector2, is_sprinting: bool) -> void:
	state = "Idle"
	
	if(input_vector.y != 0): 
		state = "Walking" 
		direction = "Up" if input_vector.y < 0 else "Down"
	elif(input_vector.x != 0): 
		state = "Walking" 
		direction = "Left" if input_vector.x < 0 else "Right"
	
	animation_player.play(state + "_" + direction, -1, (2 if is_sprinting else 1) )

func _physics_process(delta):
	var is_sprinting: bool = Input.is_key_pressed(KEY_SHIFT)
	var input: Vector2 = handle_player_input()
	
	velocity = input * (movement_speed / (1 if is_sprinting else 2))
	update_animation(input, is_sprinting)
	move_and_slide()
