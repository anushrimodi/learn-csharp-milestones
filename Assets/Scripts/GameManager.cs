using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Singleton pattern for global access
    public static GameManager Instance { get; private set; }

    [Header("UI References")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI itemsText;
    public TextMeshProUGUI winText;

    [Header("Game Stats")]
    private int health = 3;
    private int itemsCollected = 0;
    public int itemsToWin = 3;

    void Awake()
    {
        // Ensure only one GameManager exists
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); // Optional persistence
    }

    void Start()
    {
        UpdateUI();

        // Hide win text at start
        if (winText != null)
            winText.gameObject.SetActive(false);
    }

    // --- PROPERTIES ---
    public int Health
    {
        get => health;
        set
        {
            health = Mathf.Max(0, value);
            UpdateUI();

            if (health <= 0)
                GameOver();
        }
    }

    public int Items
    {
        get => itemsCollected;
        set
        {
            itemsCollected = value;
            UpdateUI();

            if (itemsCollected >= itemsToWin)
                WinGame();
        }
    }

    // --- UI UPDATES ---
    private void UpdateUI()
    {
        if (healthText != null)
            healthText.text = $"Health: {health}";
        if (itemsText != null)
            itemsText.text = $"Items: {itemsCollected}/{itemsToWin}";
    }

    // --- GAME STATES ---
    private void WinGame()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(true);
            winText.text = "🎉 You Win! 🎉";
        }

        Time.timeScale = 0f; // Pause the game
        Debug.Log("✅ Game Paused — You Win!");
    }

    private void GameOver()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(true);
            winText.text = "💀 Game Over 💀";
        }

        Time.timeScale = 0f; // Pause the game
        Debug.Log("❌ Game Paused — Game Over");
    }

    // --- HELPER METHODS ---
    public void CollectItem()
    {
        Items++;
        Debug.Log("Collected item! Total: " + itemsCollected);
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Debug.Log("Player took damage. Health: " + health);
    }
}
