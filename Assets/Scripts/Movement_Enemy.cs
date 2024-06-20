using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private Vector2 playerMove;
    public GameObject Ball;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        AIControl();
    }

    void AIControl()
    {
        if (Ball.transform.position.y > transform.position.y + 0.5f)
        {
            playerMove = new Vector2 (0, 1);
        } 
        else if (Ball.transform.position.y < transform.position.y - 0.5f)
        {
            playerMove = new Vector2 (0, -1);
        } 
        else 
        {
            playerMove = new Vector2 (0, 0);
        }
    }

    private void FixedUpdate(){
        rb2d.velocity = playerMove * speed;
    }
}
