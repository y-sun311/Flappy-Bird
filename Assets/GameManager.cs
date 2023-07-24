using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    // Method to call when the game is over.
    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    // Method to call when increasing the score.
    public void IncreaseScore()
    {
        score++;
    }
}

