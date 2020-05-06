using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {
    public GameObject effectObject;
    private void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider.GetComponent<Trail>()!=null)
        {
            effectObject.SetActive(true);
            Debug.Log("Score");
        }
    }
    // Use this for initialization
    void Start () {
        effectObject.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
