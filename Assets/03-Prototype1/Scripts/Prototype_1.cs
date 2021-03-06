using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prototype_1 : MonoBehaviour
{
    static private Prototype_1 S;

    [Header("Set in Inspector")]
    public Vector3 mazePos;
    public GameObject[] mazes;

    [Header("Set Dynamically")]
    public int level;
    public int levelMax;
    public GameObject maze;
    public GameMode mode = GameMode.idle;

    public float speed = 0;
    public GameObject winTextObject;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    static public bool goalMet = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winTextObject.SetActive(false);

        level = 0;
        levelMax = mazes.Length;

        maze = Instantiate<GameObject>(mazes[level]);
        maze.transform.position = mazePos;

    }

     public void BulletDestroyed()
    {
        //Destroy all of the falling apples
        GameObject[] tBulletArray = GameObject.FindGameObjectsWithTag("Bullet");

        foreach (GameObject tGO in tBulletArray)
        {
            Destroy(tGO);
        }

        //If there are no Baskets left, restart the game
        //SceneManager.LoadScene("Main-Prototype1");
     
    }

    void OnTriggerEnter(Collider other)
    {
        // when the trigger is hit by something
        // check to see if it's a Projectile 
        if (other.gameObject.tag == "Goal")
        {
            // if so, set goalMet = true
            Goal_Prototype1.goalMet = true;

            // also set the alpha of the color of higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;

            winTextObject.SetActive(true);

            if (Goal_Prototype1.goalMet == true)
            {
                DestroyImmediate(maze, true);

                maze = Instantiate<GameObject>(mazes[level]);
                maze.transform.position = mazePos;
            }



        }
    }

        // Update is called once per frame
        void Update()
    {

    }
}
