using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            //Get a reference to the ApplePicker component of Main Camera
            Prototype_1 apScript = Camera.main.GetComponent<Prototype_1>();

            //Call the public AppleDestroyed() method of apScript
            apScript.BulletDestroyed();
        }

    }
}
