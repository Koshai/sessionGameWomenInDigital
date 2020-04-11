using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + gameManager.score.ToString();
    }
}
