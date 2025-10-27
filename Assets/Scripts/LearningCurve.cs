using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // ---------- Variables (public vs private) ----------
    public int health = 100;                 // public: visible in Inspector & other scripts
    private float speed = 3.5f;              // private: only this script can access
    public string playerName = "Anushri";    // public string
    private bool isAlive = true;             // private bool

    /*
     Multi-line comment:
     This script demonstrates:
     - public vs. private access modifiers
     - Debug.Log and Debug.LogFormat
     - Concatenation with + and string interpolation ($)
     - Methods with parameters and return values
     - Control flow (if/else, nested if, switch)
     - Collections (Array, List<T>, Dictionary<TKey,TValue>)
     - Loops (for, foreach)
     - OOP (classes, structs, inheritance, overrides)
     - Referencing scene objects/components
    */

    /// <summary>
    /// Control Flow and Collection Types (65–93) + OOP (94–119)
    /// </summary>
    void Start()
    {
        // ---------- Logging / formatting ----------
        Debug.Log("Player: " + playerName + " | Health: " + health);               // concatenation with +
        Debug.Log($"Speed: {speed} | Alive: {isAlive}");                            // string interpolation with $
        Debug.LogFormat("Player {0} has {1} health points.", playerName, health);   // Debug.LogFormat

        // ---------- Methods (parameters, return values) ----------
        int newHealth = TakeDamage(25);                                             // use returned data
        Debug.Log($"After taking damage, {playerName} has {newHealth} health left.");
        string status = GetStatusMessage(playerName, isAlive);
        Debug.Log(status);

        // ========== CONDITIONALS ==========
        // if / else if / else
        if (health > 75)
        {
            Debug.Log("Conditionals: Healthy!");
        }
        else if (health > 0)
        {
            Debug.Log("Conditionals: Hurt, but still going.");
        }
        else
        {
            Debug.Log("Conditionals: Down!");
        }

        // test for true and !true
        if (isAlive)
        {
            Debug.Log("isAlive is true.");
        }
        if (!isAlive)
        {
            Debug.Log("!isAlive is true (player is not alive).");
        }

        // nested if
        if (health > 0)
        {
            if (health < 50)
            {
                Debug.Log("Nested if: low health warning!");
            }
        }

        // switch statement
        switch (playerName)
        {
            case "Anushri":
                Debug.Log("Switch: Hello, Anushri!");
                break;
            case "Alex":
                Debug.Log("Switch: Hello, Alex!");
                break;
            default:
                Debug.Log("Switch: Hello, Player!");
                break;
        }

        // ========== COLLECTIONS ==========
        // ✏️ arr[1] from int[] arr = {'red','green','blue'} is invalid types; correct:
        // string[] arr = { "red", "green", "blue" }; -> arr[1] returns "green".
        string[] colors = { "red", "green", "blue" };              // Array (string[] example)
        int[] numbers = new int[] { 10, 20, 30, 40 };              // Array of type int[]

        List<string> fruits = new List<string> { "apple", "banana", "cherry" };   // List<string>
        Dictionary<string, int> scores = new Dictionary<string, int>              // Dictionary<string, int>
        {
            { "Alice", 10 },
            { "Bob", 15 },
            { "Charlie", 20 }
        };

        Debug.Log("Array sample colors[1] = " + colors[1]);        // should log "green"

        // ========== LOOPS ==========
        // Use a for loop to print a specific index of a List<string> (e.g., index 1)
        for (int i = 0; i < fruits.Count; i++)
        {
            if (i == 1)
            {
                Debug.Log("for loop (specific index 1 of List): " + fruits[i]); // "banana"
            }
        }

        // Use a foreach loop to print all indexes of a List<string>
        // (foreach doesn't give index directly, so track it manually)
        int idx = 0;
        foreach (var fruit in fruits)
        {
            Debug.Log($"foreach List index {idx}: {fruit}");
            idx++;
        }

        // Use a foreach loop to print the Key and Value of all entries in a Dictionary<string, int>
        foreach (KeyValuePair<string, int> kv in scores)
        {
            Debug.Log($"Dictionary entry -> Key: {kv.Key}, Value: {kv.Value}");
        }

        // ========== OOP: CLASSES ==========
        Character hero = new Character("Hero Aria", 10);
        Character heroine = new Character("Heroine Mira", 8);
        hero.PrintStatsInfo();
        heroine.PrintStatsInfo();

        // ========== OOP: STRUCTS ==========
        Weapon huntingBow = new Weapon("Hunting Bow", 12);
        Weapon warBow     = new Weapon("War Bow", 20);
        Debug.Log($"Weapon A: {huntingBow}");
        Debug.Log($"Weapon B: {warBow}");

        // ========== OOP: CHILD CLASS ==========
        Paladin knight = new Paladin("Sir Anush", 12, new Weapon("Holy Blade", 25));
        knight.PrintStatsInfo(); // override prints paladin’s name + weapon

        // ========== REFERENCING OBJECTS ==========
        // 1) Main Camera Transform via GetComponent<>
        Transform camTransform = GetComponent<Transform>();
        Debug.Log($"Main Camera localPosition: {camTransform.localPosition}");

        // 2) Light GameObject via GameObject.Find(), then its Transform via GetComponent<>
        GameObject lightGO = GameObject.Find("Light") ?? GameObject.Find("Directional Light");
        if (lightGO != null)
        {
            Transform lightT = lightGO.GetComponent<Transform>();
            Debug.Log($"Light localPosition: {lightT.localPosition}");
        }
        else
        {
            Debug.LogWarning("No GameObject named 'Light' or 'Directional Light' found.");
        }
    }

    // ---------- Methods ----------
    // Method with parameter + return type
    private int TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
        return health;
    }

    // Method with parameters returning a string
    private string GetStatusMessage(string name, bool alive)
    {
        return alive ? $"{name} is still alive!" : $"{name} has fallen...";
    }
}
