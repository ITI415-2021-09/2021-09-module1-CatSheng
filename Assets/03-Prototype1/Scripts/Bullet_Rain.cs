using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Rain : MonoBehaviour
{
    [Header("Set in Inspector")]

    //Prefab for instantiating apples
    public GameObject bulletPrefab;


    //Speed at which the AppleTRee moves
    public float speed = 1f;


    //Distance where AppleTree turns around
    public float leftAndRightEdge = 20f;


    //Chance that the AppleTree will change direction
    public float chanceToChangeDirection = 0.1f;


    //Rate at which Apples will be instantiate
    public float secondsBetweenBulletDrops = 1f;



    // Start is called before the first frame update
    void Start()
    {
        //Dropping apples every second
        Invoke("DropBullet", 2f);
    }

    void DropBullet()
    {
        GameObject bullet = Instantiate<GameObject>(bulletPrefab);

        bullet.transform.position = transform.position;

        Invoke("DropBullet", secondsBetweenBulletDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move left
        }

    }
    void FixedUpdate()
    {
        //Changing Direction Randomly is now time-based because of FixedUpdate()
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //Change Direction
        }
    }
}
