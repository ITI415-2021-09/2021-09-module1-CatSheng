using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prototype_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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

    // Update is called once per frame
    void Update()
    {

    }
}
