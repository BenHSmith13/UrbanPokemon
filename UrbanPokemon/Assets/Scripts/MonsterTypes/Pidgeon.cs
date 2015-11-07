using System;
using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Pidgeon : SimpleMonster {
	
	Pidgeon (int initLevel, string petName) {
		type = "pidgeon";
		name = petName;
		hpMulitplier = 1.1;
		expMultiplier = 1.7;
		attackMultiplier = 1.3;
		defenceMultiplier = 1.1;
		speedMultipler = 1.5;
		accuracyMultiplier = 1.4;
		initStats(level);
	}
	
	void initStats(int initLevel){
		level = initLevel;
		totalHp = (int)10*hpMulitplier + initLevel*hpMulitplier;
		totalExp = 0;
		attack = (int)5*attackMultiplier + initLevel/2 * attackMultiplier;
		defence = (int)5*defenceMultiplier + initLevel/2 * defenceMultiplier;
		speed = (int)5*speedMultipler + initLevel/2 * speedMultipler;
		accuracy = (int)5*accuracyMultiplier + initLevel/2 * accuracyMultiplier;
		initMoveList (initLevel);
	}
	
	void initMoveList(int initLevel){
		if (initLevel > 50) {
			moves = new List<SimpleMove> ();
		} else if (initLevel > 30) {
			moves = new List<SimpleMove> ();
		} else if (initLevel > 20) {
			moves = new List<SimpleMove> ();
		} else if (initLevel > 10) {
			moves = new List<SimpleMove> ();
		} else if (initLevel > 5) {
			moves = new List<SimpleMove> ();
		}
	}
	
	void forgetMove(SimpleMove move){
		//TODO: write this
	}
	
	void newLevelUpMove(){
		if (level > 50) {
			moves = new List<SimpleMove> ();
		} else if (level > 30) {
			moves = new List<SimpleMove> ();
		} else if (level > 20) {
			moves = new List<SimpleMove> ();
		} else if (level > 10) {
			moves = new List<SimpleMove> ();
		} else if (level > 5) {
			moves = new List<SimpleMove> ();
		}
	}
	
	void levelUp(){
		level ++;
		totalHp += (int)level*hpMulitplier;
		totalExp = 0;
		attack = (int)level/2 * attackMultiplier;
		defence = (int)level/2 * defenceMultiplier;
		speed = (int)level/2 * speedMultipler;
		accuracy = (int)level/2 * accuracyMultiplier;
		newLevelUpMove ();
	}
	
}
