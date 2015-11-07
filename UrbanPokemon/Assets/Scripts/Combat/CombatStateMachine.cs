using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	public enum CombatPhases{
		INIT,
		PLAYERMOVE,
		PLAYERATTACKMENU,
		PLAYERBAGMENU,
		PLAYERMONSTERMENU,
		PLAYERFLEE,
		PLAYERANIMATE,
		OPPONENTMOVE,
		OPPONENTANIMATE,
		LOSE,
		WIN
	}

	private CombatPhases currentPhase;

	// Use this for initialization
	void Start () {
		currentPhase = CombatPhases.INIT;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentPhase);
		switch(currentPhase){
		case CombatPhases.INIT:
			initializeBattle();
			break;
		case CombatPhases.PLAYERMOVE:
			playerMoveMenu();
			break;
		case CombatPhases.PLAYERATTACKMENU:
			PlayerAttackMenu();
			break;
		case CombatPhases.PLAYERBAGMENU:
			playerBagMenu();
			break;
		case CombatPhases.PLAYERMONSTERMENU:
			playerMonsterMenu();
			break;
		case CombatPhases.PLAYERFLEE:
			playerFlee();
			break;
		case CombatPhases.PLAYERANIMATE:
			PlayerAnimate();
			break;
		case CombatPhases.OPPONENTMOVE:
			opponentMove();
			break;
		case CombatPhases.OPPONENTANIMATE:
			opponentAnimate();
			break;
		case CombatPhases.LOSE:
			loseBattle();
			break;
		case CombatPhases.WIN:
			winBattle(); 
			break;
		}
	}

	void initializeBattle(){
		//TODO: itialize player and opponent Monsters
		// deploy first monsters
	}

	void playerMoveMenu(){
	}

	void PlayerAttackMenu() {
	}

	void playerBagMenu() {
	}

	void playerMonsterMenu(){
	}

	void playerFlee(){
	}

	void PlayerAnimate(){
	}

	void opponentMove(){
	}

	void opponentAnimate(){
	}

	void loseBattle(){
	}

	void winBattle(){
	}
}
