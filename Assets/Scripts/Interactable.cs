﻿using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {
	[HideInInspector]
	public NavMeshAgent playerAgent;
	private bool hasInteracted;

	public virtual void MoveToInteraction(NavMeshAgent playerAgent)
	{
		hasInteracted 				 = false;
		this.playerAgent 			 = playerAgent;
		playerAgent.stoppingDistance = 2f;
		playerAgent.destination 	 = this.transform.position;

		//Interact ();
	}

	void Update()
	{
		if (!hasInteracted && playerAgent !=null && !playerAgent.pathPending) {
			if(playerAgent.remainingDistance <= playerAgent.stoppingDistance)
			{
				Interact ();
				hasInteracted = true;
			}
			
		}
	}

	public virtual void Interact()
	{
		Debug.Log ("Interacting with base class.");
	}
}
