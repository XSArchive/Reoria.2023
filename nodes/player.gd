extends "mob.gd"

func handle_player_input() -> Vector2:
	return Vector2(
		Input.get_axis("MOVEMENT_LEFT", "MOVEMENT_RIGHT"),
		Input.get_axis("MOVEMENT_UP", "MOVEMENT_DOWN")
	).normalized()

func _process(_delta):
	is_sprinting = Input.is_key_pressed(KEY_SHIFT)
	input = handle_player_input()
