using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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

	public enum MenuPhases {
		BASE,
		ATTACK,
		ITEM,
		RUN,
		FORFEIT
	}

	private CombatPhases currentPhase;

	public SimpleMonster player;
	public SimpleMonster opponent;
	public BattleStarterScript battleStarterScript;
	public GameObject snake;
	public GameObject bigSnake;
	public Button attackBtn;
	public Button fleeBtn;
	public Button forfeitBtn;
	public Button itemBtn;
	public Button switchBtn;
	public Canvas canvas;
	public Button defaultButton;
	public Text playerHp;
	public Text opponentHp;
	// Use this for initialization
	void Start () {
		currentPhase = CombatPhases.PLAYERMOVE;
		battleStarterScript = GameObject.FindGameObjectWithTag("BattleStarter").GetComponent<BattleStarterScript>();
		player = battleStarterScript.playerMonsters[0];
		opponent = battleStarterScript.opponent.monsters[0];
		playerHp.text = "HP: " + player.health;
		opponentHp.text = "HP: " + opponent.health;
		Instantiate(snake, new Vector3(4f, 2f, 0f), Quaternion.identity);
		Instantiate(bigSnake, new Vector3(-4f, -3f, 0f), bigSnake.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if(player.health <= 0) Application.LoadLevel(1);
		if(opponent.health <= 0) Application.LoadLevel(1);
		playerHp.text = "HP: " + player.health;
		opponentHp.text = "HP: " + opponent.health;
//		switch(currentPhase){
//		case CombatPhases.INIT:
//			initializeBattle();
//			break;
//		case CombatPhases.PLAYERMOVE:
//			playerMoveMenu();
//			break;
//		case CombatPhases.PLAYERATTACKMENU:
//			PlayerAttackMenu();
//			break;
//		case CombatPhases.PLAYERBAGMENU:
//			playerBagMenu();
//			break;
//		case CombatPhases.PLAYERMONSTERMENU:
//			playerMonsterMenu();
//			break;
//		case CombatPhases.PLAYERFLEE:
//			playerFlee();
//			break;
//		case CombatPhases.PLAYERANIMATE:
//			PlayerAnimate();
//			break;
//		case CombatPhases.OPPONENTMOVE:
//			opponentMove();
//			break;
//		case CombatPhases.OPPONENTANIMATE:
//			opponentAnimate();
//			break;
//		case CombatPhases.LOSE:
//			loseBattle();
//			break;
//		case CombatPhases.WIN:
//			winBattle(); 
//			break;
//		}
	}

	void initializeBattle(){
		//TODO: itialize player and opponent Monsters
		// deploy first monsters

	}

	public void playerMoveMenu(){
		Debug.Log ("Move");
		GameObject[] otherButtons = GameObject.FindGameObjectsWithTag("Respawn");
		for(int i=0; i< otherButtons.Length; i++){
			Destroy(otherButtons[i]);
		}
	}

	public void PlayerAttackMenu() {
		Debug.Log ("Attack");
//		attackBtn.enabled = false;
//		fleeBtn.enabled = false;
//		forfeitBtn.enabled = false;
//		itemBtn.enabled = false;
//		switchBtn.enabled = false;
		foreach(SimpleMove attack in player.moves){
			Button temp = Instantiate(defaultButton);
			temp.GetComponentInChildren<Text>().text = attack.name;
			temp.transform.SetParent(canvas.transform, false);
			temp.onClick.AddListener(()=>{
				PlayerAttack();
				playerMoveMenu();});
		}

	}

	public void playerBagMenu() {
		Debug.Log ("Bag");
	}

	public void PlayerAttack(){ // not what we 
		opponent.health -= 10;
		player.health -= 9;
	}


	public void playerMonsterMenu(){
		Debug.Log ("Monster");
	}

	public void playerFlee(){
	
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
