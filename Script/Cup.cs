using Godot;

/// <summary>
/// Represents a destructible cup object in the level.
/// Plays an animation before being destroyed.
/// </summary>
public partial class Cup : StaticBody2D
{
	public const string GROUP_NAME = "cup";

	[Export] AnimationPlayer _vanishAnimation;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Connects the vanish animation to its destruction event.
		_vanishAnimation.AnimationFinished += OnAnimationFinished;
	}


    /// <summary>
    /// Triggered when the vanish animation finishes.
    /// Emits the cup destroyed signal and removes the node from the scene.
    /// </summary>
    /// <param name="animName"></param>
    private void OnAnimationFinished(StringName animName)
	{
		SignalManager.EmitOnCupDestroyed();
		QueueFree();
	}


    /// <summary>
    /// Starts the vanish animation, leading to destruction.
    /// </summary>
    public void Die() => _vanishAnimation.Play("vanish");
}