using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    Rigidbody2D rigidBodyBird;

    public float jumPower = 5;


    // Start is called before the first frame update
    void Start()
    {
        
        rigidBodyBird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBodyBird.velocity = Vector2.up*jumPower;
        }
    }
}
