using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D rb;

    public float minSpeed = 1f;
    public float maxSpeed = 4f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + Vector2.right * Time.fixedDeltaTime * speed);
    }
}
