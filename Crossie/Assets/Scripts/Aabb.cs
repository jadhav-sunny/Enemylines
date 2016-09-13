using UnityEngine;
using System.Collections;

public static class Aabb
{

    public static bool Colliding(GameObject a, GameObject b)
    {
        Rect aBox = a.BoxToRect();
        Rect bBox = b.BoxToRect();

        // Find out if these guys intersect
        return Intersect(aBox, bBox);
    }

    // This checks the intersection between two rectangles.
    public static bool Intersect(Rect a, Rect b)
    {
        // Basic AABB collision detection. All of these must be true for there to be a collision.
        bool comp1 = a.yMin > b.yMax;
        bool comp2 = a.yMax < b.yMin;
        bool comp3 = a.xMin < b.xMax;
        bool comp4 = a.xMax > b.xMin;

        // This will only return true if all are true.
        return comp1 && comp2 && comp3 && comp4;
    }

    //this converts a box2dcollider to a rectangle for use in determining the intersection
    private static Rect BoxToRect(this GameObject a)
    {
        //getting the box collider for gameobject
        BoxCollider2D aCollider = a.GetComponent<BoxCollider2D>();

        //grabbing the gameobject position and converting it to a vector2
        Vector2 aPos = a.transform.position.V2();

        // Now that we have the object's worldspace location, we offset that to the BoxCollider's center
        aPos += aCollider.offset;

        // From the center, we find the top/left corner by cutting the total height/width in half and
        // offset by that much
        aPos.x -= aCollider.size.x / 2;
        aPos.y += aCollider.size.y / 2;

        // Create a rectangle based on the top/left corner, and extending the rectangle
        // to the width/height
        return new Rect(aPos.x, aPos.y, aCollider.size.x, -aCollider.size.y);
    }

    //converts a vector3 to vector2
    private static Vector2 V2(this Vector3 v)
    {
        //converts the vector 3 to vector 2
        return new Vector2(v.x,v.y);
    }
}
