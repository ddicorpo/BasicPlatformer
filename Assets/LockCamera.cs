using UnityEngine;
using System.Collections;

public class LockCamera : MonoBehaviour {
    public GameObject movingBox;
    //public GameObject cameraH;
	// Use this for initialization
	void Start () {
	
	}
    float speed = 1.0f;
    // Update is called once per frame
    void Update()
    {
         
        var pos = new Vector3(movingBox.transform.position.x, movingBox.transform.position.y, transform.position.z);
        transform.position = pos;
    }
}
