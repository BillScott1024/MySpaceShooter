using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, 5.0f);
            rb.velocity = movement * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
