using UnityEngine;

public class Skittle : MonoBehaviour
{
    private bool isKnockedOver = false;
    private float thresholdAngle = 30.0f; // Angle in degrees to consider the skittle knocked over

    void Update()
    {
        if (!isKnockedOver && transform.up.y < Mathf.Cos(thresholdAngle * Mathf.Deg2Rad))
        {
            isKnockedOver = true;
            ScoreManager.instance.IncrementScore(); // You will need a ScoreManager to keep track of the score
        }
    }
}
