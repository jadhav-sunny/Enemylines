using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour
{
    public float enemySpeed;

    void Update()
    {
        Movement(enemySpeed);
    }

    void Movement(float speed)
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    int Direction()
    {
        return 0;
    }
}
