using UnityEngine;
using System.Collections;

public class StatBonus {

	public int BonusVaue { get; set;}

	public StatBonus(int bonusValue)
	{
		this.BonusVaue = bonusValue;
		Debug.Log ("New stat bonus initiated.");
	}
}
