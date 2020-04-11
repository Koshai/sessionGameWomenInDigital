using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public Player player;

    public void AddScore(int addedScore)
    {
        score += addedScore;
    }

    public void LoseLife()
    {
        lives -= 1;
    }

    private void Update()
    {
        if(lives == 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Destroy(player);
        Debug.Log("Game Over");
    }
}
