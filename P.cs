 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour {

    public Trail Ball;
    public GameObject PlayerCamera; 
    public float BallDistance= 2f ;
    public float ThrowingForce = 2f;
    public bool holdingBall = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (holdingBall)
        {
            Ball.GetComponent<Rigidbody>().useGravity = false;
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Ball.ActivateTrail();
                Ball.GetComponent<Rigidbody>().useGravity = true;
                holdingBall = false;
                Ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * ThrowingForce);
                    }
           
        }
	}
}
