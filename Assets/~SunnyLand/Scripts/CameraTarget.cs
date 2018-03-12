using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour {
    public Transform Target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void LateUpdate()
    {
        gameObject.GetComponent<Transform>().position = Vector3.Lerp(gameObject.GetComponent<Transform>().position, Target.position, Time.deltaTime * 10);
    }
}
