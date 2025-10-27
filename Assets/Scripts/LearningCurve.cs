using UnityEngine;

/// <summary>
/// Demonstrates variables, access modifiers, string formatting,
/// and simple methods with parameters and return values.
/// </summary>
public class LearningCurve : MonoBehaviour
{
    // Public variables - visible in Inspector
    public int score = 100;
    public float speed = 5.75f;
    public string playerName = "Anushri";
    public bool isGameOver = false;

    // Private variable - hidden from Inspector
    private int playerLevel = 3;

    void Start()
    {
        // Using concatenation
        Debug.Log("Player: " + playerName + " | Level: " + playerLevel);

        // Using string interpolation
        Debug.Log($"Score: {score}, Speed: {speed}, Game Over: {isGameOver}");

        // Using Debug.LogFormat
        Debug.LogFormat("Player {0} is at Level {1} with a speed of {2}", playerName, playerLevel, speed);

        // Calling a method with parameters and using its return value
        int finalScore = AddBonus(score, 50);
        Debug.Log($"Final score after bonus: {finalScore}");

        // Calling a string-returning method
        string message = GetStatusMessage(playerName, isGameOver);
        Debug.Log(message);
    }

    // Example method with parameters and a return type
    private int AddBonus(int baseScore, int bonus)
    {
        int total = baseScore + bonus;
        return total;
    }

    // Method returning a string based on logic
    private string GetStatusMessage(string name, bool gameStatus)
    {
        if (gameStatus)
        {
            return $"{name}'s game is over!";
        }
        else
        {
            return $"{name} is still playing and going strong!";
        }
    }

    void Update()
    {
        // Runs every frame — left empty for now
    }
}
