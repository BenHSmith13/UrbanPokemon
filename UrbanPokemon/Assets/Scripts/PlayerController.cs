using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float xDir;
	public float yDir;
	public Sprite up;
	public Sprite down;
	public Sprite left;
	public Sprite right;
	public Animator animator;
	void Awake () {
		xDir = 0f;
		yDir = 0f;
		animator = gameObject.GetComponent<Animator>();
	}


	void Update () {
		if(Input.GetAxis("Horizontal") == 0f){
			this.animator.SetBool("WalkingLeft", false);
			this.animator.SetBool("WalkingRight", false);
		}
		if(Input.GetAxis("Vertical") == 0f){
			this.animator.SetBool("WalkingUp", false);
			this.animator.SetBool("WalkingDown", false);
		}
		Move ();
	}

	void Move () {
		this.yDir = Input.GetAxis("Vertical");
		this.xDir = Input.GetAxis("Horizontal");
		if(this.xDir > 0) {
			SetRight();
		}
		if(this.xDir < 0) {
			SetLeft();
		}
		if(this.yDir > 0) {
			SetUp();
		}
		if(this.yDir < 0) {
			SetDown ();
		}
		transform.Translate(this.xDir * speed * Time.deltaTime, this.yDir * speed * Time.deltaTime, 0f);
	}

	void SetRight(){
		this.animator.SetBool("StandingRight", true);
		this.animator.SetBool("WalkingRight", true);
		this.animator.SetBool("WalkingLeft", false);
		this.animator.SetBool("WalkingDown", false);
		this.animator.SetBool("WalkingUp", false);
		this.animator.SetBool("StandingDown", false);
		this.animator.SetBool("StandingUp", false);
		this.animator.SetBool("StandingLeft", false);
	}
	void SetLeft(){
		this.animator.SetBool("StandingRight", false);
		this.animator.SetBool("WalkingRight", false);
		this.animator.SetBool("WalkingLeft", true);
		this.animator.SetBool("WalkingDown", false);
		this.animator.SetBool("WalkingUp", false);
		this.animator.SetBool("StandingDown", false);
		this.animator.SetBool("StandingUp", false);
		this.animator.SetBool("StandingLeft", true);
	}
	void SetUp(){
		this.animator.SetBool("StandingRight", false);
		this.animator.SetBool("WalkingRight", false);
		this.animator.SetBool("WalkingLeft", false);
		this.animator.SetBool("WalkingDown", false);
		this.animator.SetBool("WalkingUp", true);
		this.animator.SetBool("StandingDown", false);
		this.animator.SetBool("StandingUp", true);
		this.animator.SetBool("StandingLeft", false);
	}
	void SetDown(){
		this.animator.SetBool("StandingRight", false);
		this.animator.SetBool("WalkingRight", false);
		this.animator.SetBool("WalkingLeft", false);
		this.animator.SetBool("WalkingDown", true);
		this.animator.SetBool("WalkingUp", false);
		this.animator.SetBool("StandingDown", true);
		this.animator.SetBool("StandingUp", false);
		this.animator.SetBool("StandingLeft", false);
	}

}
