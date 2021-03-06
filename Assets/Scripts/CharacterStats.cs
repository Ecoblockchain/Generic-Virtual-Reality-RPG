﻿using UnityEngine;
using System.Collections.Generic;

public class CharacterStats : MonoBehaviour {
	public List<BaseStat> stats = new List<BaseStat> ();

	void Stat()
	{
		stats.Add (new BaseStat(4,"Power", "Your power level"));
		stats.Add (new BaseStat(2,"Vitality", "Your vitality level"));
//		stats [0].AddStatBonus(new StatBonus(5));
//		stats [0].AddStatBonus(new StatBonus(21));
//		stats [0].AddStatBonus(new StatBonus(7));
		Debug.Log (stats[0].GetCalculatedStatValue());
	}

	public void AddStatBonus(List<BaseStat> statBonuses){
		foreach(BaseStat statBonus in statBonuses){
			stats.Find (x => x.StatName == statBonus.StatName).AddStatBonus (new StatBonus(statBonus.BaseValue));
		}
	}

	public void RemoveStatBonus(List<BaseStat> statBonuses){
		foreach(BaseStat statBonus in statBonuses){
			stats.Find (x => x.StatName == statBonus.StatName).RemoveStatBonus (new StatBonus(statBonus.BaseValue));
		}
	}
}
