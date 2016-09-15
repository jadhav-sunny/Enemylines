using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Level[] allLevels;

    [SerializeField]
    private int currentLevel;

    private static LevelManager instance;

    public static LevelManager myLevelManager 
    {
        get 
        {
            return instance;
        }
    }

    void Awake()
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

	// Use this for initialization
	void Start () 
    {
        currentLevel = 0;
        //allLevels[currentLevel].gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () 
    {
	 
	}

    public void LoadNextLevel()
    {
        allLevels[currentLevel].gameObject.SetActive(false);
        currentLevel++;
        allLevels[currentLevel].gameObject.SetActive(true);
        ObjectManager.Instance.redEnemy = GameObject.FindGameObjectsWithTag("RedEnemy");
        ObjectManager.Instance.yellowEnemy = GameObject.FindGameObjectsWithTag("YellowEnemy");
    }
}
