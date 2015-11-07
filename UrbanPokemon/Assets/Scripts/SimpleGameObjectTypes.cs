using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class SimpleMonster {
	public string name;
	public int level;
	public int totalExp;
	public List <SimpleMove> moves;
	public string type;
	public string status;
}

[Serializable]
public class SimpleMove {
	public int baseAttack;
	public int accuracy;
	public string name;
	public string type;
}

[Serializable]
public class SimpleNPC {
	public string name;
	public string conversationText;
	public int sceneNumber;
	public float xPos;
	public float yPos;
}

[Serializable]
public class SimpleBattleNpc {
	public string name;
	public string startBattleText;
	public string finishBattleText;
	public List <SimpleMonster> monsters;
	public int moneyGiven;
	public int sceneNumber;
	public float xPos;
	public float yPos;
}

[Serializable]
public class SimpleTrophy { // probably should call this something else
	public string city;
}

[Serializable]
public class SimpleItem {
	public int buyCost;
	public int sellCost;
	public string name;
	public string type;
	public void use(){}
}


