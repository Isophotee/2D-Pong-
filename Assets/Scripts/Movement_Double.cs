using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Double : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode space;
    public float speed;
    private Vector2 playerMove;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerControl();
    }

    void playerControl()
    {
        if (gameObject.name == "Player")
        {
            playerMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
        } 
        else 
        {
            playerMove = new Vector2(0, Input.GetAxisRaw("Vertical2"));
        }
    }

    void FixedUpdate()
    {
        rb2d.velocity = playerMove * speed;
    }

    // private void playerAbility()
    // {
    //     if(space)
    //     {

    //     }
    // }
}
