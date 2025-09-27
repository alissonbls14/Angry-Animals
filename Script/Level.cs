using Godot;

/// <summary>
/// Represents a game level.
/// Spawns animals at the defined marker and listens for their death to respawn a new one.
/// </summary>
public partial class Level : Node2D
{
	[Export] PackedScene _animalScene;
	[Export] Marker2D _spawnMarker;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Spawns an Animal at the start of the game.
		SpawnAnimal();

		// Connects the respawn signal.
		SignalManager.Instance.Connect(SignalManager.SignalName.OnAnimalDied, Callable.From(SpawnAnimal));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Allows returning to the main menu by pressing the Q key.
		if (Input.IsKeyPressed(Key.Q)) GameManager.LoadMain();
	}


	/// <summary>
	/// Instanciates and spawns a new animal at the spawn marker position.
	/// </summary>
	private void SpawnAnimal()
	{
		Animal newAnimal = _animalScene.Instantiate<Animal>();
        newAnimal.Position = _spawnMarker.Position;
		AddChild(newAnimal);
	}
}