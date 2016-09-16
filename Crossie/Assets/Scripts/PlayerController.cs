using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rgbd;
    public float playerSpeed;

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        for (int i = 0; i < ObjectManager.Instance.redEnemy.Length;i++ )
        {
            if (Aabb.Colliding(ObjectManager.Instance.player, ObjectManager.Instance.redEnemy[i]))
            {
                transform.position = new Vector2(0, -9.56f);
            }
           
        }

        if (Aabb.Colliding(ObjectManager.Instance.player, ObjectManager.Instance.door))
        {
            Debug.Log("p");
            transform.position = new Vector2(0, -9.56f);
            LevelManager.myLevelManager.LoadNextLevel();
        }

        for (int j = 0; j < ObjectManager.Instance.walls.Length; j++)
        {
            if (Aabb.Colliding(ObjectManager.Instance.player, ObjectManager.Instance.walls[j]))
            {
                Debug.Log("p");
                //transform.position = new Vector2(0, -9.56f);
            }
        }
        
            

    }


	// Update is called once per frame
	/*void FixedUpdate () 
    {
        float velX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float velY = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        rgbd.velocity = new Vector2(velX, velY);
	}*/

    void FixedUpdate()
    {
        rgbd.velocity = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical")) * playerSpeed;
    }
}
