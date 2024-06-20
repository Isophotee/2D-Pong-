using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Single : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode space;
    public float speed;
    private Vector2 playerMove;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerControl();
    }

    private void playerControl()
    {
        playerMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rb2d.velocity = playerMove * speed;
    }
}