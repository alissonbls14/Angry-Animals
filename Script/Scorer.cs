using Godot;

/// <summary>
/// Tracks the player's performance within a level.
/// Counts destroyed cups, number of attempts, and updates the ScoreManager when conditions are met.
/// </summary>
public partial class Scorer : Node
{
	private int _totalCups;
	private int _cupsDestroyed;
	private int _attempt = 0;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Listens for when a cup is destroyed.
		SignalManager.Instance.Connect(SignalManager.SignalName.OnCupDestroyed, Callable.From(OnLevelFinished));
		
		//Listen for when the player makes an attempt.
		SignalManager.Instance.Connect(SignalManager.SignalName.OnAttemptMade, Callable.From(OnAttemptMade));

		// Count all cups currently in the level (grouped by cup.GROUP_NAME);
		_totalCups = GetTree().GetNodesInGroup(Cup.GROUP_NAME).Count;
	}


	/// <summary>
	/// Called when a cup is destroyed.
	/// If all cups are destroyed, the level is completed, and the score is save in ScoreManager.
	/// </summary>
	private void OnLevelFinished()
	{
		_cupsDestroyed++;

		if (_cupsDestroyed == _totalCups)
		{
			SignalManager.EmitOnLevelCompleted();
			ScoreManager.SetLevelScore(ScoreManager.GetLevel(), _attempt);
		}
	}


	/// <summary>
	/// Called whenever the player makes an attempt.
	/// Increments attempt counter and updates the score display.
	/// </summary>
	private void OnAttemptMade()
	{
		_attempt++;
		SignalManager.EmitOnScoreUpdated(_attempt);
	}
}