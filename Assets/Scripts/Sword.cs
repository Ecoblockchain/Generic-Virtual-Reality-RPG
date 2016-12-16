using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon {
	#region IWeapon implementation

	public List<BaseStat> Stats { get; set; }

	public void PerformAttack ()
	{
		//
		Debug.Log("Sword Attack");
	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
