using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour
{
    [SerializeField]
    private float enemySpeed;

    [SerializeField]
    private int directionFacing;

    void Update()
    {
        Movement(enemySpeed,directionFacing);
    }

    void Movement(float speed, int dir)
    {
        transform.Translate(Vector2.right * dir * Time.deltaTime * speed);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            directionFacing = -directionFacing;
        }
    }
}
