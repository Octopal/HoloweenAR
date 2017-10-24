using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ARCameraBehaviour : MonoBehaviour {

	[SerializeField] private Transform imageTarget;
	[SerializeField] private Transform hellClown;
	private HellportalTrackableEventHandler hellPortal;

	void Awake()
	{
		hellClown.gameObject.SetActive(false);
		hellPortal = imageTarget.GetComponent<HellportalTrackableEventHandler>();
	}

	void Update () 
	{
		if(imageTarget != null && hellPortal.IsActive)
		{
			float dist = Vector3.Distance(transform.position, imageTarget.position);
			if(dist < .5f)
				{
					hellClown.gameObject.SetActive(true);
				}
		}
	}
}
