using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstrates variables, access modifiers, string formatting,
/// conditionals, collections, and loops in Unity.
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
        // --- VARIABLES ---
        Debug.Log("Player: " + playerName + " | Level: " + playerLevel);
        Debug.Log($"Score: {score}, Speed: {speed}, Game Over: {isGameOver}");
        Debug.LogFormat("Player {0} is at Level {1} with a speed of {2}", playerName, playerLevel, speed);

        int finalScore = AddBonus(score, 50);
        Debug.Log($"Final score after bonus: {finalScore}");

        string message = GetStatusMessage(playerName, isGameOver);
        Debug.Log(message);

        // --- CONDITIONALS ---
        if (score > 150)
        {
            Debug.Log("High score achieved!");
        }
        else if (score > 50 && !isGameOver)
        {
            Debug.Log("Keep going, you're doing great!");
        }
        else
        {
            Debug.Log("Try again to improve your score.");
        }

        // Nested if statement
        if (!isGameOver)
        {
            if (playerLevel > 2)
            {
                Debug.Log("Advanced player detected!");
            }
        }

        // Switch statement
        switch (playerLevel)
        {
            case 1:
                Debug.Log("Beginner level");
                break;
            case 2:
                Debug.Log("Intermediate level");
                break;
            case 3:
                Debug.Log("Advanced level");
                break;
            default:
                Debug.Log("Unknown level");
                break;
        }

        // --- COLLECTIONS ---
        int[] numbers = { 10, 20, 30, 40, 50 };
        List<string> colors = new List<string> { "red", "green", "blue" };
        Dictionary<string, int> scores = new Dictionary<string, int>()
        {
            {"Anushri", 100},
            {"Srijit", 120},
            {"Mary", 90}
        };

        Debug.Log($"arr[1] from colors array returns: {colors[1]}");  // Should log "green"

        // --- LOOPS ---
        // For loop to print specific index of List<string>
        for (int i = 0; i < colors.Count; i++)
        {
            if (i == 1)
            {
                Debug.Log($"Color at index 1: {colors[i]}");
            }
        }

        // Foreach loop to print all indexes of a List<string>
        foreach (string color in colors)
        {
            Debug.Log($"Color: {color}");
        }

        // Foreach loop to print KeyValuePair from Dictionary<string, int>
        foreach (KeyValuePair<string, int> entry in scores)
        {
            Debug.Log($"Player: {entry.Key}, Score: {entry.Value}");
        }
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
