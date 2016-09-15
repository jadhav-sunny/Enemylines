using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

    public GameObject[] redEnemy;

    public GameObject[] yellowEnemy;

    public GameObject door;

    void Start()
    {
        redEnemy = GameObject.FindGameObjectsWithTag("RedEnemy");
        yellowEnemy = GameObject.FindGameObjectsWithTag("YellowEnemy");
    }

    //[SerializeField]
    //private GameObject wall;
    
}
