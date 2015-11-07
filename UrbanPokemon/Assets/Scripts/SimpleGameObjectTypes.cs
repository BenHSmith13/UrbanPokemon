using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class SimpleMonster {
	public int id;
	public string name;
	public int level;
	public int totalHp;
	public int totalExp;
	public int hp;
	public int attack;
	public int defence;
	public int speed;
	public int accuracy;
	public List <SimpleMove> moves;
	public string type;
	public string status;

	public int health;
	public float hpMulitplier;
	public float expMultiplier;
	public float attackMultiplier;
	public float defenceMultiplier;
	public float speedMultipler;
	public float accuracyMultiplier;

	void takeHit(int damage){
		hp -= damage;
		if (hp <= 0) { die (); }
	}
	
	void heal(int healthPac){
		hp += healthPac;
		if (hp > totalHp) { hp = totalHp; }
	}

	void forgetMove(SimpleMove move){
		//TODO: Write ForgetMove
	}

	public void increaseTotalHp(int powerUp){
		totalHp += powerUp;
	}
	public void increaseAttack(int powerUp){
		attack += powerUp;
	}
	public void increaseDefense(int powerUp){
		defence += powerUp;
	}
	public void increaseSpeed(int powerUp){
		speed += powerUp;
	}
	public void increaseAccuracy(int powerUp){
		accuracy += powerUp;
	}
	
	public void decreaseAttack(int debuff){
		attack += debuff;
	}
	public void decreaseDefense(int debuff){
		defence += debuff;
	}
	public void decreaseSpeed(int debuff){
		speed += debuff;
	}
	public void decreaseAccuracy(int debuff){
		accuracy += debuff;
	}
	
	public void die(){
		//TODO: kill your monster
	};
}

[Serializable]
public class SimpleMove {
	public int id;
	public int baseAttack;
	public int accuracy;
	public string name;
	public string type;
}

[Serializable]
public class SimpleNPC {
	public int id;
	public string name;
	public string conversationText;
	public int sceneNumber;
	public float xPos;
	public float yPos;
}

[Serializable]
public class SimpleBattleNpc {
	public int id;
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
	public int id;
	public int buyCost;
	public int sellCost;
	public string name;
	public string type;
	public void use(){}
}


