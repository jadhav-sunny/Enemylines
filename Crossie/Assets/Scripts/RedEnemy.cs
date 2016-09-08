using UnityEngine;
using System.Collections;

public class RedEnemy : Enemies
{
    /*
     * facingDirection
     * 1 - Up/Right
     * -1 - Down/Left
     */
    int facingDirection;
    public float speed;

    void Start()
    {
        if (gameObject.tag == "RightDirection")
        {
            facingDirection = 1;
        }
        else if (gameObject.tag == "LeftDirection")
        {
            facingDirection = -1;
        }
        else
        {
            facingDirection = 0;
        }
        
    }

    void Update()
    {
        Movement(new Vector2(1, 0), speed,facingDirection);  
    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Wall")
        {
           facingDirection = ChangeDirection(facingDirection);
        }
    }
}
