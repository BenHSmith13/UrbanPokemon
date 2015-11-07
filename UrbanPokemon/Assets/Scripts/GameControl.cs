using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static int money;
	public static float playerStartPosX;
	public static float playerStartPosY;
	public static List <SimpleItem> items;
	public static List <SimpleNPC> simpleNPCs;
	public static List <SimpleBattleNpc> simpleBattleNpcs;
	public static List <SimpleMonster> playersMonsters;
	public static string name;
	public GameObject npcPrefab;
	public GameObject battleStarter;
	public static GameObject bStarter;
	public static GameObject staticNpcPrefab;

	void Awake(){
		bStarter = battleStarter;
		staticNpcPrefab = npcPrefab;
		PlayerData data = DataScript.Load();
		Debug.Log(data.name);
		name = data.name;
//		if(data.name.Equals("uninitialized")){
//			items = new List<SimpleItem>();
//			playersMonsters = new List<SimpleMonster>();
//			SimpleMonster monster = new SimpleMonster();
//			monster.name = "Snake";
//			monster.level = 10;
//			monster.totalExp = 10000;
//			monster.moves = new List<SimpleMove>();
//			monster.status = "OK";
//			monster.type = "snake";
//			monster.health = 100;
//			monster.id = 1;
//			SimpleMove move = new SimpleMove();
//			move.name = "Bite";
//			move.baseAttack = 10;
//			move.accuracy = 95;
//			move.id = 1;
//			move.type = "snake";
//			monster.moves.Add (move);
//			playersMonsters.Add(monster);
//			SimpleBattleNpc bNpc = new SimpleBattleNpc();
//			bNpc.finishBattleText = "You suck!";
//			bNpc.moneyGiven = 10;
//			bNpc.monsters = new List<SimpleMonster>();
//			monster = new SimpleMonster();
//			monster.name = "Snake";
//			monster.level = 10;
//			monster.totalExp = 10000;
//			monster.moves = new List<SimpleMove>();
//			monster.status = "OK";
//			monster.type = "snake";
//			monster.health = 100;
//			monster.id = 1;
//			move = new SimpleMove();
//			move.name = "Bite";
//			move.baseAttack = 10;
//			move.accuracy = 95;
//			move.id = 1;
//			move.type = "snake";
//			monster.moves.Add (move);
//			bNpc.monsters.Add(monster);
//			bNpc.name = "Ben Call";
//			bNpc.id = 1;
//			bNpc.xPos = 3f;
//			bNpc.yPos = 3f;
//			simpleBattleNpcs = new List<SimpleBattleNpc>();
//			simpleBattleNpcs.Add(bNpc);
//			SimpleItem item = new SimpleItem();
//			item.buyCost = 100;
//			item.name = "Potion";
//			item.sellCost = 50;
//			items.Add(item);
//			SimpleNPC npc = new SimpleNPC();
//			npc.name = "Ben Smith";
//			npc.conversationText = "Felgergarb";
//			npc.xPos = 1.0f;
//			npc.yPos = 10.0f;
//			simpleNPCs = new List<SimpleNPC>();
//			simpleNPCs.Add(npc);
//			money = 100;
//			playerStartPosX = 0f;
//			playerStartPosY = 0f;
//			data.name = "Joseph";
//			data.items = items;
//			data.simpleNpcs = simpleNPCs;
//			DataScript.Save (data);
//		}
		Debug.Log (data.money);
		foreach(SimpleItem item in data.items){
			Debug.Log (item.name);
		}
		foreach(SimpleNPC npc in data.simpleNpcs){
			Debug.Log (npc.name);
		}
		data.name = "uninitialized";
		DataScript.Save (data);
	}

	void Start(){
		foreach(SimpleBattleNpc npc in simpleBattleNpcs){
			GameObject bNpc = (GameObject)Instantiate(npcPrefab, new Vector3(npc.xPos, npc.yPos, 0f), Quaternion.identity);
			bNpc.GetComponent<BattleNpc>().data = npc;
		}
	}

	public static void EnterBattleScene(int npcId){
		SimpleBattleNpc npc = simpleBattleNpcs.Find(item => item.id == npcId);
		GameObject newBattle = (GameObject)Instantiate(bStarter);
		BattleStarterScript bsScript =  newBattle.GetComponent<BattleStarterScript>();
		bsScript.name = name;
		bsScript.playerItems = items;
		bsScript.opponent = npc;
		bsScript.playerMonsters = playersMonsters;
		Application.LoadLevel(0);
	}
}
