using UnityEngine;
using System.Collections;

public class BackGroundScroller : MonoBehaviour {
    private float speed = 0;
    private static BackGroundScroller current;
    float pos = 0;
    

	// Use this for initialization
	void Start () {
        current = this;
	}
	
	// Update is called once per frame
	void Update () {
        pos += speed;
        if (pos > 1.0f)
            pos -= 1.0f;
      
	}
}
