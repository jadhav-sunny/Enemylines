using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour 
{

    private static ObjectManager instance;
    public static ObjectManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }


    public GameObject player;

    public GameObject redEnemy;

    //[SerializeField]
    //private GameObject wall;
    
}
