extends CharacterBody2D

@export var movement_speed: int = 300

func handle_player_input() -> Vector2:
	return Vector2(
		Input.get_axis("MOVEMENT_LEFT", "MOVEMENT_RIGHT"),
		Input.get_axis("MOVEMENT_UP", "MOVEMENT_DOWN")
	).normalized()

func _physics_process(delta):
	var is_running: bool = Input.is_key_pressed(KEY_SHIFT)
	velocity = handle_player_input() * (movement_speed / (1 if is_running else 2))
	move_and_slide()
