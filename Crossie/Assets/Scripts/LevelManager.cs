using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Level[] allLevels;

    [SerializeField]
    private int currentLevel;

    public LevelManager myLevelManager;

    void Awake()
    {
        myLevelManager = this;
    }

	// Use this for initialization
	void Start () 
    {
        currentLevel = 0;
        allLevels[currentLevel].gameObject.SetActive(true);
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
    }
}
