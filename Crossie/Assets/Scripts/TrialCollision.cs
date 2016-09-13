using UnityEngine;
using System.Collections;

public class TrialCollision : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Aabb.Colliding(g1, g2))
        {
            Debug.Log("p");
        }
	}
}
