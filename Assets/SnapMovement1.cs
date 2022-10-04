using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapMovement1 : MonoBehaviour
{
    Vector3 startPos;
    
    public Transform hazard;
    public AudioClip impact;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; 
       // audiosource (getcomponent"")
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("Hello World");
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("Hello World");
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("Hello World");
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Hello World");
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Hello World");
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Hello World");
            transform.position += Vector3.down;
        }
        
            if (transform.position == hazard.position)
            {

                transform.position = startPos;
            }
        


    }
}
