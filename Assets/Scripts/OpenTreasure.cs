using UnityEngine;
using System.Collections;

public class OpenTreasure : ActionItem, IGvrGazeResponder {
	public string[] dialogue;

	public override void Interact()
	{
		DialogueSystem.Instance.AddNewDialogue (dialogue, "Tema Treasure");
		Debug.Log("Interacting with treasure (base ActionItem)");
	}

	#region IGvrGazeResponder implementation

	public void OnGazeEnter ()
	{
		Debug.Log ("Treasure Gaze");
	}

	public void OnGazeExit ()
	{
		throw new System.NotImplementedException ();
	}

	public void OnGazeTrigger ()
	{
		Debug.Log ("Attempt to open treasure!");
	}

	#endregion
}
