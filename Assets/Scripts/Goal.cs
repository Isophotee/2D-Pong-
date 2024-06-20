using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject Ball;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D hitinfo)
    {
        if (hitinfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.instance.Score(wallName);
            hitinfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
