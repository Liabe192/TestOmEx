using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    [SerializeField] private TMP_Text collectibleText;

    private int collectibleCount = 0;

    void Awake()
    {
        // Simple singleton so other scripts can access it
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddCollectible(int amount = 1)
    {
        collectibleCount += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        collectibleText.text = collectibleCount.ToString();
    }
}