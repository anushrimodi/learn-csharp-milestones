using UnityEngine;

/// <summary>
/// This script demonstrates declaring basic variables 
/// and printing them to the Console for learning purposes.
/// </summary>
public class LearningCurve : MonoBehaviour
{
    // Single-line comment: Declaring variables of different data types
    public int score = 100;
    public float speed = 4.5f;
    public string playerName = "Anushri";
    public bool isGameOver = false;

    /*
     * Multi-line comment:
     * The Start() method runs once before the first frame update.
     * We'll use it to print our variables to the Unity Console.
     */
    void Start()
    {
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Score: " + score);
        Debug.Log("Speed: " + speed);
        Debug.Log("Game Over: " + isGameOver);
    }

    // Update is called once per frame
    void Update()
    {
        // This method runs every frame, but we don't need it for now
    }
}
