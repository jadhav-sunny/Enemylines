using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour
{
    public void Movement(Vector2 axis,float speed,int facingInDirection)
    {
        transform.Translate(axis * facingInDirection * speed * Time.deltaTime);
    }

    public int ChangeDirection(int lookInDirection)
    {
        lookInDirection = -lookInDirection;
        return lookInDirection;
    }
}
