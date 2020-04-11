using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int lives;
    public int score;
    public GameObject enemybullet;
    public GameManager gameManager;

    // Update is called once per frame
    private void Start()
    {
        StartCoroutine("ShootBullet");
    }

    void Update()
    {
        if(lives == 0)
        {
            Destroy(gameObject);
            gameManager.AddScore(score);
        }
    }

    IEnumerator ShootBullet()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemybullet, transform.position, Quaternion.identity);
        }
        
    }
}
