using UnityEngine;
using System.Collections;

public class NPC : Interactable {
	public string[] dialogue;
	public string title;

	public override void Interact()
	{
		DialogueSystem.Instance.AddNewDialogue(dialogue, title);
		Debug.Log ("Interacting with NPC with " + title.ToUpper() + " as the title");
	}
}
