using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int knockedOverCount = 0;
    public int totalSkittles;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void IncrementScore()
    {
        knockedOverCount++;
        if (knockedOverCount >= totalSkittles)
        {
            Debug.Log("All skittles knocked over!");
            // Implement what happens when all skittles are down
        }
    }

    // Use this to reset the game or when initializing
    public void ResetScore()
    {
        knockedOverCount = 0;
    }
}
