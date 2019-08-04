using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
 
    public float horizontalVelocity;
    public float baseVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
        //GetComponent<Rigidbody>().velocity = new Vector3( horizontalVelocity, 0f, 0f );

    }

    // Update is called once per frame
    void Update()
    {
                

        Vector3 v = GetComponent<Rigidbody>().velocity;
        Vector3 vNorm = v.normalized;
        vNorm.y = 0f;
        v = baseVelocity * vNorm;
        GetComponent<Rigidbody>().velocity = v;


        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddTorque( new Vector3( 0f, 0f, horizontalVelocity ) , ForceMode.Acceleration ); 
        }
    }
}
