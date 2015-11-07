using UnityEngine;
using System.Collections;

public class SimpleMonster {
	public string name;
	public int level;
	public int totalExp;
	public SimpleMove[] moves;
	public string type;
}

public class SimpleMove {
	public int baseAttack;
	public int accuracy;
	public string name;
	public string type;
}

public class SimpleNPC {
	public string name;
	public string conversationText;
}

public class SimpleBattleNpc {
	public string name;
	public string startBattleText;
	public string finishBattleText;
	public SimpleMonster[] monsters;
	public int moneyGiven;
}

public class SimpleTrophy { // probably should call this something else
	public string city;
}

public class SimpleItem {
	public int buyCost;
	public int sellCost;
	public string name;
	public string type;
}


