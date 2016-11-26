﻿using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour {

	NavMeshAgent playerAgent;
	private Vector3 startingPosition;


	// Use this for initialization
	void Start () 
	{
		playerAgent = GetComponent<NavMeshAgent>();
		startingPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (SetGazedAt(true))
			GetInteraction ();	

	}

	public void Reset() {
		transform.localPosition = startingPosition;
	}

	public void GetInteraction()
	{
		Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Debug.DrawRay(interactionRay.origin, interactionRay.direction * 10, Color.yellow);
		RaycastHit interactionInfo;

		if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
		{
			GameObject interactedObject = interactionInfo.collider.gameObject;
			if (interactedObject.tag == "Interactable Object") 
			{
				interactedObject.GetComponent<Interactable> ().MoveToInteraction (playerAgent);
			} 
			else 
			{
				playerAgent.stoppingDistance = 0.0f;
				playerAgent.destination = interactionInfo.point;
			}
		}
	}



}
