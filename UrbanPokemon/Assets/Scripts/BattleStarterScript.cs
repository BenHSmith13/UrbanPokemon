using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BattleStarterScript : MonoBehaviour {
	public List<SimpleMonster> playerMonsters = new List<SimpleMonster>();
	public List<SimpleItem> playerItems = new List<SimpleItem>();
	public SimpleBattleNpc opponent;

	void OnEnable(){
		DontDestroyOnLoad(this.gameObject);
	}	

	void OnLevelWasLoaded(int level){
		Debug.Log ("level is loaded");
		if(level != 0){
			// add logic to add things back into game controller
			Destroy(this.gameObject);
		}
	}
}
