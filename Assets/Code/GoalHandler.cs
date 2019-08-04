using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) 
    {
        if ( other.gameObject.GetComponent<PongBall>() != null )
        {
            Debug.Log("GOAL!!");
        }
        else
        {
            //Debug.Log("no!!" + other.gameObject.name );
        }
    }

}
