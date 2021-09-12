using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    //Prefab for instantiating apples
    public GameObject applePrefab;


    //Speed at which the AppleTRee moves
    public float speed = 1f;


    //Distance where AppleTRee turns around
    public float leftAndRightEdge = 10f;


    //Chance that the AppleTree will change direction
    public float chanceToChangeDirection = 0.1f;


    //Rate at which Apples will be instantiate
    public float secondsBetweenAppleDrop = 1f; 



    // Start is called before the first frame update
    void Start()
    {
        //Dropping apples every second
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
