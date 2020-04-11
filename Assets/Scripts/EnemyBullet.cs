using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 moveDirection = (player.transform.position - transform.position).normalized * 100f;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
    }
}
