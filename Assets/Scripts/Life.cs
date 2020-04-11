using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    public TMP_Text life;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        life.text = "Life: " + gameManager.lives.ToString();
    }
}
