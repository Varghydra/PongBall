using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControl : MonoBehaviour
{
    public float bounceForce;
    public float moveVelocity;
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public float maxAngle;
    public float minAngle;

    public float curAngle;
    public float radius;

    public bool isAutonomous;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if( isAutonomous )
        {
            //implement
        }
        else
        {
            if (Input.GetKey( moveForward ) && curAngle < maxAngle )
            {
                curAngle += moveVelocity * Time.deltaTime;
            }
            
            if (Input.GetKey( moveBackward ) && curAngle > minAngle )
            {
                curAngle -= moveVelocity * Time.deltaTime;
            }
        }

        transform.Find("Brick").localPosition = new Vector3( radius * Mathf.Cos( Mathf.Deg2Rad * curAngle ), 0f, radius * Mathf.Sin( Mathf.Deg2Rad * curAngle ) );
        transform.Find("Brick").eulerAngles = new Vector3( 0f, transform.eulerAngles.y - curAngle, 0f );
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HIT RACKET!!");

        // ContactPoint contact = collision.contacts[0];
        // Vector3 bounceVector = bounceForce * contact.normal;
        // collision.gameObject.GetComponent<Rigidbody>().AddForce( bounceVector, ForceMode.Acceleration );
    }
}
