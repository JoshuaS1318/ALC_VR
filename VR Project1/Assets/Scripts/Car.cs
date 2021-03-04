
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Points for the car to go to when it enters a tunnel
    private Vector3 point1 = new Vector3(16, 1, 30); 
    private Vector3 point2 = new Vector3(18.5f, 1, -26);

    // Car speed
    public float speed = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));

        if (transform.position.z < -30)
        {
            transform.position = point1;
        }
        else if (transform.position.z > 32)
        {
            transform.position = point2;
        }
    }
}
