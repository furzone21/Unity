using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Update is called once per frame
    void Update()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10) 
        { 
            Destroy(gameObject); 
        }
    }
}
