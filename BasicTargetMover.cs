using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

	public float spinSpeed = 180.0f;
    public float motionMangnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

	// Update is called once per frame
	void Update () {

        if (doSpin)
        {
            // rotate around the axis up axis of the gameobject
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMotion)
        {
            //move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMangnitude);
        }
    }
}
