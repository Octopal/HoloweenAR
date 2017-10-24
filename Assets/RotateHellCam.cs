using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHellCam : MonoBehaviour {

	private Vector3 rotationOffset = new Vector3( -90, -90, 90);


	void Update () {
		transform.rotation = Camera.main.transform.rotation * Quaternion.Euler(rotationOffset);
	}
}
