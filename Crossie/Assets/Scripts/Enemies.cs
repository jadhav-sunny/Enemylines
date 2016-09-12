using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour
{
    [SerializeField]
    private float enemySpeed;

    [SerializeField]
    private int directionFacing;

    public enum MovementType
    {
        horizontal,
        vertical
    };

    public enum InitialDirection
    {
        positiveAxis = 1,
        negativeAxis = -1
    };

    public MovementType enemyMovementType;

    public InitialDirection enenydirectionfacing;

    void Start()
    {
        directionFacing = (int)enenydirectionfacing;
    }

    void Update()
    {
        if (enemyMovementType == MovementType.horizontal)
        {
            HorizontalMovement(enemySpeed, directionFacing);
        }
        else if (enemyMovementType == MovementType.vertical)
        {
            VerticalMovement(enemySpeed, directionFacing);
        }
    }

    void HorizontalMovement(float speed, int dir)
    {
        transform.Translate(Vector2.right * dir * Time.deltaTime * speed);
    }

    void VerticalMovement(float speed, int dir)
    {
        transform.Translate(Vector2.up * dir * Time.deltaTime * speed);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            directionFacing = -directionFacing;
        }
    }
}
