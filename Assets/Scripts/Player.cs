using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float turnSpeed = 10.0f;
    public GameObject bullet;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f,0f,0.08f));

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(0.3f, 0, 0) * -turnSpeed * Time.deltaTime);
        }
            

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.3f, 0, 0) * turnSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ground")
        {
            gameManager.LoseLife();
        }
    }
}
