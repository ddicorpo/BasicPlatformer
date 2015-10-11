using UnityEngine;
using System.Collections;
using System;
public class DeleteObjects : MonoBehaviour {
    public GameObject whatDestroyed;
	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(System.Math.Abs(transform.position.x- Camera.main.transform.position.x)>55 && transform.position.x>1.7)
        {
            Destroy(this.gameObject);
            Debug.LogWarning("DESTROYED!");
        }
	}
}
