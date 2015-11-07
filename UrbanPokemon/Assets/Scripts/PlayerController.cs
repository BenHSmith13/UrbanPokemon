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
		Move ();
	}

	void Move () {
		this.yDir = Input.GetAxis("Vertical");
		this.xDir = Input.GetAxis("Horizontal");
		if(this.xDir > 0) {

			gameObject.GetComponent<SpriteRenderer>().sprite = right;
		}
//		if(this.xDir < 0) {
//			gameObject.GetComponent<SpriteRenderer>().sprite = left;
//		}
//		if(this.yDir > 0) {
//			gameObject.GetComponent<SpriteRenderer>().sprite = up;
//		}
//		if(this.yDir < 0) {
//			gameObject.GetComponent<SpriteRenderer>().sprite = down;
//		}
		transform.Translate(this.xDir * speed * Time.deltaTime, this.yDir * speed * Time.deltaTime, 0f);
	}

	void SetRight(){

	}
	void SetLeft(){

	}
	void SetUp(){

	}
	void SetDown(){

	}

}
