using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isP1Goal;
    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isP1Goal)
                scoreManager.P1Scored();
            else
                scoreManager.P2Scored();
        }
    }
}