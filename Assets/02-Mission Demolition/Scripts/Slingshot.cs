using System.Collections;

using UnityEngine;

public class Slingshot : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseEnter()
    {
        print("Slingshot: OnMouseEnter()");
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        print("Slingshot: OnMouseExit()");
    }
}
