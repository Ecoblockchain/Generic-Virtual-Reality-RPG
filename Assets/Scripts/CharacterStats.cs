using UnityEngine;
using System.Collections.Generic;

public class CharacterStats : MonoBehaviour {
	public List<BaseStat> stats = new List<BaseStat> ();

	void Stat()
	{
		stats.Add (new BaseStat(4,"Power", "Your power level"));
		stats [0].AddStatBonus(new StatBonus(5));
		stats [0].AddStatBonus(new StatBonus(21));
		stats [0].AddStatBonus(new StatBonus(7));
		Debug.Log (stats[0].GetCalculatedStatValue());
	}


}
