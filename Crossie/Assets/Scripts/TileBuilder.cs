using UnityEngine;
using System.Collections;
using UnityEditor;

public class TileBuilder : MonoBehaviour
{
    public GameObject tile;

    public int noOfTiles = 4;

    Vector3 currentPos = Vector3.zero;
    public Vector3 offSet;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
	   if (Input.GetKeyDown(KeyCode.B))
       {
           BuildTiles();
       }
	}

    /*public void BuildTiles()
    {
        
    }*/
    void BuildTiles()
    {
        for (int i = 0; i < noOfTiles; i++)
        {
            Instantiate(tile, currentPos, Quaternion.identity);
            currentPos = currentPos + offSet;
        }
    }

    /*void OnTriggerEnter2D (Collider2D col)
    {
        touching = true;
        Debug.Log(touching);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        touching = false;
        Debug.Log(touching);
    }*/

}
